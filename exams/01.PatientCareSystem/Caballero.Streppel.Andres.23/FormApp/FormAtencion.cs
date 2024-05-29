using Entities;

namespace FormApp
{
    public partial class FormAtencion : Form
    {
        public FormAtencion()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Andrés Caballero Streppel | Atención de pacientes";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lstMedicos.SelectionMode = SelectionMode.One;
            this.lstMedicos.Items.Add(new PersonalMedico("Gustavo", "Rivas", new DateTime(1999, 12, 12), false));
            this.lstMedicos.Items.Add(new PersonalMedico("Lautaro", "Galarza", new DateTime(1951, 11, 12), true));


            this.lstPacientes.SelectionMode = SelectionMode.One;
            this.lstPacientes.Items.Add(new Paciente("Mathias", "Bustamante", new DateTime(1998, 6, 16), "Tigre"));
            this.lstPacientes.Items.Add(new Paciente("Lucas", "Ferrini", new DateTime(1989, 1, 21), "DF"));
            this.lstPacientes.Items.Add(new Paciente("Lucas", "Rodriguez", new DateTime(1912, 12, 12), "LaBoca"));
            this.lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellin"));
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (this.lstMedicos.SelectedItems.Count == 0 || this.lstPacientes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un medico y un paciente para poder continuar", "Error en los datos");
                return;
            }

            PersonalMedico medico = (PersonalMedico)this.lstMedicos.SelectedItems[0];
            Paciente paciente = (Paciente)this.lstPacientes.SelectedItems[0];

            Consulta consulta = medico + paciente;

            MessageBox.Show(consulta.ToString(), "Atención finalizada");

            this.RefreshRtbInfoMedicoText();

            this.lstMedicos.ClearSelected();
            this.lstPacientes.ClearSelected();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstMedicos.SelectedItems.Count > 0)
            {
                this.RefreshRtbInfoMedicoText();
            }
        }

        private void RefreshRtbInfoMedicoText()
        {
            PersonalMedico medico = (PersonalMedico)this.lstMedicos.SelectedItems[0];
            this.rtbInfoMedico.Text = Persona.FichaPersonal(medico);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Estas seguro de salir?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
