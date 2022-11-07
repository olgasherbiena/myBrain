using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain
{
    public class Occiput:IPrint
    {
        public int id;
        public information inf_occ;
        public string occiput; // зберігається загальна інформація про потиличну частину (та що одразу після заголовку)
        public string first_functional_area;
        public string ventral_flow;
        public string dorsomedial_flow;
        public Occiput()
        {
            id=102;
            occiput = "";
            inf_occ.structure = "";
            inf_occ.latin = "";
            inf_occ.functions="";
            first_functional_area="";
            ventral_flow="";
            dorsomedial_flow="";
            inf_occ.clinical_significance="";

        }
        public void Print(string str) { }
        public void Print_all_information() { }
    }
}
