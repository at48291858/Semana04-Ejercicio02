using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmasistencia mifrmasistencia = new frmasistencia();
            mifrmasistencia.ShowDialog();
        }

        private void pensionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmpensiones mifrmpensiones = new frmpensiones();
            mifrmpensiones.ShowDialog();
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quieres eliminar a este usuario?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
