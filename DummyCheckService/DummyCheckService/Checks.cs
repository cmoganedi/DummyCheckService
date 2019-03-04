using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DummyCheckService
{
    public class CriminalCheck
    {
        public string name;
        public string surname;
        public int idNr;
        public string[] CriminalRecords;
    }

    public class CreditCheck
    {
        public string name;
        public string surname;
        public int idNr;
        public int creditScore;
    }

    public class AcademicCheck
    {
        public string name;
        public string surname;
        public int idNr;
        public bool hasQualification;
    }
}
