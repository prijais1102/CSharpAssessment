using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment
{
    internal class Program
    {
        
        enum EmployeeType {OnContract=1, OnPayRoll=2 , Record=3};
        static void Main(string[] args)
        {
            bool condition = true;
            bool condition1 = true;

            try
            {
                while (condition)
                {
                    List<Developer> list = new List<Developer>();
                    Developer a;
                    Console.WriteLine("1.Add OnContract Developer\n2.Add OnPayRoll Developer\n3.End.");
                    Console.WriteLine("Enter choice");
                    int employeeType = int.Parse(Console.ReadLine());
                    Developer developer = null;
                    switch (employeeType)
                    {
                        case (byte)EmployeeType.OnContract:
                           
                            developer = new OnContract();
                            developer.GetDetails();
                            list.Add(developer);
                            condition1 = true;
                            while (condition1)
                            {
                                Console.WriteLine("Do you want to add more on-contract developers(y/n) ?");
                                char ch = char.Parse(Console.ReadLine());
                                switch (ch)
                                {
                                    case 'y':
                                        developer.GetDetails();
                                        break;
                                    case 'n':
                                        developer.DisplayDetails();
                                        condition1 = false;
                                        break;
                                }
                            }
                            break;
                        case (byte)EmployeeType.OnPayRoll:
                            developer = new OnPayroll();
                            developer.GetDetails();
                            list.Add(developer);
                            condition1 = true;
                            while (condition1)
                            {
                                Console.WriteLine("Do you want to add more on-payRoll developers(y/n) ?");
                                char ch = char.Parse(Console.ReadLine());
                                switch (ch)
                                {
                                    case 'y':
                                        developer.GetDetails();
                                        break;
                                    case 'n':
                                        developer.DisplayDetails();
                                        condition1 = false;
                                        break;
                                }
                            }
                            break;
                        case (byte)EmployeeType.Record:

                            List<OnContract> listb = list.OfType<OnContract>().ToList();
                            List<OnPayroll> listc = list.OfType<OnPayroll>().ToList();
                            foreach(var item in listb)
                            {
                                Console.WriteLine(item);
                            }
                            foreach (var item in listc)
                            {
                                Console.WriteLine(item);
                            }
                            condition = false;
                            break;


                    }//switch
                }//while
               

            }//try
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }//catch

        }//main

    }//class
}//namespace
