using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brain
{
    public partial class PartInfoForm : Form
    {
        public PartInfoForm()
        {
            InitializeComponent();
        }

        private Part GetPart(int id)
        {
            /* Цей метод повертає частину мозку, визначену id */

            switch (id)
            {
                case Crown.id:
                    return new Crown();
                case Cerebellum.id:
                    return new Cerebellum();
                case Forehead.id:
                    return new Forehead();
                case Occiput.id:
                    return new Occiput();

                default:
                    return new Temporal();
            }
        }
        public PartInfoForm(int selected_id, Brain brain)
        {
            /* Цей метод ініціалізує вікно в залежності від вибраної частини мозку, визначеної selected_id */

            // TODO: Додати інші елементи частин мозку на вікно
            InitializeComponent();
            Part temp = GetPart(selected_id);
            if (temp.GetType() == typeof(Crown)) // if (temp is Crown crown)
            {
                label1.Text = brain.cr.crown_name;
            }
            else if (temp.GetType() == typeof(Cerebellum))
            {
                label1.Text = brain.cer.cerebellum_name;
            }
            else if (temp.GetType() == typeof(Forehead))
            {
                label1.Text = brain.fr.forehead_name;
            }
            else if (temp.GetType() == typeof(Occiput))
            {
                label1.Text = brain.occ.occiput_name;
            }
            else
            {
                label1.Text = brain.tmp.temporal_name;
            }


        }
    }
}
