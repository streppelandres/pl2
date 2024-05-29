using System.Text;

namespace Entities
{
    public class PersonalMedico : Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esRedisente) : base(nombre, apellido, nacimiento)
        {
            this.esResidente = esRedisente;
            this.consultas = new List<Consulta>();
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Finalizo la residencia {(this.esResidente ? "Si" : "No")}");
            sb.AppendLine("ATENCIONES:");

            foreach (var consulta in consultas)
            {
                sb.AppendLine(consulta.ToString());
            }

            return sb.ToString();
        }

        public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        {
            Consulta consulta = new Consulta(DateTime.Now, paciente);
            doctor.consultas.Add(consulta);
            return consulta;
        }
    }
}