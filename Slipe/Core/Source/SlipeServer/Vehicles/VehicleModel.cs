﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Vehicles
{
    /// <summary>
    /// Class for all other road vehicle models
    /// </summary>
    public class VehicleModel : BaseVehicleModel
    {
        public static class Vehicle
        {
            public static VehicleModel Bf400 { get { return new VehicleModel(581); } }
            public static VehicleModel Faggio { get { return new VehicleModel(462); } }
            public static VehicleModel Fcr900 { get { return new VehicleModel(521); } }
            public static VehicleModel Freeway { get { return new VehicleModel(463); } }
            public static VehicleModel Hpv1000 { get { return new VehicleModel(523); } }
            public static VehicleModel Nrg500 { get { return new VehicleModel(522); } }
            public static VehicleModel Pcj600 { get { return new VehicleModel(461); } }
            public static VehicleModel Pizzaboy { get { return new VehicleModel(448); } }
            public static VehicleModel Sanchez { get { return new VehicleModel(468); } }
            public static VehicleModel Wayfarer { get { return new VehicleModel(586); } }
            public static VehicleModel Quadbike { get { return new VehicleModel(471); } }
            public static VehicleModel Bike { get { return new VehicleModel(509); } }
            public static VehicleModel Bmx { get { return new VehicleModel(481); } }
            public static VehicleModel Mountainbike { get { return new VehicleModel(510); } }
            public static VehicleModel Alpha { get { return new VehicleModel(602); } }
            public static VehicleModel Banshee { get { return new VehicleModel(429); } }
            public static VehicleModel Buffalo { get { return new VehicleModel(402); } }
            public static VehicleModel Bullet { get { return new VehicleModel(541); } }
            public static VehicleModel Cheetah { get { return new VehicleModel(415); } }
            public static VehicleModel Comet { get { return new VehicleModel(480); } }
            public static VehicleModel Elegy { get { return new VehicleModel(562); } }
            public static VehicleModel Euros { get { return new VehicleModel(587); } }
            public static VehicleModel Flash { get { return new VehicleModel(565); } }
            public static VehicleModel Infernus { get { return new VehicleModel(411); } }
            public static VehicleModel Jester { get { return new VehicleModel(559); } }
            public static VehicleModel Phoenix { get { return new VehicleModel(603); } }
            public static VehicleModel Sultan { get { return new VehicleModel(560); } }
            public static VehicleModel Supergt { get { return new VehicleModel(506); } }
            public static VehicleModel Turismo { get { return new VehicleModel(451); } }
            public static VehicleModel Uranus { get { return new VehicleModel(558); } }
            public static VehicleModel Windsor { get { return new VehicleModel(555); } }
            public static VehicleModel Zr350 { get { return new VehicleModel(477); } }
            public static VehicleModel Blade { get { return new VehicleModel(536); } }
            public static VehicleModel Broadway { get { return new VehicleModel(575); } }
            public static VehicleModel Buccaneer { get { return new VehicleModel(518); } }
            public static VehicleModel Esperanto { get { return new VehicleModel(419); } }
            public static VehicleModel Remington { get { return new VehicleModel(534); } }
            public static VehicleModel Savanna { get { return new VehicleModel(567); } }
            public static VehicleModel Slamvan { get { return new VehicleModel(535); } }
            public static VehicleModel Tornado { get { return new VehicleModel(576); } }
            public static VehicleModel Voodoo { get { return new VehicleModel(412); } }
            public static VehicleModel Blistacompact { get { return new VehicleModel(496); } }
            public static VehicleModel Bravura { get { return new VehicleModel(401); } }
            public static VehicleModel Cadrona { get { return new VehicleModel(527); } }
            public static VehicleModel Clover { get { return new VehicleModel(542); } }
            public static VehicleModel Feltzer { get { return new VehicleModel(533); } }
            public static VehicleModel Fortune { get { return new VehicleModel(526); } }
            public static VehicleModel Hermes { get { return new VehicleModel(474); } }
            public static VehicleModel Hustler { get { return new VehicleModel(545); } }
            public static VehicleModel Majestic { get { return new VehicleModel(517); } }
            public static VehicleModel Manana { get { return new VehicleModel(410); } }
            public static VehicleModel Previon { get { return new VehicleModel(436); } }
            public static VehicleModel Sabre { get { return new VehicleModel(475); } }
            public static VehicleModel Stallion { get { return new VehicleModel(439); } }
            public static VehicleModel Tampa { get { return new VehicleModel(549); } }
            public static VehicleModel Virgo { get { return new VehicleModel(491); } }
            public static VehicleModel Admiral { get { return new VehicleModel(445); } }
            public static VehicleModel Elegant { get { return new VehicleModel(507); } }
            public static VehicleModel Emperor { get { return new VehicleModel(585); } }
            public static VehicleModel Glendale { get { return new VehicleModel(466); } }
            public static VehicleModel Greenwood { get { return new VehicleModel(492); } }
            public static VehicleModel Intruder { get { return new VehicleModel(546); } }
            public static VehicleModel Merit { get { return new VehicleModel(551); } }
            public static VehicleModel Nebula { get { return new VehicleModel(516); } }
            public static VehicleModel Oceanic { get { return new VehicleModel(467); } }
            public static VehicleModel Premier { get { return new VehicleModel(426); } }
            public static VehicleModel Primo { get { return new VehicleModel(547); } }
            public static VehicleModel Sentinel { get { return new VehicleModel(405); } }
            public static VehicleModel Stafford { get { return new VehicleModel(580); } }
            public static VehicleModel Stretch { get { return new VehicleModel(409); } }
            public static VehicleModel Sunrise { get { return new VehicleModel(550); } }
            public static VehicleModel Tahoma { get { return new VehicleModel(566); } }
            public static VehicleModel Vincent { get { return new VehicleModel(540); } }
            public static VehicleModel Washington { get { return new VehicleModel(421); } }
            public static VehicleModel Willard { get { return new VehicleModel(529); } }
            public static VehicleModel Ambulance { get { return new VehicleModel(416); } }
            public static VehicleModel Barracks { get { return new VehicleModel(433); } }
            public static VehicleModel Enforcer { get { return new VehicleModel(427); } }
            public static VehicleModel Fbirancher { get { return new VehicleModel(490); } }
            public static VehicleModel Fbitruck { get { return new VehicleModel(528); } }
            public static VehicleModel Firetruckladder { get { return new VehicleModel(544); } }
            public static VehicleModel Policecarls { get { return new VehicleModel(596); } }
            public static VehicleModel Policecarlv { get { return new VehicleModel(598); } }
            public static VehicleModel Policecarsf { get { return new VehicleModel(597); } }
            public static VehicleModel Policeranger { get { return new VehicleModel(599); } }
            public static VehicleModel Cementtruck { get { return new VehicleModel(524); } }
            public static VehicleModel Dft30 { get { return new VehicleModel(578); } }
            public static VehicleModel Dozer { get { return new VehicleModel(486); } }
            public static VehicleModel Dumper { get { return new VehicleModel(406); } }
            public static VehicleModel Dune { get { return new VehicleModel(573); } }
            public static VehicleModel Flatbed { get { return new VehicleModel(455); } }
            public static VehicleModel Forklift { get { return new VehicleModel(530); } }
            public static VehicleModel Linerunner { get { return new VehicleModel(403); } }
            public static VehicleModel Packer { get { return new VehicleModel(443); } }
            public static VehicleModel Roadtrain { get { return new VehicleModel(515); } }
            public static VehicleModel Sweeper { get { return new VehicleModel(574); } }
            public static VehicleModel Tanker { get { return new VehicleModel(514); } }
            public static VehicleModel Towtruck { get { return new VehicleModel(525); } }
            public static VehicleModel Trashmaster { get { return new VehicleModel(408); } }
            public static VehicleModel Utilityvan { get { return new VehicleModel(552); } }
            public static VehicleModel Benson { get { return new VehicleModel(499); } }
            public static VehicleModel Blackboxville { get { return new VehicleModel(609); } }
            public static VehicleModel Bobcat { get { return new VehicleModel(422); } }
            public static VehicleModel Boxville { get { return new VehicleModel(498); } }
            public static VehicleModel Mule { get { return new VehicleModel(414); } }
            public static VehicleModel Picador { get { return new VehicleModel(600); } }
            public static VehicleModel Sadler { get { return new VehicleModel(543); } }
            public static VehicleModel Securicar { get { return new VehicleModel(428); } }
            public static VehicleModel Walton { get { return new VehicleModel(478); } }
            public static VehicleModel Yankee { get { return new VehicleModel(456); } }
            public static VehicleModel Yosemite { get { return new VehicleModel(554); } }
            public static VehicleModel Berkleysrcvan { get { return new VehicleModel(459); } }
            public static VehicleModel Burrito { get { return new VehicleModel(482); } }
            public static VehicleModel Camper { get { return new VehicleModel(483); } }
            public static VehicleModel Journey { get { return new VehicleModel(508); } }
            public static VehicleModel Moonbeam { get { return new VehicleModel(418); } }
            public static VehicleModel Newsvan { get { return new VehicleModel(582); } }
            public static VehicleModel Pony { get { return new VehicleModel(413); } }
            public static VehicleModel Rumpo { get { return new VehicleModel(440); } }
            public static VehicleModel Baggage { get { return new VehicleModel(485); } }
            public static VehicleModel Bandito { get { return new VehicleModel(568); } }
            public static VehicleModel Bfinjection { get { return new VehicleModel(424); } }
            public static VehicleModel Bloodringbanger { get { return new VehicleModel(504); } }
            public static VehicleModel Bus { get { return new VehicleModel(431); } }
            public static VehicleModel Caddy { get { return new VehicleModel(457); } }
            public static VehicleModel Coach { get { return new VehicleModel(437); } }
            public static VehicleModel Combineharvester { get { return new VehicleModel(532); } }
            public static VehicleModel Hotdog { get { return new VehicleModel(588); } }
            public static VehicleModel Hotknife { get { return new VehicleModel(434); } }
            public static VehicleModel Hotringracer1 { get { return new VehicleModel(494); } }
            public static VehicleModel Hotringracer2 { get { return new VehicleModel(502); } }
            public static VehicleModel Hotringracer3 { get { return new VehicleModel(503); } }
            public static VehicleModel Monster1 { get { return new VehicleModel(444); } }
            public static VehicleModel Monster2 { get { return new VehicleModel(556); } }
            public static VehicleModel Monster3 { get { return new VehicleModel(557); } }
            public static VehicleModel Mower { get { return new VehicleModel(572); } }
            public static VehicleModel Mrwhoopee { get { return new VehicleModel(423); } }
            public static VehicleModel Kart { get { return new VehicleModel(571); } }
            public static VehicleModel Tractor { get { return new VehicleModel(531); } }
            public static VehicleModel Tug { get { return new VehicleModel(583); } }
            public static VehicleModel Vortex { get { return new VehicleModel(539); } }
            public static VehicleModel RcBandit { get { return new VehicleModel(441); } }
            public static VehicleModel RcFlowerpot { get { return new VehicleModel(594); } }
            public static VehicleModel RcTiger { get { return new VehicleModel(564); } }
            public static VehicleModel Club { get { return new VehicleModel(589); } }
            public static VehicleModel Huntley { get { return new VehicleModel(579); } }
            public static VehicleModel Landstalker { get { return new VehicleModel(400); } }
            public static VehicleModel Mesa { get { return new VehicleModel(500); } }
            public static VehicleModel Patriot { get { return new VehicleModel(470); } }
            public static VehicleModel Perennial { get { return new VehicleModel(404); } }
            public static VehicleModel Rancher { get { return new VehicleModel(489); } }
            public static VehicleModel Regina { get { return new VehicleModel(479); } }
            public static VehicleModel Romero { get { return new VehicleModel(442); } }
            public static VehicleModel Sandking { get { return new VehicleModel(495); } }
            public static VehicleModel Solair { get { return new VehicleModel(458); } }
            public static VehicleModel Stratum { get { return new VehicleModel(561); } }
            public static VehicleModel Cabbie { get { return new VehicleModel(438); } }
            public static VehicleModel Taxi { get { return new VehicleModel(420); } }
        }

        public static class Boat
        {
            public static VehicleModel Coastguard { get { return new VehicleModel(472); } }
            public static VehicleModel Dinghy { get { return new VehicleModel(473); } }
            public static VehicleModel Jetmax { get { return new VehicleModel(493); } }
            public static VehicleModel Launch { get { return new VehicleModel(595); } }
            public static VehicleModel Marquis { get { return new VehicleModel(484); } }
            public static VehicleModel Predator { get { return new VehicleModel(430); } }
            public static VehicleModel Reefer { get { return new VehicleModel(453); } }
            public static VehicleModel Speeder { get { return new VehicleModel(452); } }
            public static VehicleModel Squalo { get { return new VehicleModel(446); } }
            public static VehicleModel Tropic { get { return new VehicleModel(454); } }
        }

        public static class Plane
        {
            public static VehicleModel Andromada { get { return new VehicleModel(592); } }
            public static VehicleModel At400 { get { return new VehicleModel(577); } }
            public static VehicleModel Beagle { get { return new VehicleModel(511); } }
            public static VehicleModel Cropduster { get { return new VehicleModel(512); } }
            public static VehicleModel Dodo { get { return new VehicleModel(593); } }
            public static VehicleModel Hydra { get { return new VehicleModel(520); } }
            public static VehicleModel Nevada { get { return new VehicleModel(553); } }
            public static VehicleModel Rustler { get { return new VehicleModel(476); } }
            public static VehicleModel Shamal { get { return new VehicleModel(519); } }
            public static VehicleModel Skimmer { get { return new VehicleModel(460); } }
            public static VehicleModel Stuntplane { get { return new VehicleModel(513); } }
            public static VehicleModel RcBaron { get { return new VehicleModel(464); } }
        }

        public static class Helicopter
        {
            public static VehicleModel Cargobob { get { return new VehicleModel(548); } }
            public static VehicleModel Hunter { get { return new VehicleModel(425); } }
            public static VehicleModel Leviathan { get { return new VehicleModel(417); } }
            public static VehicleModel Maverick { get { return new VehicleModel(487); } }
            public static VehicleModel Newschopper { get { return new VehicleModel(488); } }
            public static VehicleModel PoliceMaverick { get { return new VehicleModel(497); } }
            public static VehicleModel Raindance { get { return new VehicleModel(563); } }
            public static VehicleModel Seasparrow { get { return new VehicleModel(447); } }
            public static VehicleModel Sparrow { get { return new VehicleModel(469); } }
            public static VehicleModel RcGoblin { get { return new VehicleModel(501); } }
            public static VehicleModel RcRaider { get { return new VehicleModel(465); } }
        }

        public static class Trailer
        {
            public static VehicleModel BaggageCovered { get { return new VehicleModel(606); } }
            public static VehicleModel BaggageUncovered { get { return new VehicleModel(607); } }
            public static VehicleModel Steps { get { return new VehicleModel(608); } }
            public static VehicleModel Farmtrailer { get { return new VehicleModel(610); } }
            public static VehicleModel Streetcleaner { get { return new VehicleModel(611); } }
            public static VehicleModel GasSemi { get { return new VehicleModel(584); } }
            public static VehicleModel Semi { get { return new VehicleModel(435); } }
            public static VehicleModel OpenSemi { get { return new VehicleModel(450); } }
            public static VehicleModel SmallSemi { get { return new VehicleModel(591); } }
        }

        public static class Train
        {
            public static VehicleModel FreightEngine { get { return new VehicleModel(537); } }
            public static VehicleModel BoxFreight { get { return new VehicleModel(590); } }
            public static VehicleModel FlatFreight { get { return new VehicleModel(569); } }
            public static VehicleModel BrownStreakEngine { get { return new VehicleModel(538); } }
            public static VehicleModel BrownStreakCarriage { get { return new VehicleModel(570); } }
            public static VehicleModel Trolly { get { return new VehicleModel(449); } }
        }

        public static class Turreted
        {
            public static VehicleModel Rhino { get { return new VehicleModel(432); } }
            public static VehicleModel Swat { get { return new VehicleModel(601); } }
            public static VehicleModel Firetruck { get { return new VehicleModel(407); } }
        }

        protected VehicleModel(int id) : base(id) { }
    }
}
