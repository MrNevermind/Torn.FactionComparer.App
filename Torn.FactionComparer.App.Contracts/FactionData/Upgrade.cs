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

using Newtonsoft.Json;
using Torn.FactionComparer.App.Contracts.CommonData;

namespace Torn.FactionComparer.App.Contracts.FactionData
{
    public class Upgrade : IntApiListItem
    {
        [JsonProperty("branch")] public string Branch { get; set; }

        [JsonProperty("branchorder")] public int BranchOrder { get; set; }

        [JsonProperty("branchmultiplier")] public int BranchMultiplier { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("level")] public int Level { get; set; }

        [JsonProperty("basecost")] public int BaseCost { get; set; }

        [JsonProperty("ability")] public string Ability { get; set; }

        [JsonProperty("unlocked")] public string Unlocked { get; set; }
    }
}