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

namespace Torn.FactionComparer.App.Contracts.UserData
{
    public class HallOfFameEntry
    {
        [JsonProperty("value")] public long Value { get; set; }

        [JsonProperty("rank")] public int Rank { get; set; }
    }

    public class HallOfFame
    {
        [JsonProperty("attacks")] public HallOfFameEntry Attacks { get; set; }

        [JsonProperty("battlestats")] public HallOfFameEntry BattleStats { get; set; }

        [JsonProperty("busts")] public HallOfFameEntry Busts { get; set; }

        [JsonProperty("defends")] public HallOfFameEntry Defends { get; set; }

        [JsonProperty("networth")] public HallOfFameEntry Networth { get; set; }

        [JsonProperty("offences")] public HallOfFameEntry Offences { get; set; }

        [JsonProperty("revives")] public HallOfFameEntry Revives { get; set; }

        [JsonProperty("traveled")] public HallOfFameEntry Traveled { get; set; }

        [JsonProperty("workstats")] public HallOfFameEntry WorkStats { get; set; }

        [JsonProperty("level")] public HallOfFameEntry Level { get; set; }

        [JsonProperty("rank")] public HallOfFameEntry Rank { get; set; }

        [JsonProperty("respect")] public HallOfFameEntry Respect { get; set; }
    }
}