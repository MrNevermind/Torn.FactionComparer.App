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

using System.Collections.Generic;
using Newtonsoft.Json;
using Torn.FactionComparer.App.Contracts.CommonData;

namespace Torn.FactionComparer.App.Contracts.ItemData
{
    /// <summary>
    ///     A root level object to hold all the object values returned by the api
    /// </summary>
    public class ItemMarketPropertyBag : PropertyBagBase
    {
        /// <summary>
        ///     A list of points for sale on the market
        /// </summary>
        [JsonProperty("pointsmarket")]
        [JsonConverter(typeof(TornListConverter<PointsListing>))]
        public List<PointsListing> PointsMarket { get; private set; }

        /// <summary>
        ///     A list of the item for sale in bazaars
        /// </summary>
        [JsonProperty("bazaar")]
        public List<MarketListing> Bazaars { get; private set; }

        /// <summary>
        ///     A list of the item for sale on the item market
        /// </summary>
        [JsonProperty("itemmarket")]
        public List<MarketListing> ItemMarket { get; private set; }
    }
}