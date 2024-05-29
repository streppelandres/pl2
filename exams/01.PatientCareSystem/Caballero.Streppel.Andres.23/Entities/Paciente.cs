using System.Text;

namespace Entities
{
    public class Paciente : Persona
    {
        private string diagnostico;

        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioResidencia) : base(nombre, apellido, nacimiento, barrioResidencia)
        {
            this.diagnostico = "Paciente curado";
        }

        public string Diagnostico
        {
            get => this.diagnostico;
            set => this.diagnostico = value;
        }

        internal override string FichaExtra()
        {
            return new StringBuilder()
                .AppendLine(this.diagnostico)
                .ToString();
        }
    }
}
