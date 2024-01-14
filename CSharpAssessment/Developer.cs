﻿namespace CSharpAssessment
{
    internal class Developer
    {
        public int id;
        public string developerName;
        public DateOnly joiningDate;
        public string projectAssigned;
        List<Developer> list = new List<Developer>();
        public Developer()
        {

        }
        public Developer(int id, string developerName, DateOnly joiningDate, string projectAssigned)
        {
            this.id = id;
            this.developerName = developerName;
            this.joiningDate = joiningDate;
            this.projectAssigned = projectAssigned;
        }
        public virtual void GetDetails()
        {
            Console.WriteLine("Enter id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter developer name");
            developerName = Console.ReadLine();
            Console.WriteLine("Enter joining date");
            joiningDate = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Enter project Assigned");
            projectAssigned = Console.ReadLine();
            AddDeveloper(id, developerName, joiningDate, projectAssigned);
        }
        public virtual void DisplayDetails()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Id is " + list[i].id);
                Console.WriteLine("Name is " + list[i].developerName);
                Console.WriteLine("Joining date is " + list[i].joiningDate);
                Console.WriteLine("Project assigned is " + list[i].projectAssigned);
            }

        }
        public virtual void AddDeveloper(int id, string developerName, DateOnly joiningDate, string projectAssigned)
        {
            list.Add(new Developer
            {
                id = id,
                developerName = developerName,
                joiningDate = joiningDate,
                projectAssigned = projectAssigned
            });
        }

    }

}
