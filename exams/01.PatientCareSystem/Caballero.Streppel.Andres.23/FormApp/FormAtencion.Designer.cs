namespace FormApp
{
    partial class FormAtencion
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
            btnSalir = new Button();
            lstPacientes = new ListBox();
            rtbInfoMedico = new RichTextBox();
            lstMedicos = new ListBox();
            label2 = new Label();
            label1 = new Label();
            btnAtender = new Button();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(676, 475);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(108, 62);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(342, 26);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(328, 259);
            lstPacientes.TabIndex = 14;
            // 
            // rtbInfoMedico
            // 
            rtbInfoMedico.Location = new Point(8, 291);
            rtbInfoMedico.Name = "rtbInfoMedico";
            rtbInfoMedico.Size = new Size(662, 246);
            rtbInfoMedico.TabIndex = 13;
            rtbInfoMedico.Text = "";
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(8, 26);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(328, 259);
            lstMedicos.TabIndex = 12;
            lstMedicos.SelectedIndexChanged += lstMedicos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 8);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 11;
            label2.Text = "Pacientes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 10;
            label1.Text = "Medicos";
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(676, 26);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(108, 62);
            btnAtender.TabIndex = 9;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 547);
            Controls.Add(btnSalir);
            Controls.Add(lstPacientes);
            Controls.Add(rtbInfoMedico);
            Controls.Add(lstMedicos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAtender);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private ListBox lstPacientes;
        private RichTextBox rtbInfoMedico;
        private ListBox lstMedicos;
        private Label label2;
        private Label label1;
        private Button btnAtender;
    }
}