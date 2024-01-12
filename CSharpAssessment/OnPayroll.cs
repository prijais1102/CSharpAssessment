namespace CSharpAssessment
{
    internal class OnPayroll:Developer
    {
        string dept;
        string manager;
        decimal netSalary;
        int exp;
        decimal da;
        decimal hra;
        decimal lta;
        decimal pf;
        decimal basicSalary;
        //List<OnPayroll> onPayroll=new List<OnPayroll>();
        public OnPayroll()
        {

        }
        public OnPayroll(string dept, string manager, decimal netSalary, int exp, decimal da, decimal hra, decimal lta, decimal pf, int id, string developerName, DateOnly joiningDate, string projectAssigned,decimal basicSalary):base(id, developerName, joiningDate , projectAssigned)
        {
            this.dept = dept;
            this.manager = manager;
            this.netSalary = netSalary;
            this.exp = exp;
            this.da = da;
            this.hra = hra;
            this.lta = lta;
            this.pf = pf;
            this.basicSalary = basicSalary;
        }
        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter Department");
            dept = Console.ReadLine();
            Console.WriteLine("Enter Manager");
            manager = Console.ReadLine();
            Console.WriteLine("Enter experience in years");
            exp= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter basic salary");
            basicSalary= decimal.Parse(Console.ReadLine());
            //AddDeveloper(id, developerName, joiningDate, projectAssigned,dept,manager,exp,basicSalary);
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            //for (int i = 0; i < onPayroll.Count; i++)
            //{                
            //    Console.WriteLine("OnPayroll Employee");
            //    Console.WriteLine("Department is" + dept);
            //    Console.WriteLine("Manager is" + manager);
            //    Console.WriteLine("Experience is" + exp);
            //    Console.WriteLine("Basic Salary is" + basicSalary);
            //    NetSalary();
            //}
            Console.WriteLine("OnPayroll Employee");
            Console.WriteLine("Department is" + dept);
            Console.WriteLine("Manager is" + manager);
            Console.WriteLine("Experience is" + exp);
            Console.WriteLine("Basic Salary is" + basicSalary);
            NetSalary();
        }
        public void NetSalary()
        {
            if(exp>10)
            {
                da = (10 * basicSalary)/100;
                lta= (5 * basicSalary)/100;
                hra= (85 * basicSalary)/1000;
                pf = 6200;
            }
            else
            if(exp>7 && exp<10)
            {
                da = (7 * basicSalary) / 100;
                lta = (4 * basicSalary) / 100;
                hra = (65 * basicSalary) / 1000;
                pf = 4100;

            }
            else
            if(exp>5 && exp<7)
            {
                da = (41 * basicSalary) / 1000;
                lta = (3 * basicSalary) / 100;
                hra = (38 * basicSalary) / 1000;
                pf = 1800;

            }
            else
                if(exp<5)
            {
                da = (19 * basicSalary) / 1000;
                lta = (2 * basicSalary) / 100;
                hra = (20 * basicSalary) / 1000;
                pf = 1200;

            }
            netSalary=basicSalary+da+lta+hra-pf;
            Console.WriteLine("da is " + da);
            Console.WriteLine("lta is " + lta);
            Console.WriteLine("hra is "+  hra);
            Console.WriteLine("pf is " + pf);
            Console.WriteLine("Netsalary is" + netSalary);
        }
        //public void AddDeveloper(int id, string developerName, DateOnly joiningDate, string projectAssigned, string dept, string manager, int exp, decimal basicSalary)
        //{
        //    onPayroll.Add(new OnPayroll { 
        //        id = id,
        //        developerName = developerName,
        //        joiningDate = joiningDate,
        //        projectAssigned = projectAssigned,
        //        dept = dept,
        //        manager = manager,
        //        exp = exp,
        //        basicSalary = basicSalary

        //    });


        //}
    }
}
