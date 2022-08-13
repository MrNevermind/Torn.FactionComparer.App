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

namespace Torn.FactionComparer.App.Contracts.CommonData
{
    public class Attack : IntApiListItem
    {
        [JsonProperty("code")] public string Code { get; set; }

        [JsonProperty("timestamp_started")] public int TimestampStarted { get; set; }

        [JsonProperty("timestamp_ended")] public int TimestampEnded { get; set; }

        [JsonProperty("attacker_id")] public string AttackerId { get; set; }

        [JsonProperty("attacker_faction")] public string AttackerFactionId { get; set; }

        [JsonProperty("defender_id")] public int DefenderId { get; set; }

        [JsonProperty("defender_faction")] public int DefenderFactionId { get; set; }

        [JsonProperty("result")] public string Result { get; set; }

        [JsonProperty("stealthed")] public bool Stealthed { get; set; }

        [JsonProperty("respect")] public float RespectGain { get; set; }
    }

    public class AttackDetailed : Attack
    {
        [JsonProperty("attacker_name")] public string AttackerName { get; set; }

        [JsonProperty("attacker_factionname")] public string AttackerFactionName { get; set; }

        [JsonProperty("defender_name")] public string DefenderName { get; set; }

        [JsonProperty("defender_factionname")] public string DefenderFactionName { get; set; }

        [JsonProperty("chain")] public int Chain { get; set; }

        [JsonProperty("raid")] public bool Raid { get; set; }

        [JsonProperty("respect_gain")] public new float RespectGain { get; set; }

        [JsonProperty("respect_loss")] public float RespectLoss { get; set; }

        [JsonProperty("modifiers")] public AttackModifiers Modifiers { get; set; }
    }

    public class AttackModifiers
    {
        [JsonProperty("fair_fight")] public float FairFight { get; set; }

        [JsonProperty("war")] public float War { get; set; }

        [JsonProperty("retaliation")] public float Retaliation { get; set; }

        [JsonProperty("group_attack")] public float GroupAttack { get; set; }

        [JsonProperty("overseas")] public float Overseas { get; set; }

        [JsonProperty("chain_bonus")] public float ChainBonus { get; set; }
    }
}