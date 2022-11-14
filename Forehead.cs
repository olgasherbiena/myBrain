using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain
{
    public class Forehead:Part, IPrint
    {
        public int id;
        public string forehead_part; // зберігається загальна інформація про лобову частину (та що одразу після заголовку)
        public Forehead()
        {
            id=120;
            forehead_part = "";
            structure = "";
            latin = "";
            functions = "";
            clinical_significance = "";
        }
        public void Print(string str) { }
        public void Print_all_information() { }
    }
}
