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
        public SearchForm()
        {
            InitializeComponent();
            Brain br = new Brain();

            listBox1.DataSource = br.brains;
            Console.WriteLine(br);
            //listBox1.DisplayMember = br.brain.cer.cerebellum;
            //listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            //listBox1.Items.Add(br.brain.cer.cerebellum);

        }

        static void Main()
        {
            Application.Run(new SearchForm());
        }
        private void Search_request_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)listBox1.SelectedValue;
        }
    }
}
