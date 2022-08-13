/***********************************************************************
  This project provides a C# interface to the Torn.com API.
  Copyright (C) 2020  TornCityPro
  
  This program is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  (at your option) any later version.
  
  This program is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.
  
  You should have received a copy of the GNU General Public License
  along with this program.  If not, see <http://www.gnu.org/licenses/>.
************************************************************************/

namespace Torn.FactionComparer.App.Contracts.Fields
{
    public class TornField : ApiField
    {
        public static readonly TornField BankRates = new TornField("bank");
        public static readonly TornField Items = new TornField("items");
        public static readonly TornField Competition = new TornField("competition");
        public static readonly TornField Medals = new TornField("medals");
        public static readonly TornField Honors = new TornField("honors");
        public static readonly TornField OrganisedCrimes = new TornField("organisedcrimes");
        public static readonly TornField Gyms = new TornField("gyms");
        public static readonly TornField Companies = new TornField("companies");
        public static readonly TornField Properties = new TornField("properties");
        public static readonly TornField Education = new TornField("education");
        public static readonly TornField Stats = new TornField("stats ");
        public static readonly TornField Stocks = new TornField("stocks");
        public static readonly TornField FactionTree = new TornField("factiontree");
        public static readonly TornField PawnShop = new TornField("pawnshop");
        public static readonly TornField Raids = new TornField("raids");
        public static readonly TornField Rackets = new TornField("rackets");
        public static readonly TornField TerritoryWars = new TornField("territorywars");
        public static readonly TornField Lookup = new TornField("lookup");
        public static readonly TornField Timestamp = new TornField("timestamp");

        protected TornField(string fieldName) : base(fieldName)
        {
        }
    }
}