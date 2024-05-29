namespace Entities
{
    public class Consulta
    {
        private DateTime fecha;
        private Paciente paciente;

        private DateTime Fecha { get => this.fecha; }
        private Paciente Paciente { get => this.paciente; }

        public Consulta(DateTime fecha, Paciente paciente)
        {
            this.fecha = fecha;
            this.paciente = paciente;
        }

        public override string ToString() => $"{this.Fecha} se ha atendido a {this.Paciente.ToString()}";
    }
}
