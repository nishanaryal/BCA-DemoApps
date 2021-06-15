using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppCA
{
    public class ResultCalculator
    {
        private double total, percentage;
        string division;

        public string CalculatePercentage(double DotNetTech, double MIS, double CN)
        {
            string[] subjectsName = new string[] {
                "Dot Net Technology", "MIS Application", "Computer Network"
            };

            double[] subjects = new double[] {
                DotNetTech, MIS, CN
            };
            //Check and convert if all are in Float or Int

            //float sub1 = Convert.ToInt32(DotNetTech);

            //Use of Switch to calculate Percentage
            total = DotNetTech + MIS + CN;
            percentage = total / 3.0;
            if (percentage >= 60)
                division = "First";
            else
            if (percentage < 60 && percentage >= 48)
                division = "Second";
            else
                if (percentage < 48 && percentage >= 36)
                division = "Pass";
            else
                division = "Fail";

            var report = new System.Text.StringBuilder();

            report.AppendLine("DOT Net Tecnology\t\tMIS\tComputer Network");
            foreach (var item in subjects)
            {
                report.AppendLine($"{DotNetTech}\t{MIS}\t{CN}\t");
            }
            report.AppendLine($"Percentage = {percentage}");
            report.AppendLine($"Division = {division}");


            return report.ToString();
        }
    }
}
