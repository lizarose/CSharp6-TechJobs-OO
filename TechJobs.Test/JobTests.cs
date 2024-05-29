
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
            string testName = "Product tester";
            string testEmployerName = "ACME";
            string testEmployerLocation = "Desert";
            string testJobType = "Quality control";
            string testJobCoreCompetency = "Persistence";


            Assert.AreEqual(testName, job3.Name);
            Assert.AreEqual(testEmployerName, job3.EmployerName);
            Assert.AreEqual(testEmployerLocation, job3.EmployerLocation);
            Assert.AreEqual(testJobType, job3.JobType);
            Assert.AreEqual(testJobCoreCompetency, job3.JobCoreCompetency);

        }

    [TestMethod]  //3
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3.Equals(job4));
        } 







    }
}

