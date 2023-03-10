using MoodAnalyserProblem;

namespace AnalyzerTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestMethodForHappyMood()

        {
            string expected = "happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in happy Mood");
            string actual = moodAnalyser.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestMethodForSadMood()

        {
            string expected = "sad";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in sad Mood");
            string actual = moodAnalyser.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestMethodForNullMood()

        {
            string expected = "happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in happy Mood");
            string actual = moodAnalyser.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestMethodForCustomizedNullException()

        {
            string expected = "Mood should not be null";
            try
            {

                MoodAnalyser moodAnalyser = new MoodAnalyser(null);
                moodAnalyser.AnalyzeMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }


        }
        public void TestMethodForCustomizedEmptyException()

        {
            string expected = "Mood should not be empty";
            try
            {

                MoodAnalyser moodAnalyser = new MoodAnalyser(string.Empty);
                moodAnalyser.AnalyzeMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}


