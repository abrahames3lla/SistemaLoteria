namespace CapaPresentacion
{
    partial class Consorcio
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
            this.IDEmpleadoLabel = new System.Windows.Forms.Label();
            this.ConsorcioLabel = new System.Windows.Forms.Label();
            this.IDEmpleadoTextBox = new System.Windows.Forms.TextBox();
            this.ConsorcioTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(421, 392);
            // 
            // EditarButton
            // 
            this.EditarButton.Location = new System.Drawing.Point(294, 392);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(167, 392);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(40, 392);
            // 
            // IDEmpleadoLabel
            // 
            this.IDEmpleadoLabel.AutoSize = true;
            this.IDEmpleadoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDEmpleadoLabel.ForeColor = System.Drawing.Color.Black;
            this.IDEmpleadoLabel.Location = new System.Drawing.Point(160, 313);
            this.IDEmpleadoLabel.Name = "IDEmpleadoLabel";
            this.IDEmpleadoLabel.Size = new System.Drawing.Size(106, 19);
            this.IDEmpleadoLabel.TabIndex = 16;
            this.IDEmpleadoLabel.Text = "ID Empleado";
            // 
            // ConsorcioLabel
            // 
            this.ConsorcioLabel.AutoSize = true;
            this.ConsorcioLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsorcioLabel.ForeColor = System.Drawing.Color.Black;
            this.ConsorcioLabel.Location = new System.Drawing.Point(160, 251);
            this.ConsorcioLabel.Name = "ConsorcioLabel";
            this.ConsorcioLabel.Size = new System.Drawing.Size(89, 19);
            this.ConsorcioLabel.TabIndex = 17;
            this.ConsorcioLabel.Text = "Consorcio";
            // 
            // IDEmpleadoTextBox
            // 
            this.IDEmpleadoTextBox.BackColor = System.Drawing.Color.White;
            this.IDEmpleadoTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDEmpleadoTextBox.ForeColor = System.Drawing.Color.Black;
            this.IDEmpleadoTextBox.Location = new System.Drawing.Point(164, 335);
            this.IDEmpleadoTextBox.Name = "IDEmpleadoTextBox";
            this.IDEmpleadoTextBox.Size = new System.Drawing.Size(247, 26);
            this.IDEmpleadoTextBox.TabIndex = 15;
            // 
            // ConsorcioTextBox
            // 
            this.ConsorcioTextBox.BackColor = System.Drawing.Color.White;
            this.ConsorcioTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsorcioTextBox.ForeColor = System.Drawing.Color.Black;
            this.ConsorcioTextBox.Location = new System.Drawing.Point(164, 273);
            this.ConsorcioTextBox.Name = "ConsorcioTextBox";
            this.ConsorcioTextBox.Size = new System.Drawing.Size(247, 26);
            this.ConsorcioTextBox.TabIndex = 14;
            // 
            // Consorcio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.IDEmpleadoLabel);
            this.Controls.Add(this.ConsorcioLabel);
            this.Controls.Add(this.IDEmpleadoTextBox);
            this.Controls.Add(this.ConsorcioTextBox);
            this.Name = "Consorcio";
            this.Text = "Consorcio";
            this.Controls.SetChildIndex(this.NuevoButton, 0);
            this.Controls.SetChildIndex(this.GuardarButton, 0);
            this.Controls.SetChildIndex(this.EditarButton, 0);
            this.Controls.SetChildIndex(this.EliminarButton, 0);
            this.Controls.SetChildIndex(this.ConsorcioTextBox, 0);
            this.Controls.SetChildIndex(this.IDEmpleadoTextBox, 0);
            this.Controls.SetChildIndex(this.ConsorcioLabel, 0);
            this.Controls.SetChildIndex(this.IDEmpleadoLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDEmpleadoLabel;
        private System.Windows.Forms.Label ConsorcioLabel;
        private System.Windows.Forms.TextBox IDEmpleadoTextBox;
        private System.Windows.Forms.TextBox ConsorcioTextBox;
    }
}