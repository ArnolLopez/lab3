using Tienda.Core;
using Tienda.Infrastructure;

namespace Tienda.WinForms
{
    public partial class MainForm : Form
    {
        private IRepository<Product>? products;
        private ProductService? catalog;
        private ISalesRepository? reports;
        private Session? session;
        private bool ready;

        public MainForm() { InitializeComponent(); }
        public MainForm(Database database, Session session) : this()
        {
            products = new GenericRepository<Product>(database);
            catalog = new ProductService(products);
            reports = new SalesRepository(database);
            this.session = session;
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            if (catalog == null || session == null) return;
            try
            {
                lblSesion.Text = $"Usuario: {session.Username} - {session.FullName} | Moneda: USD";
                dtReportesDesde.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                dtReportesHasta.Value = DateTime.Today;
                LoadFilters();
                ready = true;
                Navigate(tabProductos);
            }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void LoadFilters()
        {
            if (catalog == null) return;
            var choices = new List<ProductChoice> { new ProductChoice(null, "Todos los productos") };
            choices.AddRange(catalog.List(includeInactive: true).Select(p => new ProductChoice(p.Id, p.Sku + " - " + p.Name)));
            var reportId = (cmbProductoReporte.SelectedItem as ProductChoice)?.Id;
            var stockId = (cmbProductoStock.SelectedItem as ProductChoice)?.Id;
            cmbProductoReporte.DisplayMember = nameof(ProductChoice.Text);
            cmbProductoStock.DisplayMember = nameof(ProductChoice.Text);
            cmbProductoReporte.DataSource = choices.ToList();
            cmbProductoStock.DataSource = choices.ToList();
            cmbProductoReporte.SelectedItem = choices.FirstOrDefault(p => p.Id == reportId) ?? choices[0];
            cmbProductoStock.SelectedItem = choices.FirstOrDefault(p => p.Id == stockId) ?? choices[0];
        }

        private void Navigate(Panel section)
        {
            section.BringToFront();
            if (!ready) return;
            if (section == tabProductos) LoadProducts();
            else if (section == tabReportes) LoadReport();
            else if (section == tabInventario) LoadStock();
        }

        private void LoadProducts()
        {
            if (catalog == null) return;
            var list = catalog.List(txtBuscar.Text, chkInactivos.Checked);
            dgvProductos.DataSource = list.Select(p => new
            {
                p.Id, p.Sku, p.Name, p.Category, Price = p.PriceCents / 100m, p.Stock,
                Status = !p.Active ? "Inactivo" : p.Stock == 0 ? "Sin existencias" : p.Stock <= 5 ? "Stock crítico" : "Disponible"
            }).ToList();
            lblTotalProductos.Text = $"{list.Count} productos. Doble clic para editar. Stock crítico: 5 unidades o menos.";
        }

        private Product SelectedProduct()
        {
            if (products == null || dgvProductos.CurrentRow == null) throw new ArgumentException("Selecciona un producto.");
            long id = Convert.ToInt64(dgvProductos.CurrentRow.Cells["Id"].Value);
            return products.GetById(id) ?? throw new ArgumentException("El producto ya no existe.");
        }

        private void BtnNuevoProducto_Click(object? sender, EventArgs e)
        {
            if (catalog == null) return;
            try
            {
                using var form = new ProductDialog(catalog);
                if (form.ShowDialog(this) == DialogResult.OK) { LoadProducts(); LoadFilters(); }
            }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void BtnEditarProducto_Click(object? sender, EventArgs e)
        {
            if (catalog == null) return;
            try
            {
                using var form = new ProductDialog(catalog, SelectedProduct());
                if (form.ShowDialog(this) == DialogResult.OK) { LoadProducts(); LoadFilters(); }
            }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void BtnEliminarProducto_Click(object? sender, EventArgs e)
        {
            if (catalog == null) return;
            try
            {
                var product = SelectedProduct();
                if (MessageBox.Show(this, $"¿Eliminar {product.Name}?", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                catalog.Delete(product.Id);
                LoadProducts(); LoadFilters();
            }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void LoadReport()
        {
            if (reports == null) return;
            var rows = reports.Summary(dtReportesDesde.Value, dtReportesHasta.Value, (cmbProductoReporte.SelectedItem as ProductChoice)?.Id);
            dgvReportes.DataSource = rows.Select(r => new { r.Sku, r.ProductName, r.Quantity, Amount = r.AmountCents / 100m }).ToList();
            lblTotalReporte.Text = $"{rows.Count} productos vendidos. Unidades: {rows.Sum(r => r.Quantity)}. Importe: {(rows.Sum(r => r.AmountCents) / 100m).ToString("C2")}";
        }

        private void LoadStock()
        {
            if (catalog == null) return;
            var id = (cmbProductoStock.SelectedItem as ProductChoice)?.Id;
            var rows = catalog.List(includeInactive: true).Where(p => !id.HasValue || p.Id == id).ToList();
            dgvInventario.DataSource = rows.Select(p => new
            {
                p.Sku, p.Name, p.Category, Price = p.PriceCents / 100m, p.Stock,
                Status = !p.Active ? "Inactivo" : p.Stock == 0 ? "Sin existencias" : p.Stock <= 5 ? "Stock crítico" : "Disponible"
            }).ToList();
            lblTotalStock.Text = $"{rows.Count} productos. {rows.Sum(p => (long)p.Stock)} unidades. Valor: {(rows.Sum(p => checked(p.PriceCents * p.Stock)) / 100m).ToString("C2")}. Rojo: agotado. Ámbar: 1 a 5.";
        }

        private void FiltroProductos_Changed(object? sender, EventArgs e)
        {
            if (!ready) return;
            try { LoadProducts(); }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void BtnConsultarReporte_Click(object? sender, EventArgs e)
        {
            try { LoadReport(); }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void BtnConsultarStock_Click(object? sender, EventArgs e)
        {
            try { LoadStock(); }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void Stock_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (sender is not DataGridView grid) return;
            foreach (DataGridViewRow row in grid.Rows)
            {
                int stock = Convert.ToInt32(row.Cells["Stock"].Value);
                Color color = stock == 0 ? Color.MistyRose : stock <= 5 ? Color.Khaki : Color.Empty;
                row.DefaultCellStyle.BackColor = color;
                row.DefaultCellStyle.SelectionBackColor = color;
                row.DefaultCellStyle.SelectionForeColor = stock <= 5 ? SystemColors.ControlText : Color.Empty;
            }
        }
        private void DgvProductos_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) BtnEditarProducto_Click(sender, EventArgs.Empty);
        }
        private void Menu_Click(object? sender, EventArgs e)
        {
            try
            {
                if (sender == menuProductos) Navigate(tabProductos);
                else if (sender == menuReportes) Navigate(tabReportes);
                else if (sender == menuInventario) Navigate(tabInventario);
            }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private sealed record ProductChoice(long? Id, string Text);
    }
}
