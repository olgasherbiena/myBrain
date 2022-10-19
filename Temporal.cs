using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain
{
    public class Temporal:IPrint
    {
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
            temporal_part = "";
            inf_tmp.structure = "";
            inf_tmp.latin = "";
            inf_tmp.functions = "";
            function.otic = "";
            function.visual = "";
            function.speech_recognition = "";
            inf_tmp.clinical_significance = "";
        }
        public void Print(string str) { }
        public void Print_all_information() { }
    }
}
