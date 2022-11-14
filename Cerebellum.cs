using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain
{
    public class Cerebellum:Part, IPrint
    {
        public int id;
        public string cerebellum_name; // зберігається загальна інформація про мозечок (та що одразу після заголовку)
        public Cerebellum()
        {
            id=101;
            cerebellum = "";
            structure = "";
            latin = "";
            functions = "";
            clinical_significance = "";
        }
        public void Print(string str) { }
        public void Print_all_information() { }
    }
}
