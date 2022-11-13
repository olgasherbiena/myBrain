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
        private void button1_Click(object sender, EventArgs e)
        {
            int selected_id = Convert.ToInt32(listBox1.SelectedItem.ToString().Substring(0, 3)); // Отримуємо id частини мозку, що є першими 3 символами рядка

            // TODO: Зробити форму з інформацією про частину, визначену у temp_part
            PartInfoForm info_form = new PartInfoForm(selected_id, br);
            info_form.Show();
        }
    }
}
