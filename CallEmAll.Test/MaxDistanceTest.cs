using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CallEmAll;

namespace CallEmAll.Test
{
    [TestClass]
    public class MaxDistanceTest
    {
        /// <summary>
        /// Tests the nominal case
        /// </summary>
        [TestMethod]
        public void Nominal()
        {
            // Arrange
            char[] letters = new char[] { 'g', 'b', 'c', 'j', 'b', 'd', 'h', 'a' };

            // Act
            int actual = Program.MaxDistance(letters);

            // Assert in test attribute
            // 7 characters between 'b' and 'j'
            Assert.AreEqual<int>(7, actual);
        }

        /// <summary>
        /// Tests the nominal case
        /// </summary>
        [TestMethod]
        public void Nominal2()
        {
            // Arrange
            char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'z' };

            // Act
            int actual = Program.MaxDistance(letters);

            // Assert in test attribute
            // 24 characters bettwen 'a' and 'z'
            Assert.AreEqual<int>(24, actual);
        }

        /// <summary>
        /// Tests the nominal case
        /// </summary>
        [TestMethod]
        public void DecrementedSortedList()
        {
            // Arrange
            char[] letters = new char[] { 'z', 'y', 'a' };

            // Act
            int actual = Program.MaxDistance(letters);

            // Assert in test attribute
            // Should return 0 since no previous characters are larger than any element
            Assert.AreEqual<int>(0, actual);
        }

        /// <summary>
        /// Tests error case when input character array is null
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NullInputArgument()
        {
            // Arrange
            char[] letters = null;

            // Act
            Program.MaxDistance(letters);

            // Assert in test attribute
        }

        /// <summary>
        /// Tests error case when input array has length less than 2
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidLengthInputArgument()
        {
            // Arrange
            char[] letters = new char[] { 'a' };

            // Act
            Program.MaxDistance(letters);
            // Assert in test attribute
        }

        /// <summary>
        /// Tests error case when an element of the input array is not a lower case character
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NonAlphaChars()
        {
            // Arrange
            char[] letters = new char[] { '.' };

            // Act
            Program.MaxDistance(letters);
        }

        /// <summary>
        /// Tests error case when an element of the input array is not a lower case character
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UpperAlphaChars()
        {
            // Arrange
            char[] letters = new char[] { 'A' };

            // Act
            Program.MaxDistance(letters);
        }
    }
}
