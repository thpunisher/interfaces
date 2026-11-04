namespace practica2
{
    partial class FormularioBienvenida
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            lblEdad = new Label();
            btnAceptar = new Button();
            lblResultado1 = new Label();
            btnLimpiar = new Button();
            lblResultado2 = new Label();
            lblCurso = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 51);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(57, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre: ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(75, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(187, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(75, 88);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(187, 23);
            txtEdad.TabIndex = 3;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(12, 91);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(39, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad: ";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(131, 131);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblResultado1
            // 
            lblResultado1.AutoSize = true;
            lblResultado1.Location = new Point(90, 163);
            lblResultado1.Name = "lblResultado1";
            lblResultado1.Size = new Size(153, 15);
            lblResultado1.TabIndex = 5;
            lblResultado1.Text = "Aquí aparecerá el resultado ";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Red;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(239, 196);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblResultado2
            // 
            lblResultado2.AutoSize = true;
            lblResultado2.Location = new Point(90, 178);
            lblResultado2.Name = "lblResultado2";
            lblResultado2.Size = new Size(0, 15);
            lblResultado2.TabIndex = 7;
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurso.Location = new Point(131, 9);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(183, 14);
            lblCurso.TabIndex = 8;
            lblCurso.Text = "Desarrollo de Interfaces – 2.º DAM";
            // 
            // FormularioBienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 231);
            Controls.Add(lblCurso);
            Controls.Add(lblResultado2);
            Controls.Add(btnLimpiar);
            Controls.Add(lblResultado1);
            Controls.Add(btnAceptar);
            Controls.Add(txtEdad);
            Controls.Add(lblEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "FormularioBienvenida";
            Text = "Formulario de bienvenida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private Label lblEdad;
        private Button btnAceptar;
        private Label lblResultado1;
        private Button btnLimpiar;
        private Label lblResultado2;
        private Label lblCurso;
    }
}
