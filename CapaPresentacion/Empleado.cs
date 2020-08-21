using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Empleado : MantenimientoBase
    {
        public Empleado()
        {
            InitializeComponent();
        }

        public bool Validate()
        {
                    bool output = true;
                    if (!ValidarCampos.NotEmpty(NombreTextBox.Text))
                    {
                        output = false;
                        errorProvider1.SetError(NombreTextBox, "Este campo no puede estar vacio");
                    }

                    if (!ValidarCampos.OnlyLetter(NombreTextBox.Text))
                    {
                        output = false;
                        errorProvider1.SetError(NombreTextBox, "Este campo puede tener solamente letras");
                    }

        if (!ValidarCampos.NotEmpty(ApellidoTextBox.Text))
        {
            output = false;
            errorProvider1.SetError(ApellidoTextBox, "Este campo no puede estar vacio");
        }

        if (!ValidarCampos.OnlyLetter(ApellidoTextBox.Text))
        {
            output = false;
            errorProvider1.SetError(ApellidoTextBox, "Este campo puede tener solamente letras");
        }

        if (!ValidarCampos.NotEmpty(SexoComboBox.Text))
        {
            output = false;
            errorProvider1.SetError(SexoComboBox, "Este campo no puede estar vacio");
        }

        if (!ValidarCampos.OnlyLetter(SexoComboBox.Text))
        {
            output = false;
            errorProvider1.SetError(SexoComboBox, "Este campo puede tener solamente letras");
        }

        if (!ValidarCampos.NotEmpty(TelefonoTextBox.Text))
        {
            output = false;
            errorProvider1.SetError(TelefonoTextBox, "Este campo no puede estar vacio");
        }

        if (!ValidarCampos.OnlyNumber(TelefonoTextBox.Text))
        {
            output = false;
            errorProvider1.SetError(TelefonoTextBox, "Este campo puede tener solamente letras");
        }

        if (!ValidarCampos.NotEmpty(TelefonoTextBox.Text))
        {
            output = false;
            errorProvider1.SetError(TelefonoTextBox, "Este campo no puede estar vacio");
        }

        if (!ValidarCampos.OnlyNumber(TelefonoTextBox.Text))
        {
            output = false;
            errorProvider1.SetError(TelefonoTextBox, "Este campo puede tener solamente letras");
        }


        return output;
                }

        private void Empleado_Load(object sender, EventArgs e)
        {

        }
    }
}
