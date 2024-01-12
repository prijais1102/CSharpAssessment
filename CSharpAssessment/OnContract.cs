namespace CSharpAssessment
{
    internal class OnContract:Developer
    {
        
        int duration;
        int chargesPerDay;
        int netSalary;
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
            Console.WriteLine("Enter durationin days");
            duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter charges per day");
            chargesPerDay = int.Parse(Console.ReadLine());
            //AddDeveloper(id,developerName, joiningDate,projectAssigned,duration,chargesPerDay);
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            //for (int i = 0; i < onContract.Count; i++)
            //{                
            //    Console.WriteLine("OnContract Employee");
            //    Console.WriteLine("Duration is" + duration);
            //    Console.WriteLine("Charges per day is" + chargesPerDay);
            //    NetSalary();
            //}
            Console.WriteLine("OnContract Employee");
            Console.WriteLine("Duration is" + duration);
            Console.WriteLine("Charges per day is" + chargesPerDay);
            NetSalary();

        }
        public void NetSalary()
        {
            netSalary = duration * chargesPerDay;
            Console.WriteLine("Net salary is" + netSalary);
        }
        //public void AddDeveloper(int id, string developerName, DateOnly joiningDate, string projectAssigned, int duration, int chargesPerDay)
        //{
        //    onContract.Add(new OnContract
        //    {
        //        id=id,
        //        developerName=developerName,
        //        joiningDate=joiningDate,
        //        projectAssigned=projectAssigned,
        //        duration = duration,
        //        chargesPerDay = chargesPerDay
        //    });
        //    ;
        //}


    }
}
