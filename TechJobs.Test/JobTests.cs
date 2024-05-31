
using System.Data.Common;
using System.Xml;

namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing Objects
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        //initalize your testing objects here

    [TestMethod]  //1
        public void TestSettingJobId()
        {
            Assert.IsFalse(job1.Id == job2.Id);
        }

    [TestMethod]  //2
        public void TestJobConstructorSetsAllFields()
        {
            string Name = "Product tester";
            string EmployerName = "ACME";
            string EmployerLocation = "Desert";
            string JobType = "Quality control";
            string JobCoreCompetency = "Persistence";


            Assert.AreEqual(Name, job3.Name);
            Assert.AreEqual(EmployerName, job3.EmployerName.Value);
            Assert.AreEqual(EmployerLocation, job3.EmployerLocation.Value);
            Assert.AreEqual(JobType, job3.JobType.Value);
            Assert.AreEqual(JobCoreCompetency, job3.JobCoreCompetency.Value);

        }

    [TestMethod]  //3
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3.Equals(job4));
        } 







        //Task 5 Tests
        [TestMethod] //1
        public void TestToStringStartsAndEndsWithNewLine()
        {
            string result = job3.ToString();
            
            Assert.IsTrue(result.StartsWith(Environment.NewLine));
            Assert.IsTrue(result.EndsWith(Environment.NewLine));

        }

        [TestMethod] //2
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

           
            string Name = "Product tester";
            string EmployerName = "ACME";
            string EmployerLocation = "Desert";
            string JobType = "Quality control";
            string JobCoreCompetency = "Persistence";


            Assert.AreEqual(Name, job3.Name);
            Assert.AreEqual(EmployerName, job3.EmployerName.Value);
            Assert.AreEqual(EmployerLocation, job3.EmployerLocation.Value);
            Assert.AreEqual(JobType, job3.JobType.Value);
            Assert.AreEqual(JobCoreCompetency, job3.JobCoreCompetency.Value);


        }

        [TestMethod] //3
        public void TestToStringHandlesEmptyField()
        {
            Job job3 = new Job("Product tester", new Employer(""), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            int Id = job3.Id;
            string Name = "Product tester";
            string EmployerName = "Data not available";
            string EmployerLocation = "Desert";
            string JobType = "Quality control";
            string JobCoreCompetency = "Persistence";
            
            string nl = Environment.NewLine;

            string expected = nl + "ID: " + Id + nl + "Name: " + Name + nl + "Employer: " + EmployerName + nl + "Location: " + EmployerLocation + nl + "Position Type: " + JobType + nl + "Core Competency: " + JobCoreCompetency + nl;

            string result = job3.ToString();

            Assert.AreEqual(expected, result);
        }




    }
}

