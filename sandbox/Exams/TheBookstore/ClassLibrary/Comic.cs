namespace ClassLibrary
{
    public class Comic : Publicacion
    {
        private bool esColor;

        public Comic(string nombre, bool esColor, int stock, float importe) : base(nombre, stock, importe)
        {
            this.esColor = esColor;
        }

        public override bool EsColor { get => this.esColor; }
    }
}
