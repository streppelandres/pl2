using System.Text;

namespace ClassLibrary
{
    public class Vendedor
    {
        private string? nombre;
        private List<Publicacion> ventas;

        private Vendedor()
        {
            this.nombre = null;
            this.ventas = new List<Publicacion>();
        }

        public Vendedor(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator +(Vendedor vendedor, Publicacion publicacion)
        {
            if (!publicacion.HayStock) return false;

            vendedor.ventas.Add(publicacion);
            publicacion.Stock--;

            return true;
        }

        public static string ObtenerInformacionDeVentas(Vendedor vendedor)
        {
            StringBuilder sb = new StringBuilder();
            float gananciaTotal = 0f;
            sb.AppendLine(vendedor.nombre);
            sb.AppendLine("--------------------------------------");

            vendedor.ventas.ForEach(venta =>
            {
                sb.AppendLine(venta.ObtenerInformacion());
                sb.AppendLine("--------------------------------------");
                gananciaTotal += venta.Importe;
            });

            sb.AppendLine("Ganancia total:").AppendJoin(" $", gananciaTotal);


            return sb.ToString();
        }
    }
}
