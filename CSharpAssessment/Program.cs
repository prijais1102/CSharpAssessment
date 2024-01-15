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
               List<Developer> list = new List<Developer>();    
                bool condition = true;
                bool condition1 = true;
                while (condition)
                {
                    Console.WriteLine("1.Add OnContract Developer\n2.Add OnPayRoll Developer\n3.More options.");
                    Console.WriteLine("Enter choice");
                    byte employeeType = byte.Parse(Console.ReadLine());
                    //Developer developer = null;
                    switch (employeeType)
                    {
                        case (byte)EmployeeType.OnContract:
                            OnContract onContract = null;
                            //developer = new OnContract();
                            //developer.GetDetails();
                            onContract= new OnContract();
                            onContract.GetDetails();
                            list.Add(onContract);
                            condition1 = true;
                            while (condition1)
                            {
                                Console.WriteLine("Do you want to add more on-contract developers(y/n) ?");
                                char ch = char.Parse(Console.ReadLine());
                                switch (ch)
                                {
                                    case 'y':
                                        onContract = new OnContract();
                                        onContract.GetDetails();
                                        list.Add(onContract);

                                        break;
                                    case 'n':
                                        condition1 = false;
                                        break;
                                }
                            }
                            break;
                        case (byte)EmployeeType.OnPayRoll:
                            //developer = new OnPayroll();
                            //developer.GetDetails();
                            OnPayroll onPayroll = null;
                            onPayroll = new OnPayroll();
                            onPayroll.GetDetails();
                            list.Add(onPayroll);
                            condition1 = true;
                            while (condition1)
                            {
                                Console.WriteLine("Do you want to add more on-payRoll developers(y/n) ?");
                                char ch = char.Parse(Console.ReadLine());
                                switch (ch)
                                {
                                    case 'y':
                                        onPayroll = new OnPayroll();
                                        onPayroll.GetDetails();
                                        list.Add(onPayroll);

                                        break;
                                    case 'n':
                                        condition1 = false;
                                        break;
                                }
                            }
                            break;
                        case (byte)EmployeeType.Record:
                            condition1= true;
                            List<OnContract> onContractList = list.OfType<OnContract>().ToList();
                            List<OnPayroll> onPayrollList = list.OfType<OnPayroll>().ToList();
                            while (condition1)
                            {
                                Console.WriteLine("1.Display all records.");
                                Console.WriteLine("2.Display records where NetSalary is more than 20k.");
                                Console.WriteLine("3.Display records where developer name contains 'D'");
                                Console.WriteLine("4.Display records where joining date is b/w 01/01/2020 and 01/01/2022");
                                Console.WriteLine("5.Display records where joining date is 12 Jan 2022");
                                Console.WriteLine("6.End");
                                Console.WriteLine("Enter Choice");
                                byte ch = byte.Parse(Console.ReadLine());
                                switch (ch)
                                {
                                    case 1:  
                                        if (list.Count <= 0)
                                        {
                                            Console.WriteLine("No record found");

                                        }
                                        else
                                        {
                                            Console.WriteLine("Total no of developers" + list.Count);
                                            if (onContractList.Count > 0)
                                            {
                                                for (int i = 0; i < onContractList.Count; i++)
                                                {
                                                    Console.WriteLine("On-Contract Developer");
                                                    Console.WriteLine("Id is " + onContractList[i].id);
                                                    Console.WriteLine("Name is " + onContractList[i].developerName);
                                                    Console.WriteLine("Joining date is " + onContractList[i].joiningDate);
                                                    Console.WriteLine("Project assigned is " + onContractList[i].projectAssigned);
                                                    Console.WriteLine("Duration is " + onContractList[i].duration);
                                                    Console.WriteLine("Charges per day is " + onContractList[i].chargesPerDay);
                                                    Console.WriteLine("Net salary is " + onContractList[i].netSalary);
                                                }
                                            }
                                            if (onPayrollList.Count > 0)
                                            {
                                                for (int i = 0; i < onPayrollList.Count; i++)
                                                {
                                                    Console.WriteLine("On-Payroll Developer");
                                                    Console.WriteLine("Id is " + onPayrollList[i].id);
                                                    Console.WriteLine("Name is " + onPayrollList[i].developerName);
                                                    Console.WriteLine("Joining date is " + onPayrollList[i].joiningDate);
                                                    Console.WriteLine("Project assigned is " + onPayrollList[i].projectAssigned);
                                                    Console.WriteLine("Department is " + onPayrollList[i].dept);
                                                    Console.WriteLine("Manager is " + onPayrollList[i].manager);
                                                    Console.WriteLine("Experience is " + onPayrollList[i].exp);
                                                    Console.WriteLine("Basic salary is " + onPayrollList[i].basicSalary);
                                                    Console.WriteLine("Da is " + onPayrollList[i].da);
                                                    Console.WriteLine("Lta is " + onPayrollList[i].lta);
                                                    Console.WriteLine("Hra is " + onPayrollList[i].hra);
                                                    Console.WriteLine("Pf is " + onPayrollList[i].pf);
                                                    Console.WriteLine("Netsalary is " + onPayrollList[i].netSalary);

                                                }
                                            }
                                        }
                                        break;
                                    case 2: var netSalaryMoreThan20k=onPayrollList.Where(x=>x.netSalary >20000).ToList();
                                        if (netSalaryMoreThan20k.Count > 0)
                                        {
                                            for (int i = 0; i < netSalaryMoreThan20k.Count; i++)
                                            {
                                                Console.WriteLine("On-Payroll Developer");
                                                Console.WriteLine("Id is " + onPayrollList[i].id);
                                                Console.WriteLine("Name is " + onPayrollList[i].developerName);
                                                Console.WriteLine("Joining date is " + onPayrollList[i].joiningDate);
                                                Console.WriteLine("Project assigned is " + onPayrollList[i].projectAssigned);
                                                Console.WriteLine("Department is " + onPayrollList[i].dept);
                                                Console.WriteLine("Manager is " + onPayrollList[i].manager);
                                                Console.WriteLine("Experience is " + onPayrollList[i].exp);
                                                Console.WriteLine("Basic salary is " + onPayrollList[i].basicSalary);
                                                Console.WriteLine("Da is " + onPayrollList[i].da);
                                                Console.WriteLine("Lta is " + onPayrollList[i].lta);
                                                Console.WriteLine("Hra is " + onPayrollList[i].hra);
                                                Console.WriteLine("Pf is " + onPayrollList[i].pf);
                                                Console.WriteLine("Netsalary is " + onPayrollList[i].netSalary);
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("No record found");
                                        }
                                        break;
                                    case 3: 
                                        var containsD = list.Where(x => x.developerName.Contains('D')).ToList();
                                        if (containsD.Count > 0)
                                        {
                                            for (int i = 0; i < containsD.Count; i++)
                                            {
                                                Console.WriteLine("Id is " + containsD[i].id);
                                                Console.WriteLine("Name is " + containsD[i].developerName);
                                                Console.WriteLine("Joining date is " + containsD[i].joiningDate);
                                                Console.WriteLine("Project assigned is " + containsD[i].projectAssigned);
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("No record found");
                                        }
                                        break;
                                    case 4:
                                        DateOnly startDate = new DateOnly(2020, 01, 01);
                                        DateOnly endDate = new DateOnly(2022, 01, 01);
                                        var dateValueBtw = list.Where(x => x.joiningDate >= startDate && x.joiningDate <= endDate).ToList();
                                        if (dateValueBtw.Count > 0)
                                        {
                                            for (int i = 0; i < dateValueBtw.Count; i++)
                                            {
                                                Console.WriteLine("Id is " + dateValueBtw[i].id);
                                                Console.WriteLine("Name is " + dateValueBtw[i].developerName);
                                                Console.WriteLine("Joining date is " + dateValueBtw[i].joiningDate);
                                                Console.WriteLine("Project assigned is " + dateValueBtw[i].projectAssigned);
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("No record found");
                                        }
                                        break;
                                    case 5:
                                        DateOnly date = new DateOnly(2022, 01, 12);
                                        var dateValue = list.Where(x => x.joiningDate == date).ToList();
                                        if (dateValue.Count > 0)
                                        {
                                            for (int i = 0; i < dateValue.Count; i++)
                                            {
                                                Console.WriteLine("Id is " + dateValue[i].id);
                                                Console.WriteLine("Name is " + dateValue[i].developerName);
                                                Console.WriteLine("Joining date is " + dateValue[i].joiningDate);
                                                Console.WriteLine("Project assigned is " + dateValue[i].projectAssigned);
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("No record found");
                                        }
                                        break;
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
