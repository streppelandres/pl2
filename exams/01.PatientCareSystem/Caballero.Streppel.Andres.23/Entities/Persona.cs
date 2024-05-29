using System.Text;

namespace Entities
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string? barrioResidencia;
        private DateTime nacimiento;

        public Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }

        public Persona(string nombre, string apellido, DateTime nacimiento, string barrioResidencia) : this(nombre, apellido, nacimiento)
        {
            this.barrioResidencia = barrioResidencia;
        }

        public int Edad
        {
            get => DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1;
        }

        public string NombreCompleto
        {
            get => $"{this.apellido}, {this.nombre}";
        }

        internal abstract string FichaExtra();

        public static string FichaPersonal(Persona persona)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{persona.ToString()}");
            sb.AppendLine($"Edad: {persona.Edad}");


            if (persona is Paciente)
            {
                sb.AppendLine($"Reside en: {persona.barrioResidencia}");
            }

            sb.AppendLine(persona.FichaExtra());

            return sb.ToString();
        }

        public override string ToString() => this.NombreCompleto;
    }
}