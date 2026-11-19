using Tienda.Core;

namespace Tienda.WinForms
{
    public partial class ProductDialog : Form
    {
        private ProductService? catalog;
        private long productId;
        public ProductDialog() { InitializeComponent(); }
        public ProductDialog(ProductService catalog, Product? product = null) : this()
        {
            this.catalog = catalog;
            Text = product == null ? "Nuevo producto" : "Editar producto";
            if (product == null) return;
            productId = product.Id;
            txtCodigo.Text = product.Sku; txtNombre.Text = product.Name; txtCategoria.Text = product.Category;
            numPrecio.Value = product.PriceCents / 100m; numStock.Value = product.Stock; chkActivo.Checked = product.Active;
        }
        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            if (catalog == null) return;
            try
            {
                catalog.Save(new Product { Id = productId, Sku = txtCodigo.Text, Name = txtNombre.Text, Category = txtCategoria.Text,
                    PriceCents = checked((long)decimal.Round(numPrecio.Value * 100, 0, MidpointRounding.AwayFromZero)), Stock = (int)numStock.Value, Active = chkActivo.Checked });
                DialogResult = DialogResult.OK; Close();
            }
            catch (ArgumentException ex) { lblError.Text = ex.Message; }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }
}
