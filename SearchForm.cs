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
    public partial class SearchForm : Form
    {
        Brain br;
        public SearchForm()
        {
            InitializeComponent();
            br = new Brain();

            listBox1.DataSource = br.brains;

        }
        static void Main()
        {
            Application.Run(new SearchForm());
        }


        private void Search_textbox_TextChanged(object sender, EventArgs e)
        {
            Find temp = new Find();
            temp.Find_information(Search_textbox.Text, listBox1); // Пошук інформації, який виділяє індекс знайденого елементу у listBox

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
        private void button1_Click(object sender, EventArgs e)
        {
            int selected_id = Convert.ToInt32(listBox1.SelectedItem.ToString().Substring(0, 3)); // Отримуємо id частини мозку, що є першими 3 символами рядка
            Part temp_part = GetPart(selected_id);
            // Console.WriteLine(temp_part);

            // TODO: Зробити форму з інформацією про частину, визначену у temp_part
            Form info_form = new Form();
            info_form.Show();
        }
    }
}
