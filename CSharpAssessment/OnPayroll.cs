namespace CSharpAssessment
{
    internal class OnPayroll:Developer
    {
        public string dept { get; set; }
        public string manager { get; set; }
        public decimal netSalary { get; set; }
        public int exp {  get; set; }
        public decimal da { get; set; }
        public decimal hra { get; set; }
        public decimal lta { get; set; }
        public decimal pf { get; set; }
        public decimal basicSalary { get; set; }
        //List<OnPayroll> onPayroll = new List<OnPayroll>();
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
            NetSalary();
            //AddDeveloper(id, developerName, joiningDate, projectAssigned, dept, manager, exp, basicSalary,da, lta, hra, pf,netSalary);
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("Onpayroll employee--");
            base.DisplayDetails();
            //for (int i = 0; i < onPayroll.Count; i++)
            //{               
            //    Console.WriteLine("Department is " + onPayroll[i].dept);
            //    Console.WriteLine("Manager is " + onPayroll[i].manager);
            //    Console.WriteLine("Experience is " + onPayroll[i].exp);
            //    Console.WriteLine("Basic salary is " + onPayroll[i].basicSalary);
            //    Console.WriteLine("Da is " + onPayroll[i].da);
            //    Console.WriteLine("Lta is " + onPayroll[i].lta);
            //    Console.WriteLine("Hra is " + onPayroll[i].hra);
            //    Console.WriteLine("Pf is " + onPayroll[i].pf);
            //    Console.WriteLine("Netsalary is " + onPayroll[i].netSalary);
            //}
            Console.WriteLine("Department is " + dept);
            Console.WriteLine("Manager is " + manager);
            Console.WriteLine("Experience is " + exp);
            Console.WriteLine("Basic salary is " + basicSalary);
            Console.WriteLine("Da is " + da);
            Console.WriteLine("Lta is " + lta);
            Console.WriteLine("Hra is " + hra);
            Console.WriteLine("Pf is " + pf);
            Console.WriteLine("Netsalary is " + netSalary);
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
            
        }
        //public void AddDeveloper(int id, string developername, DateOnly joiningdate, string projectassigned, string dept, string manager, int exp, decimal basicsalary, decimal da,
        //decimal hra,
        //decimal lta,
        //decimal pf, decimal netSalary)
        //{
        //    onPayroll.Add(new OnPayroll
        //    {
        //        id = id,
        //        developerName = developername,
        //        joiningDate = joiningdate,
        //        projectAssigned = projectassigned,
        //        dept = dept,
        //        manager = manager,
        //        exp = exp,
        //        basicSalary = basicsalary,
        //        netSalary = netSalary,
        //        da = da,
        //        hra = hra,
        //        lta = lta,
        //        pf = pf

        //    });


        //}
    }
}
