using Day29StateCensus;

namespace StateCensusAnalyserTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LoadDataFromCSV_ShouldReturnNumberOfRecords()
        {
            // Arrange
            string filePath = "C:\\Users\\princ\\OneDrive\\Desktop\\dotnet\\Day29StateCensus\\Day29StateCensus\\Book1.csv";
            StateCensusAnalyser analyser = new StateCensusAnalyser(filePath);
            int expectedNumberOfRecords = 5;

            // Act
            int actualNumberOfRecords = analyser.LoadDataFromCSV();

            // Assert
            Assert.AreEqual(expectedNumberOfRecords, actualNumberOfRecords);
        }
    }
}