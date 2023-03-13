using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day29StateCensus
{
    public class StateCensusAnalyser
    {
        private string filePath;

        public StateCensusAnalyser(string filePath)
        {
            this.filePath = filePath;
        }


        public int LoadDataFromCSV()
        {
            int numberOfRecords = 0;
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    bool isHeader = true;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (isHeader)
                        {
                            // Check that the header is correct
                            if (line != "State,Population,Males,Females")
                            {
                                throw new Exception("Incorrect header: " + line);
                            }
                            isHeader = false;
                        }
                        else
                        {
                            string[] fields = line.Split(',');

                            // Check that the number of fields is correct
                            if (fields.Length != 5)
                            {
                                throw new Exception("Incorrect number of fields in row: " + line);
                            }

                            // Process the fields here
                            numberOfRecords++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }

            return numberOfRecords;
        }

        public int LoadDataFromCSV(char delimiter)
        {
            int numberOfRecords = 0;
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] fields = line.Split(delimiter);

                        // Check that the number of fields is correct
                        if (fields.Length != 5)
                        {
                            throw new Exception("Incorrect number of fields in row: " + line);
                        }

                        // Process the fields here
                        numberOfRecords++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }

            return numberOfRecords;
        }
    }
}
