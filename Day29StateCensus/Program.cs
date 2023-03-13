namespace Day29StateCensus
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to the master branch for assignment : Day 29 State Census");
            string filePath = "C:\\Users\\princ\\OneDrive\\Desktop\\dotnet\\Day29StateCensus\\Day29StateCensus\\Book1.csv";
            StateCensusAnalyser analyser = new StateCensusAnalyser(filePath);
            int numberOfRecords = analyser.LoadDataFromCSV();
            Console.WriteLine("Number of records in the file: " + numberOfRecords);

        }
    }
}