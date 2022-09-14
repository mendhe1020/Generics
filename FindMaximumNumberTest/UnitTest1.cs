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

        [Test]
        public void GivenMaxStringFirstNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximum max = new FindMaximum();
            string name = max.FindMaxStringValue("Peach", "Apple", "Banana");
            Assert.AreEqual(name, "Peach");
        }

        [Test]
        public void GivenMaxStringSecondNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximum max = new FindMaximum();
            string name = max.FindMaxStringValue("Apple","Peach","Banana");
            Assert.AreEqual(name, "Peach");
        }
        [Test]
        public void GivenMaxStringThirdtNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximum max = new FindMaximum();
            string name = max.FindMaxStringValue("Banana","Apple","Peach");
            Assert.AreEqual(name, "Peach");
        }

        // Generics

        [Test]
        public void GivenMaxFirstPosition_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenerics<int> max = new FindMaxGenerics<int>(3,1,2);
            int num = max.FindMax();
            Assert.AreEqual(num,3);
        }

        [Test]
        public void GivenMaxSecondPosition_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenerics<int> max = new FindMaxGenerics<int>(1, 3, 2);
            int num = max.FindMax();
            Assert.AreEqual(num, 3);
        }

        [Test]
        public void GivenMaxThirdPosition_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenerics<int> max = new FindMaxGenerics<int>(2, 1, 3);
            int num = max.FindMax();
            Assert.AreEqual(num, 3);
        }

        [Test]
        public void GivenMaxFloatFirstPosition_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenerics<float> max = new FindMaxGenerics<float>(3.3f, 1.1f, 2.2f);
            float num = max.FindMax();
            Assert.AreEqual(num, 3.3f);
        }

        [Test]
        public void GivenMaxFloatSecondPosition_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenerics<float> max = new FindMaxGenerics<float>(1.1f, 3.3f, 2.2f);
            float num = max.FindMax();
            Assert.AreEqual(num, 3.3f);
        }

        [Test]
        public void GivenMaxThirdFirstPosition_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenerics<float> max = new FindMaxGenerics<float>(2.2f, 1.1f, 3.3f);
            float num = max.FindMax();
            Assert.AreEqual(num, 3.3f);
        }

        [Test]
        public void GivenMaxStringFirstPosition_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenerics<string> max = new FindMaxGenerics<string>("Peach", "Apple", "Banana");
            string name = max.FindMax();
            Assert.AreEqual(name, "Peach");
        }

        [Test]
        public void GivenMaxStringSecondPosition_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenerics<string> max = new FindMaxGenerics<string>("Apple", "Peach", "Banana");
            string name = max.FindMax();
            Assert.AreEqual(name, "Peach");
        }

        [Test]
        public void GivenMaxStringThirdPosition_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenerics<string> max = new FindMaxGenerics<string>("Banana", "Apple", "Peach");
            string name = max.FindMax();
            Assert.AreEqual(name, "Peach");
        }
    }
}