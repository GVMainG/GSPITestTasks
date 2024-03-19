using GSPITestTasks.Tasks;



namespace GSPITestTasksTest
{
    public class Task2Test
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CountNormalSubstringsTest()
        {
            string testData = "aacaba";

            int result = Task2.CountNormalSubstrings(testData);

            Assert.IsTrue(result == 2);
        }
    }
}