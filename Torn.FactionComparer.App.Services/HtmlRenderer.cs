using System;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace Torn.FactionComparer.App.Services
{
    public interface IHtmlRenderer
    {
        Task<string> GetHtml(FactionCompareImageData data);
    }

    public class HtmlRenderer : IHtmlRenderer
    {
        private const string RED = "#e67c73";
        private const string GREEN = "#58bb8a";

        public async Task<string> GetHtml(FactionCompareImageData data)
        {
            var htmlPath = Path.Combine(Directory.GetCurrentDirectory(), "FactionStats.html");
            var htmlContent = await File.ReadAllTextAsync(htmlPath);

            htmlContent = htmlContent.Replace("[FirstFaction.Color]", data.Stats.Weight.First > data.Stats.Weight.Seccond ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.Color]", data.Stats.Weight.Seccond > data.Stats.Weight.First ? GREEN : RED);

            htmlContent = htmlContent.Replace("[FirstFaction.Name]", data.FirstFaction.Name);
            htmlContent = htmlContent.Replace("[SeccondFaction.Name]", data.SeccondFaction.Name);

            htmlContent = htmlContent.Replace("[FirstFaction.Respect]", data.FirstFaction.Respect.ToString());
            htmlContent = htmlContent.Replace("[Respect.First.Width]", data.Stats.Respect.First.ToString());
            htmlContent = htmlContent.Replace("[Respect.First.Color]", data.Stats.Respect.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[Respect.Seccond.Width]", data.Stats.Respect.Seccond.ToString());
            htmlContent = htmlContent.Replace("[Respect.Seccond.Color]", data.Stats.Respect.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.Respect]", data.SeccondFaction.Respect.ToString());

            htmlContent = htmlContent.Replace("[FirstFaction.BestChain]", data.FirstFaction.BestChain.ToString());
            htmlContent = htmlContent.Replace("[BestChain.First.Width]", data.Stats.BestChain.First.ToString());
            htmlContent = htmlContent.Replace("[BestChain.First.Color]", data.Stats.BestChain.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[BestChain.Seccond.Width]", data.Stats.BestChain.Seccond.ToString());
            htmlContent = htmlContent.Replace("[BestChain.Seccond.Color]", data.Stats.BestChain.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.BestChain]", data.SeccondFaction.BestChain.ToString());

            htmlContent = htmlContent.Replace("[FirstFaction.Members]", data.FirstFaction.Members.ToString());
            htmlContent = htmlContent.Replace("[Members.First.Width]", data.Stats.Members.First.ToString());
            htmlContent = htmlContent.Replace("[Members.First.Color]", data.Stats.Members.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[Members.Seccond.Width]", data.Stats.Members.Seccond.ToString());
            htmlContent = htmlContent.Replace("[Members.Seccond.Color]", data.Stats.Members.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.Members]", data.SeccondFaction.Members.ToString());

            htmlContent = htmlContent.Replace("[FirstFaction.AverageAge]", Math.Round(data.FirstFaction.AverageAge, 2).ToString());
            htmlContent = htmlContent.Replace("[AverageAge.First.Width]", data.Stats.AverageAge.First.ToString());
            htmlContent = htmlContent.Replace("[AverageAge.First.Color]", data.Stats.AverageAge.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[AverageAge.Seccond.Width]", data.Stats.AverageAge.Seccond.ToString());
            htmlContent = htmlContent.Replace("[AverageAge.Seccond.Color]", data.Stats.AverageAge.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.AverageAge]", Math.Round(data.SeccondFaction.AverageAge, 2).ToString());

            htmlContent = htmlContent.Replace("[FirstFaction.AverageLevel]", Math.Round(data.FirstFaction.AverageLevel, 2).ToString());
            htmlContent = htmlContent.Replace("[AverageLevel.First.Width]", data.Stats.AverageLevel.First.ToString());
            htmlContent = htmlContent.Replace("[AverageLevel.First.Color]", data.Stats.AverageLevel.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[AverageLevel.Seccond.Width]", data.Stats.AverageLevel.Seccond.ToString());
            htmlContent = htmlContent.Replace("[AverageLevel.Seccond.Color]", data.Stats.AverageLevel.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.AverageLevel]", Math.Round(data.SeccondFaction.AverageLevel, 2).ToString());

            htmlContent = htmlContent.Replace("[FirstFaction.AverageActivity]", string.Format("{0:D2}:{1:D2}", TimeSpan.FromSeconds(data.FirstFaction.AverageActivity).Hours, TimeSpan.FromSeconds(data.FirstFaction.AverageActivity).Minutes));
            htmlContent = htmlContent.Replace("[AverageActivity.First.Width]", data.Stats.AverageActivity.First.ToString());
            htmlContent = htmlContent.Replace("[AverageActivity.First.Color]", data.Stats.AverageActivity.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[AverageActivity.Seccond.Width]", data.Stats.AverageActivity.Seccond.ToString());
            htmlContent = htmlContent.Replace("[AverageActivity.Seccond.Color]", data.Stats.AverageActivity.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.AverageActivity]", string.Format("{0:D2}:{1:D2}", TimeSpan.FromSeconds(data.SeccondFaction.AverageActivity).Hours, TimeSpan.FromSeconds(data.SeccondFaction.AverageActivity).Minutes));

            htmlContent = htmlContent.Replace("[FirstFaction.AverageActivityPerDay]", string.Format("{0:D2}:{1:D2}", TimeSpan.FromSeconds(data.FirstFaction.AverageActivityPerDay).Hours, TimeSpan.FromSeconds(data.FirstFaction.AverageActivityPerDay).Minutes));
            htmlContent = htmlContent.Replace("[AverageActivityPerDay.First.Width]", data.Stats.AverageActivityPerDay.First.ToString());
            htmlContent = htmlContent.Replace("[AverageActivityPerDay.First.Color]", data.Stats.AverageActivityPerDay.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[AverageActivityPerDay.Seccond.Width]", data.Stats.AverageActivityPerDay.Seccond.ToString());
            htmlContent = htmlContent.Replace("[AverageActivityPerDay.Seccond.Color]", data.Stats.AverageActivityPerDay.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.AverageActivityPerDay]", string.Format("{0:D2}:{1:D2}", TimeSpan.FromSeconds(data.SeccondFaction.AverageActivityPerDay).Hours, TimeSpan.FromSeconds(data.SeccondFaction.AverageActivityPerDay).Minutes));

            htmlContent = htmlContent.Replace("[FirstFaction.AverageAwards]", Math.Round(data.FirstFaction.AverageAwards, 2).ToString());
            htmlContent = htmlContent.Replace("[AverageAwards.First.Width]", data.Stats.AverageAwards.First.ToString());
            htmlContent = htmlContent.Replace("[AverageAwards.First.Color]", data.Stats.AverageAwards.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[AverageAwards.Seccond.Width]", data.Stats.AverageAwards.Seccond.ToString());
            htmlContent = htmlContent.Replace("[AverageAwards.Seccond.Color]", data.Stats.AverageAwards.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.AverageAwards]", Math.Round(data.SeccondFaction.AverageAwards, 2).ToString());

            htmlContent = htmlContent.Replace("[FirstFaction.Xanax]", data.FirstFaction.Xanax.ToString());
            htmlContent = htmlContent.Replace("[Xanax.First.Width]", data.Stats.Xanax.First.ToString());
            htmlContent = htmlContent.Replace("[Xanax.First.Color]", data.Stats.Xanax.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[Xanax.Seccond.Width]", data.Stats.Xanax.Seccond.ToString());
            htmlContent = htmlContent.Replace("[Xanax.Seccond.Color]", data.Stats.Xanax.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.Xanax]", data.SeccondFaction.Xanax.ToString());

            htmlContent = htmlContent.Replace("[FirstFaction.LSD]", data.FirstFaction.LSD.ToString());
            htmlContent = htmlContent.Replace("[LSD.First.Width]", data.Stats.LSD.First.ToString());
            htmlContent = htmlContent.Replace("[LSD.First.Color]", data.Stats.LSD.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[LSD.Seccond.Width]", data.Stats.LSD.Seccond.ToString());
            htmlContent = htmlContent.Replace("[LSD.Seccond.Color]", data.Stats.LSD.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.LSD]", data.SeccondFaction.LSD.ToString());

            htmlContent = htmlContent.Replace("[FirstFaction.Vicodin]", data.FirstFaction.Vicodin.ToString());
            htmlContent = htmlContent.Replace("[Vicodin.First.Width]", data.Stats.Vicodin.First.ToString());
            htmlContent = htmlContent.Replace("[Vicodin.First.Color]", data.Stats.Vicodin.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[Vicodin.Seccond.Width]", data.Stats.Vicodin.Seccond.ToString());
            htmlContent = htmlContent.Replace("[Vicodin.Seccond.Color]", data.Stats.Vicodin.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.Vicodin]", data.SeccondFaction.Vicodin.ToString());

            htmlContent = htmlContent.Replace("[FirstFaction.Overdoses]", data.FirstFaction.Overdoses.ToString());
            htmlContent = htmlContent.Replace("[Overdoses.First.Width]", data.Stats.Overdoses.First.ToString());
            htmlContent = htmlContent.Replace("[Overdoses.First.Color]", data.Stats.Overdoses.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[Overdoses.Seccond.Width]", data.Stats.Overdoses.Seccond.ToString());
            htmlContent = htmlContent.Replace("[Overdoses.Seccond.Color]", data.Stats.Overdoses.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.Overdoses]", data.SeccondFaction.Overdoses.ToString());

            htmlContent = htmlContent.Replace("[FirstFaction.EnergyRefils]", data.FirstFaction.EnergyRefils.ToString());
            htmlContent = htmlContent.Replace("[EnergyRefils.First.Width]", data.Stats.EnergyRefils.First.ToString());
            htmlContent = htmlContent.Replace("[EnergyRefils.First.Color]", data.Stats.EnergyRefils.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[EnergyRefils.Seccond.Width]", data.Stats.EnergyRefils.Seccond.ToString());
            htmlContent = htmlContent.Replace("[EnergyRefils.Seccond.Color]", data.Stats.EnergyRefils.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.EnergyRefils]", data.SeccondFaction.EnergyRefils.ToString());

            htmlContent = htmlContent.Replace("[FirstFaction.EnergyDrinks]", data.FirstFaction.EnergyDrinks.ToString());
            htmlContent = htmlContent.Replace("[EnergyDrinks.First.Width]", data.Stats.EnergyDrinks.First.ToString());
            htmlContent = htmlContent.Replace("[EnergyDrinks.First.Color]", data.Stats.EnergyDrinks.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[EnergyDrinks.Seccond.Width]", data.Stats.EnergyDrinks.Seccond.ToString());
            htmlContent = htmlContent.Replace("[EnergyDrinks.Seccond.Color]", data.Stats.EnergyDrinks.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.EnergyDrinks]", data.SeccondFaction.EnergyDrinks.ToString());

            htmlContent = htmlContent.Replace("[FirstFaction.Boosters]", data.FirstFaction.Boosters.ToString());
            htmlContent = htmlContent.Replace("[Boosters.First.Width]", data.Stats.Boosters.First.ToString());
            htmlContent = htmlContent.Replace("[Boosters.First.Color]", data.Stats.Boosters.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[Boosters.Seccond.Width]", data.Stats.Boosters.Seccond.ToString());
            htmlContent = htmlContent.Replace("[Boosters.Seccond.Color]", data.Stats.Boosters.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.Boosters]", data.SeccondFaction.Boosters.ToString());

            htmlContent = htmlContent.Replace("[FirstFaction.StatEnhancers]", data.FirstFaction.StatEnhancers.ToString());
            htmlContent = htmlContent.Replace("[StatEnhancers.First.Width]", data.Stats.StatEnhancers.First.ToString());
            htmlContent = htmlContent.Replace("[StatEnhancers.First.Color]", data.Stats.StatEnhancers.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[StatEnhancers.Seccond.Width]", data.Stats.StatEnhancers.Seccond.ToString());
            htmlContent = htmlContent.Replace("[StatEnhancers.Seccond.Color]", data.Stats.StatEnhancers.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.StatEnhancers]", data.SeccondFaction.StatEnhancers.ToString());

            htmlContent = htmlContent.Replace("[FirstFaction.AttacksMade]", data.FirstFaction.AttacksMade.ToString());
            htmlContent = htmlContent.Replace("[AttacksMade.First.Width]", data.Stats.AttacksMade.First.ToString());
            htmlContent = htmlContent.Replace("[AttacksMade.First.Color]", data.Stats.AttacksMade.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[AttacksMade.Seccond.Width]", data.Stats.AttacksMade.Seccond.ToString());
            htmlContent = htmlContent.Replace("[AttacksMade.Seccond.Color]", data.Stats.AttacksMade.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.AttacksMade]", data.SeccondFaction.AttacksMade.ToString());

            htmlContent = htmlContent.Replace("[FirstFaction.RevivesGiven]", data.FirstFaction.RevivesGiven.ToString());
            htmlContent = htmlContent.Replace("[RevivesGiven.First.Width]", data.Stats.RevivesGiven.First.ToString());
            htmlContent = htmlContent.Replace("[RevivesGiven.First.Color]", data.Stats.RevivesGiven.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[RevivesGiven.Seccond.Width]", data.Stats.RevivesGiven.Seccond.ToString());
            htmlContent = htmlContent.Replace("[RevivesGiven.Seccond.Color]", data.Stats.RevivesGiven.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.RevivesGiven]", data.SeccondFaction.RevivesGiven.ToString());

            htmlContent = htmlContent.Replace("[FirstFaction.RevivesReceived]", data.FirstFaction.RevivesReceived.ToString());
            htmlContent = htmlContent.Replace("[RevivesReceived.First.Width]", data.Stats.RevivesReceived.First.ToString());
            htmlContent = htmlContent.Replace("[RevivesReceived.First.Color]", data.Stats.RevivesReceived.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[RevivesReceived.Seccond.Width]", data.Stats.RevivesReceived.Seccond.ToString());
            htmlContent = htmlContent.Replace("[RevivesReceived.Seccond.Color]", data.Stats.RevivesReceived.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.RevivesReceived]", data.SeccondFaction.RevivesReceived.ToString());

            htmlContent = htmlContent.Replace("[FirstFaction.BountiesPlaced]", data.FirstFaction.BountiesPlaced.ToString());
            htmlContent = htmlContent.Replace("[BountiesPlaced.First.Width]", data.Stats.BountiesPlaced.First.ToString());
            htmlContent = htmlContent.Replace("[BountiesPlaced.First.Color]", data.Stats.BountiesPlaced.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[BountiesPlaced.Seccond.Width]", data.Stats.BountiesPlaced.Seccond.ToString());
            htmlContent = htmlContent.Replace("[BountiesPlaced.Seccond.Color]", data.Stats.BountiesPlaced.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.BountiesPlaced]", data.SeccondFaction.BountiesPlaced.ToString());

            htmlContent = htmlContent.Replace("[FirstFaction.BountiesReceived]", data.FirstFaction.BountiesReceived.ToString());
            htmlContent = htmlContent.Replace("[BountiesReceived.First.Width]", data.Stats.BountiesReceived.First.ToString());
            htmlContent = htmlContent.Replace("[BountiesReceived.First.Color]", data.Stats.BountiesReceived.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[BountiesReceived.Seccond.Width]", data.Stats.BountiesReceived.Seccond.ToString());
            htmlContent = htmlContent.Replace("[BountiesReceived.Seccond.Color]", data.Stats.BountiesReceived.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.BountiesReceived]", data.SeccondFaction.BountiesReceived.ToString());

            htmlContent = htmlContent.Replace("[FirstFaction.MissionCredits]", data.FirstFaction.MissionCredits.ToString());
            htmlContent = htmlContent.Replace("[MissionCredits.First.Width]", data.Stats.MissionCredits.First.ToString());
            htmlContent = htmlContent.Replace("[MissionCredits.First.Color]", data.Stats.MissionCredits.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[MissionCredits.Seccond.Width]", data.Stats.MissionCredits.Seccond.ToString());
            htmlContent = htmlContent.Replace("[MissionCredits.Seccond.Color]", data.Stats.MissionCredits.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.MissionCredits]", data.SeccondFaction.MissionCredits.ToString());

            htmlContent = htmlContent.Replace("[FirstFaction.SpecialAmmo]", data.FirstFaction.SpecialAmmo.ToString());
            htmlContent = htmlContent.Replace("[SpecialAmmo.First.Width]", data.Stats.SpecialAmmo.First.ToString());
            htmlContent = htmlContent.Replace("[SpecialAmmo.First.Color]", data.Stats.SpecialAmmo.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SpecialAmmo.Seccond.Width]", data.Stats.SpecialAmmo.Seccond.ToString());
            htmlContent = htmlContent.Replace("[SpecialAmmo.Seccond.Color]", data.Stats.SpecialAmmo.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.SpecialAmmo]", data.SeccondFaction.SpecialAmmo.ToString());

            htmlContent = htmlContent.Replace("[FirstFaction.JobPoints]", data.FirstFaction.JobPoints.ToString());
            htmlContent = htmlContent.Replace("[JobPoints.First.Width]", data.Stats.JobPoints.First.ToString());
            htmlContent = htmlContent.Replace("[JobPoints.First.Color]", data.Stats.JobPoints.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[JobPoints.Seccond.Width]", data.Stats.JobPoints.Seccond.ToString());
            htmlContent = htmlContent.Replace("[JobPoints.Seccond.Color]", data.Stats.JobPoints.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.JobPoints]", data.SeccondFaction.JobPoints.ToString());

            htmlContent = htmlContent.Replace("[FirstFaction.RespectEarned]", data.FirstFaction.RespectEarned.ToString());
            htmlContent = htmlContent.Replace("[RespectEarned.First.Width]", data.Stats.RespectEarned.First.ToString());
            htmlContent = htmlContent.Replace("[RespectEarned.First.Color]", data.Stats.RespectEarned.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[RespectEarned.Seccond.Width]", data.Stats.RespectEarned.Seccond.ToString());
            htmlContent = htmlContent.Replace("[RespectEarned.Seccond.Color]", data.Stats.RespectEarned.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.RespectEarned]", data.SeccondFaction.RespectEarned.ToString());

            htmlContent = htmlContent.Replace("[FirstFaction.Networth]", string.Format(new CultureInfo("en-US", false).NumberFormat, "{0:C}", data.FirstFaction.Networth));
            htmlContent = htmlContent.Replace("[Networth.First.Width]", data.Stats.Networth.First.ToString());
            htmlContent = htmlContent.Replace("[Networth.First.Color]", data.Stats.Networth.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[Networth.Seccond.Width]", data.Stats.Networth.Seccond.ToString());
            htmlContent = htmlContent.Replace("[Networth.Seccond.Color]", data.Stats.Networth.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.Networth]", string.Format(new CultureInfo("en-US", false).NumberFormat, "{0:C}", data.SeccondFaction.Networth));

            htmlContent = htmlContent.Replace("[FirstFaction.Karma]", data.FirstFaction.Karma.ToString());
            htmlContent = htmlContent.Replace("[Karma.First.Width]", data.Stats.Karma.First.ToString());
            htmlContent = htmlContent.Replace("[Karma.First.Color]", data.Stats.Karma.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[Karma.Seccond.Width]", data.Stats.Karma.Seccond.ToString());
            htmlContent = htmlContent.Replace("[Karma.Seccond.Color]", data.Stats.Karma.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.Karma]", data.SeccondFaction.Karma.ToString());

            htmlContent = htmlContent.Replace("[FirstFaction.BooksRead]", data.FirstFaction.BooksRead.ToString());
            htmlContent = htmlContent.Replace("[BooksRead.First.Width]", data.Stats.BooksRead.First.ToString());
            htmlContent = htmlContent.Replace("[BooksRead.First.Color]", data.Stats.BooksRead.First == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[BooksRead.Seccond.Width]", data.Stats.BooksRead.Seccond.ToString());
            htmlContent = htmlContent.Replace("[BooksRead.Seccond.Color]", data.Stats.BooksRead.Seccond == 100 ? GREEN : RED);
            htmlContent = htmlContent.Replace("[SeccondFaction.BooksRead]", data.SeccondFaction.BooksRead.ToString());

            return htmlContent;
        }
    }
}
