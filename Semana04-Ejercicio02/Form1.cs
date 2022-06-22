using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana04_Ejercicio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_ejemplonomodal miformularionomodal = new frm_ejemplonomodal();
            miformularionomodal.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frm_ejemplomodal miformulariomodal = new frm_ejemplomodal();
            miformulariomodal.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
