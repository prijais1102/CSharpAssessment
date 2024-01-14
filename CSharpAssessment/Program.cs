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
            try
            {
               
                bool condition = true;
                bool condition1 = true;
                while (condition)
                {
                    Console.WriteLine("1.Add OnContract Developer\n2.Add OnPayRoll Developer\n3.More options.");
                    Console.WriteLine("Enter choice");
                    int employeeType = int.Parse(Console.ReadLine());
                    Developer developer = null;
                    switch (employeeType)
                    {
                        case (byte)EmployeeType.OnContract:
                           
                            developer = new OnContract();
                            developer.GetDetails();
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
                            condition1= true;
                            while (condition1)
                            {
                                Console.WriteLine("1.Display all records.");
                                Console.WriteLine("2.Display records where NetSalary is more than 20k.");
                                Console.WriteLine("3.Display records where developer name contains 'D'");
                                Console.WriteLine("4.Display records where joining date is b/w 01/01/2020 and 01/01/2022");
                                Console.WriteLine("5.Display records where joining date is 12 Jan 2022");
                                Console.WriteLine("6.End");
                                Console.WriteLine("Enter Choice");
                                int ch = int.Parse(Console.ReadLine());
                                switch (ch)
                                {
                                    case 1: break;
                                    case 2: break;
                                    case 3: break;
                                    case 4: break;
                                    case 5: break;
                                    case 6: condition1 = false;
                                        condition = false;
                                        break;



                                }
                            }
                            
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
