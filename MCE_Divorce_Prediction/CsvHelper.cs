using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace MCE_Divorce_Prediction
{

    enum Genders
    {
        Male,
        Female,
    }

    class CsvHelper
    {

        public List<DivorceQuestionData> getRecords()
        {
            using (var reader = new StreamReader("A:\\GitHubDesktop\\Repositories\\CS346\\Week 4\\Activity on Backprop\\MCE_Divorce_Prediction\\MCE_Divorce_Prediction\\data.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {

                var records = csv.GetRecords<DivorceQuestionData>().ToList();

                return records;
            }
        }




    }

    public class DivorceQuestionData
    {
        [Name("Q1")]
        public int Q1 { get; set; }

        [Name("Q2")]
        public int Q2 { get; set; }

        [Name("Q3")]
        public int Q3 { get; set; }

        [Name("Q4")]
        public int Q4 { get; set; }

        [Name("Q5")]
        public int Q5 { get; set; }


        [Name("Q6")]
        public int Q6 { get; set; }

        [Name("Q7")]
        public int Q7 { get; set; }

        [Name("Q8")]
        public int Q8 { get; set; }

        [Name("Q9")]
        public int Q9 { get; set; }

        [Name("Q10")]
        public int Q10 { get; set; }

        [Name("Divorce")]
        public int Divorce { get; set; }
    }

   
}
