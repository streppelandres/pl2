using ClassLibrary;

namespace FrmTest
{
    public partial class FrmTest : Form
    {
        private Vendedor vendedor;

        public FrmTest()
        {
            this.vendedor = new Vendedor("Vendedor 1");
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Tester App";
            this.btnVender.Text = "Vender";
            this.btnSalir.Text = "Salir";
            this.btnVerInforme.Text = "Ver informe";
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);

            this.lstStock.SelectionMode = SelectionMode.One;
            this.lstStock.BeginUpdate();
            this.lstStock.Items.AddRange(new object[] {
                p1, p2, p3, p4, p5
            });
            this.lstStock.EndUpdate();
        }



        private void btnVender_Click(object sender, EventArgs e)
        {
            var item = (Publicacion)this.lstStock.SelectedItems[0];
            System.Diagnostics.Debug.WriteLine(item.ToString());

            bool result = this.vendedor + item;
            MessageBox.Show(result ? "Venta realizada" : "No se pudo realizar al venta");
        }

        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            string informe = Vendedor.ObtenerInformacionDeVentas(this.vendedor);
            this.rtbInforme.Text = informe;
        }

        private void FrmTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Estas seguro de salir?",
                "Form Closing",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}