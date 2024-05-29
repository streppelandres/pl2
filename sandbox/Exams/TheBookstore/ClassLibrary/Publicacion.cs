using System.Text;

namespace ClassLibrary
{
    public abstract class Publicacion
    {
        private float importe;
        private string nombre;
        private int stock;

        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }

        public Publicacion(string nombre, int stock) : this(nombre)
        {
            this.stock = stock;
        }

        public Publicacion(string nombre, int stock, float importe) : this(nombre, stock)
        {
            this.importe = importe;
        }

        public abstract bool EsColor
        {
            get;
        }

        public virtual bool HayStock
        {
            get => this.stock > 0 && this.importe > 0;
        }

        public float Importe
        {
            get => this.importe;
        }

        public int Stock
        {
            get => this.stock;
            set
            {
                if (value > 0)
                {
                    this.stock = value;
                }
            }
        }

        public string ObtenerInformacion()
        {
            return new StringBuilder()
                .AppendLine($"Nombre: {this.nombre}")
                .AppendLine($"Stock: {this.Stock}")
                .AppendLine($"Es color: {(this.EsColor ? "Si" : "No")}")
                .AppendLine($"Valor: ${this.importe}")
                .ToString();
        }

        public override string ToString() => this.nombre;
    }
}
