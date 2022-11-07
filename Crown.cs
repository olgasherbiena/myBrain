using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain
{
    public class Crown:IPrint
    {
        public int id;
        public information inf_crw;
        public string crown_part; // зберігається загальна інформація про тім'яну частину (та що одразу після заголовку)
        public string lateral_intraparietal_area;
        public string ventral_intraparietal_area;
        public string medial_intraparietal_area;
        public string front_intraparietal_area;
        public Crown()
        {
            id=110;
            crown_part = "";
            inf_crw.structure = "";
            inf_crw.latin = "";
            inf_crw.functions = "";
            lateral_intraparietal_area = "";
            ventral_intraparietal_area = "";
            medial_intraparietal_area = "";
            front_intraparietal_area = "";
            inf_crw.clinical_significance = "";
        }
        public void Print(string str) { }
        public void Print_all_information() { }
    }
}
