using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain
{
    public class Occiput:Part, IPrint
    {
        public int id;
        public string occiput; // зберігається загальна інформація про потиличну частину (та що одразу після заголовку)
        public string first_functional_area;
        public string ventral_flow;
        public string dorsomedial_flow;
        public Occiput()
        {
            id=102;
            occiput = "";
            structure = "";
            latin = "";
            functions="";
            first_functional_area="";
            ventral_flow="";
            dorsomedial_flow="";
            clinical_significance="";

        }
        public void Print(string str) { }
        public void Print_all_information() { }
    }
}
