namespace WinFormsApp1
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblInstruccion = new Label();
            btnSaludar = new Button();
            btnDespedir = new Button();
            SuspendLayout();
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstruccion.Location = new Point(2, 45);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(347, 25);
            lblInstruccion.TabIndex = 0;
            lblInstruccion.Text = "Pulsa el botón para mostrar un mensaje";
            // 
            // btnSaludar
            // 
            btnSaludar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaludar.Location = new Point(52, 96);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(100, 40);
            btnSaludar.TabIndex = 1;
            btnSaludar.Text = "Saludar";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // btnDespedir
            // 
            btnDespedir.BackColor = Color.Red;
            btnDespedir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDespedir.ForeColor = SystemColors.ControlLightLight;
            btnDespedir.Location = new Point(189, 96);
            btnDespedir.Name = "btnDespedir";
            btnDespedir.Size = new Size(100, 40);
            btnDespedir.TabIndex = 2;
            btnDespedir.Text = "Despedir";
            btnDespedir.UseVisualStyleBackColor = false;
            btnDespedir.Click += btnDespedir_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(364, 192);
            Controls.Add(btnDespedir);
            Controls.Add(btnSaludar);
            Controls.Add(lblInstruccion);
            Name = "frmPrincipal";
            RightToLeft = RightToLeft.No;
            Text = "Mi primera aplicación ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInstruccion;
        private Button btnSaludar;
        private Button btnDespedir;
    }
}
