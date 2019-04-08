﻿using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using Slipe.Server.Acl;
using System.ComponentModel;
using Slipe.Server.Peds;

namespace Slipe.Server.Accounts
{
    /// <summary>
    /// The account class represents a player's server account. 
    /// </summary>
    public class Account : IAclObject
    {
        private MtaAccount _account;

        #region Properties

        public MtaAccount MTAAccount { get; }

        /// <summary>
        /// This function checks to see if an account is a guest account. 
        /// </summary>
        public bool IsGuestAccount
        {
            get
            {
                return MtaServer.IsGuestAccount(_account);
            }
        }

        /// <summary>
        /// Get the username of this account
        /// </summary>
        public string Name
        {
            get
            {
                return MtaServer.GetAccountName(_account);
            }
        }

        /// <summary>
        /// Get the ID of the account
        /// </summary>
        public int ID
        {
            get
            {
                return MtaServer.GetAccountID(_account);
            }
        }

        /// <summary>
        /// Get the IP of the account
        /// </summary>
        public string IP
        {
            get
            {
                return MtaServer.GetAccountIP(_account);
            }
        }

        /// <summary>
        /// Get the serial of this account
        /// </summary>
        public string Serial
        {
            get
            {
                return MtaServer.GetAccountSerial(_account);
            }
        }

        /// <summary>
        /// Get the player currently playing on this account if any
        /// </summary>
        public Player Player
        {
            get
            {
                try
                {
                    return (Player)ElementManager.Instance.GetElement(MtaServer.GetAccountPlayer(_account));
                }
                catch (MtaException)
                {
                    throw new AccountException("No player can be found using this account");
                }
            }
        }

        /// <summary>
        /// Returns the identifiable string user.{name}
        /// </summary>
        public string ACLIdentifier
        {
            get
            {
                return "user." + Name;
            }
        }

        /// <summary>
        /// Returns a dictionary of all the data stored in this account
        /// </summary>
        public Dictionary<string, string> Data
        {
            get
            {
                return MtaShared.GetDictionaryFromTable(MtaServer.GetAllAccountData(_account), "System.String", "System.String");
            }
        }

        #endregion

        #region Static Properties

        /// <summary>
        /// Returns an array of all existing accounts
        /// </summary>
        public static Account[] All
        {
            get
            {
                MtaAccount[] array = MtaShared.GetArrayFromTable(MtaServer.GetAccounts(), "account");
                Account[] accounts = new Account[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    accounts[i] = new Account(array[i]);
                }
                return accounts;
            }
        }

        /// <summary>
        /// Returns an array of all accounts that were logged onto from a serial
        /// </summary>
        public static Account[] GetAccountsBySerial(string serial)
        {
            dynamic[] array = MtaShared.GetArrayFromTable(MtaServer.GetAccountsBySerial(serial), "account");
            Account[] accounts = new Account[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                accounts[i] = new Account((MtaAccount)array[i]);
            }
            return accounts;
        }

        /// <summary>
        /// Returns an array containing all accounts that were logged onto from specified IP-address.
        /// </summary>
        public static Account[] GetAccountsByIP(string ip)
        {
            dynamic[] array = MtaShared.GetArrayFromTable(MtaServer.GetAccountsByIP(ip), "account");
            Account[] accounts = new Account[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                accounts[i] = new Account((MtaAccount)array[i]);
            }
            return accounts;
        }

        /// <summary>
        /// Returns an array containing all accounts with specified dataName and value (
        /// </summary>
        public static Account[] GetAccountsByData(string key, string value)
        {
            dynamic[] array = MtaShared.GetArrayFromTable(MtaServer.GetAccountsByData(key, value), "account");
            Account[] accounts = new Account[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                accounts[i] = new Account((MtaAccount)array[i]);
            }
            return accounts;
        }

        #endregion

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Account(MtaAccount MTAAccount)
        {
            _account = MTAAccount;
        }

        /// <summary>
        /// This function adds an account to the list of registered accounts of the current server.
        /// </summary>
        public Account(string name, string password, bool caseSensitive = false)
        {
            try
            {
                _account = MtaServer.AddAccount(name, password, caseSensitive);
            }
            catch (MtaException)
            {
                throw new AccountException("The account with the specified name already exists");
            }

        }
        #endregion

        #region Methods

        /// <summary>
        /// This function copies all of the data from one account to this account
        /// </summary>
        public bool CopyFrom(Account fromAccount)
        {
            return MtaServer.CopyAccountData(_account, fromAccount.MTAAccount);
        }

        /// <summary>
        /// This function retrieves a string that has been stored using SetData.
        /// </summary>
        public string GetData(string key)
        {
            return MtaServer.GetAccountData(_account, key);
        }

        /// <summary>
        /// This function sets a string to be stored in an account.
        /// </summary>
        public bool SetData(string key, string value)
        {
            return MtaServer.SetAccountData(_account, key, value);
        }

        /// <summary>
        /// Removes this account from the server
        /// </summary>
        public bool Remove()
        {
            return MtaServer.RemoveAccount(_account);
        }

        /// <summary>
        /// Sets the name of an account
        /// </summary>
        public bool SetName(string name, bool caseSensitive = false)
        {
            return MtaServer.SetAccountName(_account, name, caseSensitive);
        }

        /// <summary>
        /// Used to set the password of this account, encrypted with sha256
        /// </summary>
        public bool SetPassword(string value)
        {
            return MtaServer.SetAccountPassword(_account, value);
        }

        /// <summary>
        /// Check if the object has access to a given action
        /// </summary>
        public bool HasPermissionTo(string action, bool defaultPermission = true)
        {
            return MtaServer.HasObjectPermissionTo(ACLIdentifier, action, defaultPermission);
        }

        /// <summary>
        /// Check if the object is in a certain ACL group
        /// </summary>
        public bool IsInACLGroup(AclGroup group)
        {
            return MtaServer.IsObjectInACLGroup(ACLIdentifier, group.ACL);
        }

        #endregion

        #region Static Methods

        /// <summary>
        /// Get an account from some credentials
        /// </summary>
        public static Account Get(string username, string password = null, bool caseSensitive = true)
        {
            try
            {
                return new Account(MtaServer.GetAccount(username, password, caseSensitive));
            }
            catch (MtaException)
            {
                throw new AccountException("No account with these credentials could be found");
            }
        }

        /// <summary>
        /// Get an account from an account ID
        /// </summary>
        public static Account GetByID(int ID)
        {
            try
            {
                return new Account(MtaServer.GetAccountByID(ID));
            }
            catch (MtaException)
            {
                throw new AccountException("No account with this ID found");
            }
        }

        #endregion

    }
}
