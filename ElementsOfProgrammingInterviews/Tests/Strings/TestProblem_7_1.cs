using ElementsOfProgrammingInterviews.Strings;
using NUnit.Framework;

namespace Tests.Strings
{
    public class TestProblem_7_1
    {
        [Test]
        public void StringToInt()
        {
            Assert.AreEqual(123, new Problem_7_1().StringToInt("123"));
            Assert.AreEqual(-123, new Problem_7_1().StringToInt("-123"));
            Assert.AreEqual(0, new Problem_7_1().StringToInt("0"));
        }
        
        [Test]
        public void IntToString()
        {
            Assert.AreEqual("123", new Problem_7_1().IntToString(123));
            Assert.AreEqual("-123", new Problem_7_1().IntToString(-123));
            Assert.AreEqual("0", new Problem_7_1().IntToString(0));
        }
    }
}