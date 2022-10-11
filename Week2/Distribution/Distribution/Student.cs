using LINQtoCSV;
using System;

namespace csv_parser
{
    internal class Student
    {
        [CsvColumn(Name = "Sex", FieldIndex = 1)]
        public string Gender { get; set; }

        [CsvColumn(Name = "Weight", FieldIndex = 2)]
        public string Weight { get; set; }

        [CsvColumn(Name = "Height", FieldIndex = 3)]
        public string Height { get; set; }

    }
}