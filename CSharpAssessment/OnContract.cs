namespace CSharpAssessment
{
    internal class OnContract:Developer
    {
        
        public int duration { get; set; }
        public int chargesPerDay { get; set; }
        public int netSalary { get; set; }
        //List<OnContract> onContract = new List<OnContract>();
        public OnContract()
        {

        }
        public OnContract(int duration, int chargesPerDay, int id, string developerName, DateOnly joiningDate, string projectAssigned,int netSalary) : base(id, developerName, joiningDate, projectAssigned)
        {
            this.duration = duration;
            this.chargesPerDay = chargesPerDay;
            this.netSalary = 0;
        }
        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter duration in days");
            duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter charges per day");
            chargesPerDay = int.Parse(Console.ReadLine());
            NetSalary();
            //AddDeveloper(id, developerName, joiningDate, projectAssigned, duration, chargesPerDay,netSalary);
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("OnContract Employee");
            base.DisplayDetails();
            //for (int i = 0; i < onContract.Count; i++)
            //{               
            //    Console.WriteLine("Duration is " + onContract[i].duration);
            //    Console.WriteLine("Charges per day is " + onContract[i].chargesPerDay);               
            //    Console.WriteLine("Net salary is " + onContract[i].netSalary);
            //}
            Console.WriteLine("Duration is " + duration);
            Console.WriteLine("Charges per day is " + chargesPerDay);               
            Console.WriteLine("Net salary is " + netSalary);
            //}

        }
        public void NetSalary()
        {
            netSalary = duration * chargesPerDay;
        }
        //public void AddDeveloper(int id, string developerName, DateOnly joiningDate, string projectAssigned, int duration, int chargesPerDay,int netSalary)
        //{
        //    onContract.Add(new OnContract
        //    {
        //        id = id,
        //        developerName = developerName,
        //        joiningDate = joiningDate,
        //        projectAssigned = projectAssigned,
        //        duration = duration,
        //        chargesPerDay = chargesPerDay,
        //        netSalary=netSalary
        //    });
        //    ;
        //}


    }
}
