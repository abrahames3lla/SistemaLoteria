using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void C1_TextChanged(object sender, EventArgs e)
        {
        }

        private void C2_TextChanged(object sender, EventArgs e)
        {
        }

        private void C3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labelPanel.Text = "QUINIELA";
            C1.Enabled = true;
            C2.Enabled = false;
            C3.Enabled = false;
            labelc1.Enabled = true;
            labelc2.Enabled = false;
            labelc3.Enabled = false;
            C1.Focus();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            labelPanel.Text = "PALE";
            C1.Enabled = true;
            C2.Enabled = true;
            C3.Enabled = false;
            labelc1.Enabled = true;
            labelc2.Enabled = true;
            labelc3.Enabled = false;
            C1.Focus();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            labelPanel.Text = "TRIPLETA";
            C1.Enabled = true;
            C2.Enabled = true;
            C3.Enabled = true;
            labelc1.Enabled = true;
            labelc2.Enabled = true;
            labelc3.Enabled = true;
            C1.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }






        public static void SoloNumero(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void C1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumero(e);
        }

        private void C2_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumero(e);
        }

        private void C3_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumero(e);
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            //Pantalla();
        }
        public void Pantalla()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnCerrarWindows_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMinizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void Ventas_Load_1(object sender, EventArgs e)
        {
            Pantalla();
        }
        
    }
}
