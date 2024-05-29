namespace ClassLibrary
{
    public class Biografia : Publicacion
    {
        public Biografia(string nombre) : base(nombre)
        {
        }

        public Biografia(string nombre, int stock) : base(nombre, stock)
        {
        }

        public Biografia(string nombre, int stock, float importe) : base(nombre, stock, importe)
        {
        }

        public override bool EsColor
        {
            get => false;
        }

        public override bool HayStock
        {
            get => this.Stock > 0;
        }

        public static explicit operator Biografia(string nombre) => new Biografia(nombre);
    }
}
