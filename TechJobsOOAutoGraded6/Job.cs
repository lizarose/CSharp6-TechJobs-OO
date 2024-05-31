using System;
namespace TechJobsOOAutoGraded6
{
	public class Job
	{

            public int Id { get; }
            private static int nextId = 1;
            public string Name { get; set; }
            public Employer EmployerName { get; set; }
            public Location EmployerLocation { get; set; }
            public PositionType JobType { get; set; }
            public CoreCompetency JobCoreCompetency { get; set; }

            // TODO: Task 3: Add the two necessary constructors.
            public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }
            // TODO: Task 3: Generate Equals() and GetHashCode() methods.  
            public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.

        public override string ToString()
        {
            string checkName = Name == "" ? "Data not available" : Name;
            string checkEmployerName = EmployerName.Value == "" ? "Data not available" : EmployerName.Value;
            string checkEmployerLocation = EmployerLocation.Value == "" ? "Data not available" : EmployerLocation.Value;
            string checkPositionType = JobType.Value == "" ? "Data not available" : JobType.Value;
            string checkCoreCompetency = JobCoreCompetency.Value == "" ? "Data not available" : JobCoreCompetency.Value;



            string nl = Environment.NewLine;

            string format = nl + "ID: " + Id + nl + "Name: " + checkName + nl + "Employer: " + checkEmployerName + nl + "Location: " + checkEmployerLocation + nl + "Position Type: " + checkPositionType + nl + "Core Competency: " + checkCoreCompetency + nl;
        



            return format;
        }
    }
}

