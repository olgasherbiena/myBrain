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
            crown_part = "crw_part";
            inf_crw.structure = "crw_struct";
            inf_crw.latin = "crw_lat";
            inf_crw.functions = "crw_func";
            lateral_intraparietal_area = "crw_1";
            ventral_intraparietal_area = "crw_2";
            medial_intraparietal_area = "crw_3";
            front_intraparietal_area = "crw_4";
            inf_crw.clinical_significance = "crw_clinic";
        }
        public void Print(string str) { }
        public void Print_all_information() { }
    }
}
