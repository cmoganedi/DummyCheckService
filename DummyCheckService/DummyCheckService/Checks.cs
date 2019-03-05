using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DummyCheckService
{
    public class Checks
    {
        public Checks(string cname, string csurname, int id, bool result)
        {
            name = cname;
            surname = csurname;
            idNr = id;
            checkResult = result;
        }
        public string name;
        public string surname;
        public int idNr;
        public bool checkResult;

    }
}
