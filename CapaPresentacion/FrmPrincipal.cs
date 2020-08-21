using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public void Pantalla()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Pantalla();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

<<<<<<< HEAD
        private Form formActivado = null;
        private void AbrirFormulario(Form FormHijo)
        {
            if (formActivado != null)
                formActivado.Close();
            formActivado = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.Dock = DockStyle.Fill;
            pnlWrapper.Controls.Add(FormHijo);
            pnlWrapper.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
        }

        private void btnConsocio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsorcio());
=======
        private void pnlWrapper_Paint(object sender, PaintEventArgs e)
        {

>>>>>>> 8dc791a60fe5c4d00e7e5702b3c628aedeeb4a53
        }
    }
}
