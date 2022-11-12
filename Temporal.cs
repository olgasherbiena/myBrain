using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain
{
    public class Temporal: Part, IPrint
    {
        public const int id = 202;
        public information inf_tmp;
        public string temporal_part; // зберігається загальна інформація про скроневу частину (та що одразу після заголовку)
        public struct touch_input_processing // обробка сенсорного введення
        {
            public string otic;
            public string visual;
            public string speech_recognition;
        }
        public touch_input_processing function;
        public Temporal()
        {
            //id=202;
            temporal_part = "tmp_part";
            inf_tmp.structure = "tmp_struct";
            inf_tmp.latin = "tmp_lat";
            inf_tmp.functions = "tmp_func";
            function.otic = "tmp1";
            function.visual = "tmp2";
            function.speech_recognition = "tmp3";
            inf_tmp.clinical_significance = "tmp4";
        }
        public void Print(string str) { }
        public void Print_all_information() { }

        public override string ToString()
        {
            return $"{id}; Name: {this.temporal_part}; Latin: {this.inf_tmp.latin}; Functions: {this.inf_tmp.functions}";
        }
    }
}
