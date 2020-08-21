namespace CapaPresentacion
{
    partial class Empleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.TelefonoTextBox = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.TipoEmpleadoCombobox = new System.Windows.Forms.ComboBox();
            this.SexoComboBox = new System.Windows.Forms.ComboBox();
            this.FechaDeNacimientoPiccker = new System.Windows.Forms.DateTimePicker();
            this.FechaIngresadoPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(418, 511);
            // 
            // EditarButton
            // 
            this.EditarButton.Location = new System.Drawing.Point(287, 511);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(156, 511);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(25, 511);
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(142, 181);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(272, 26);
            this.NombreTextBox.TabIndex = 10;
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Location = new System.Drawing.Point(142, 228);
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(272, 26);
            this.ApellidoTextBox.TabIndex = 10;
            // 
            // TelefonoTextBox
            // 
            this.TelefonoTextBox.Location = new System.Drawing.Point(142, 370);
            this.TelefonoTextBox.Name = "TelefonoTextBox";
            this.TelefonoTextBox.Size = new System.Drawing.Size(272, 26);
            this.TelefonoTextBox.TabIndex = 10;
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(142, 464);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(272, 26);
            this.Direccion.TabIndex = 10;
            // 
            // TipoEmpleadoCombobox
            // 
            this.TipoEmpleadoCombobox.FormattingEnabled = true;
            this.TipoEmpleadoCombobox.Location = new System.Drawing.Point(142, 133);
            this.TipoEmpleadoCombobox.Name = "TipoEmpleadoCombobox";
            this.TipoEmpleadoCombobox.Size = new System.Drawing.Size(272, 27);
            this.TipoEmpleadoCombobox.TabIndex = 11;
            // 
            // SexoComboBox
            // 
            this.SexoComboBox.FormattingEnabled = true;
            this.SexoComboBox.Location = new System.Drawing.Point(142, 275);
            this.SexoComboBox.Name = "SexoComboBox";
            this.SexoComboBox.Size = new System.Drawing.Size(272, 27);
            this.SexoComboBox.TabIndex = 12;
            // 
            // FechaDeNacimientoPiccker
            // 
            this.FechaDeNacimientoPiccker.Location = new System.Drawing.Point(142, 323);
            this.FechaDeNacimientoPiccker.Name = "FechaDeNacimientoPiccker";
            this.FechaDeNacimientoPiccker.Size = new System.Drawing.Size(272, 26);
            this.FechaDeNacimientoPiccker.TabIndex = 13;
            // 
            // FechaIngresadoPicker
            // 
            this.FechaIngresadoPicker.Location = new System.Drawing.Point(142, 417);
            this.FechaIngresadoPicker.Name = "FechaIngresadoPicker";
            this.FechaIngresadoPicker.Size = new System.Drawing.Size(272, 26);
            this.FechaIngresadoPicker.TabIndex = 14;
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.FechaIngresadoPicker);
            this.Controls.Add(this.FechaDeNacimientoPiccker);
            this.Controls.Add(this.SexoComboBox);
            this.Controls.Add(this.TipoEmpleadoCombobox);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.TelefonoTextBox);
            this.Controls.Add(this.ApellidoTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Name = "Empleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Empleado_Load);
            this.Controls.SetChildIndex(this.NuevoButton, 0);
            this.Controls.SetChildIndex(this.GuardarButton, 0);
            this.Controls.SetChildIndex(this.EditarButton, 0);
            this.Controls.SetChildIndex(this.EliminarButton, 0);
            this.Controls.SetChildIndex(this.NombreTextBox, 0);
            this.Controls.SetChildIndex(this.ApellidoTextBox, 0);
            this.Controls.SetChildIndex(this.TelefonoTextBox, 0);
            this.Controls.SetChildIndex(this.Direccion, 0);
            this.Controls.SetChildIndex(this.TipoEmpleadoCombobox, 0);
            this.Controls.SetChildIndex(this.SexoComboBox, 0);
            this.Controls.SetChildIndex(this.FechaDeNacimientoPiccker, 0);
            this.Controls.SetChildIndex(this.FechaIngresadoPicker, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox ApellidoTextBox;
        private System.Windows.Forms.TextBox TelefonoTextBox;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.ComboBox TipoEmpleadoCombobox;
        private System.Windows.Forms.ComboBox SexoComboBox;
        private System.Windows.Forms.DateTimePicker FechaDeNacimientoPiccker;
        private System.Windows.Forms.DateTimePicker FechaIngresadoPicker;
    }
}