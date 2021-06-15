using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppCA
{
    class BasicDemo
    {
        static void Main(string[] args)
        {
            int rollNo;
            double DotNetTech, MIS, CN, total;
            double per;
            double Percentage;
            int AllSubTotal = 300;
            string StudentName, div;

            Console.Write("\n\n");
            Console.Write("Calculate the total, percentage and division to take marks of three subjects:\n");
            Console.Write("-------------------------------------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Input the Roll Number of the student :");
            rollNo = Convert.ToInt32(Console.ReadLine());

            //String Manupulation
            //string rollNoToUpperCase = rollNo.ToUpper().ToString();

            Console.Write("Input the Name of the Student :");
            StudentName = Console.ReadLine().ToUpper().ToString();

            //Get Inut from User : Subject 1
            Console.Write("Input  the marks of .NET Technology : ");
            DotNetTech = Convert.ToInt32(Console.ReadLine());

            //Get Inut from User : Subject 2
            Console.Write("Input  the marks of  MIS Applications : ");
            MIS = Convert.ToInt32(Console.ReadLine());

            //Get Inut from User : Subject 3
            Console.Write("Input  the marks of Computer Network : ");
            CN = Convert.ToInt32(Console.ReadLine());

            /*Declaration and Value Assignment 
            together to save time and if that 
            assigned variable is not used in the entire application */
            double MarksObtained = DotNetTech + MIS + CN;

            //int MarksObtainedByStd = Convert.ToInt32(DotNetTech) + Convert.ToInt32(MIS) + Convert.ToInt32(CN);
            //int MarksObtainedByStd1 = Convert.ToInt32(DotNetTech + MIS + CN);

            //Calculate Percentage
            //Percentage = (MarksObtained/TotalMarks)*100

            Percentage = (MarksObtained / AllSubTotal) * 100;


            //Create Obj of class StdMarksCalc
            //Generic Syntax to create Instance(Object) of a class
            //ClasName className = new ClassName();

            StdMarksCalc stdMarksCalc = new StdMarksCalc();

            double PercentageCalculatefromCustomFuntion = stdMarksCalc.CalculatePercentage(DotNetTech, MIS, CN);

            Console.WriteLine("Percentage calculate using Custom Class and Method is " + PercentageCalculatefromCustomFuntion);
            Console.WriteLine("Percentage calculate using Custom Statement inside Main Method " + Percentage);
            Console.WriteLine("Percentage Obtained by: {0}, RollNo : {1} is {2}%", StudentName, rollNo, Percentage);
            Console.ReadKey(true);




            //Percentage = (Sub1 + Sub2 + Sub3)/Total )*100%
            //Calculate
            ResultCalculator result = new ResultCalculator();
            var printResult = result.CalculatePercentage(DotNetTech, MIS, CN);

            Console.WriteLine(printResult);

            Console.ReadKey(true);


            total = DotNetTech + MIS + CN;
            per = total / 3.0;
            if (per >= 60)
                div = "First";
            else
            if (per < 60 && per >= 48)
                div = "Second";
            else
                if (per < 48 && per >= 36)
                div = "Pass";
            else
                div = "Fail";

            Console.Write("\nRoll No : {0}\nName of Student : {1}\n", rollNo, StudentName);
            Console.Write("Marks in .NET Technology : {0}\nMarks in MIS Applications : {1}\nMarks in Computer Network : {2}\n", DotNetTech, MIS, CN);
            Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n", total, per, div);
        }
    }
}
