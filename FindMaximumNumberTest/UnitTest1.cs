using Generics;
using NUnit.Framework;
namespace FindMaximumNumberTest
{
    public class Tests
    {
        //A - Arrange
        //A - Act
        //A - Assert
        [Test]
        public void GivenMaxFirstNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximum max =new FindMaximum();
            int num = max.FindMaxIntNumber(3, 1, 2);
            Assert.AreEqual(num, 3);
        }

        [Test]
        public void GivenMaxSecondNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximum max = new FindMaximum();
            int num = max.FindMaxIntNumber(1, 3, 2);
            Assert.AreEqual(num, 3);
        }

        [Test]
        public void GivenMaxThirdNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximum max = new FindMaximum();
            int num = max.FindMaxIntNumber(2, 1, 3);
            Assert.AreEqual(num, 3);
        }

        [Test]
        public void GivenMaxFloatFirstNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximum max = new FindMaximum();
            float num = max.FindMaxFloatNumber(3.3f,2.2f,1.1f);
            Assert.AreEqual(num, 3.3f);
        }

        [Test]
        public void GivenMaxFloatSecondNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximum max = new FindMaximum();
            float num = max.FindMaxFloatNumber(2.2f, 3.3f, 1.1f);
            Assert.AreEqual(num, 3.3f);
        }

        [Test]
        public void GivenMaxFloatThirdtNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximum max = new FindMaximum();
            float num = max.FindMaxFloatNumber(1.1f, 2.2f, 3.3f);
            Assert.AreEqual(num, 3.3f);
        }

    }
}