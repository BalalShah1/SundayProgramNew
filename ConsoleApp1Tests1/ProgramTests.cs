using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestCountFirstDaySundays()
        {
            // Arrange
            int startYear = 1901;
            int endYear = 2000;

            // Act
            int result = Program.CountFirstDaySundays(startYear, endYear);

            // Assert
            Assert.AreEqual(171, result); 
        }

        [TestMethod]
        public void TestCalculateDaysInMonth()
        {
            // Arrange
            int nonLeapYear = 2023; // A non-leap year
            int leapYear = 2024;    // A leap year

            // Act and Assert 
            Assert.AreEqual(28, Program.CalculateDaysInMonth(2, nonLeapYear)); // February (non-leap year)

            // Assert 
            Assert.AreEqual(29, Program.CalculateDaysInMonth(2, leapYear));
        }
    }
}