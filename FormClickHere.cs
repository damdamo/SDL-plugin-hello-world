using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPluginWindowHello
{
    public partial class FormClickHere : Form
    {
        public FormClickHere()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1Txt.Text = "Hello World !";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormClickHere_Load(object sender, EventArgs e)
        {

        }
    }
}
