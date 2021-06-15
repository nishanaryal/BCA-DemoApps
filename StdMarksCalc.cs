using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppCA
{
    public class StdMarksCalc
    {
        int AllSubTotal = 300;
        public double CalculatePercentage(double DotNetTech, double MIS, double CN)
        {
            double MarksObtained = DotNetTech + MIS + CN;
            double Percentage = (MarksObtained / AllSubTotal) * 100;
            return Percentage;
        }




        /*public Caculatepercentage(dobule par1, par2, par3){
         * 
         *  double MarksObtained = DotNetTech + MIS + CN;
         *  Percentage = (MarksObtained / AllSubTotal) * 100;
         *  return Percentage;
    
         *Statement to calculate Percentage
        } */
    }
}
