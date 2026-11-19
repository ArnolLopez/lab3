#nullable disable
namespace Tienda.WinForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.tabPrincipal = new System.Windows.Forms.Panel();
            this.tabProductos = new System.Windows.Forms.Panel();
            this.lblTituloProductos = new System.Windows.Forms.Label();
            this.tabReportes = new System.Windows.Forms.Panel();
            this.lblTituloReportes = new System.Windows.Forms.Label();
            this.tabInventario = new System.Windows.Forms.Panel();
            this.lblTituloInventario = new System.Windows.Forms.Label();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.barraEstado = new System.Windows.Forms.StatusStrip();
            this.lblSesion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.chkInactivos = new System.Windows.Forms.CheckBox();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.dgvProductosColumn0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductosColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductosColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductosColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductosColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductosColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalProductos = new System.Windows.Forms.Label();
            this.lblReportesDesde = new System.Windows.Forms.Label();
            this.dtReportesDesde = new System.Windows.Forms.DateTimePicker();
            this.lblReportesHasta = new System.Windows.Forms.Label();
            this.dtReportesHasta = new System.Windows.Forms.DateTimePicker();
            this.lblProductoReporte = new System.Windows.Forms.Label();
            this.cmbProductoReporte = new System.Windows.Forms.ComboBox();
            this.btnConsultarReporte = new System.Windows.Forms.Button();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.dgvReportesColumn0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReportesColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReportesColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReportesColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalReporte = new System.Windows.Forms.Label();
            this.lblFiltroStock = new System.Windows.Forms.Label();
            this.cmbProductoStock = new System.Windows.Forms.ComboBox();
            this.btnConsultarStock = new System.Windows.Forms.Button();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.dgvInventarioColumn0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInventarioColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInventarioColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInventarioColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInventarioColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInventarioColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalStock = new System.Windows.Forms.Label();
            this.tabPrincipal.SuspendLayout();
            this.tabProductos.SuspendLayout();
            this.tabReportes.SuspendLayout();
            this.tabInventario.SuspendLayout();
            this.menuPrincipal.SuspendLayout();
            this.barraEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            this.colProductoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductoId.Name = "Id";
            this.colProductoId.DataPropertyName = "Id";
            this.colProductoId.Visible = false;
            // tabPrincipal
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Location = new System.Drawing.Point(0, 24);
            this.tabPrincipal.Size = new System.Drawing.Size(1060, 654);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            // tabProductos
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabProductos.Location = new System.Drawing.Point(4, 24);
            this.tabProductos.Size = new System.Drawing.Size(1052, 626);
            this.tabProductos.Text = "Productos";
            this.tabProductos.TabIndex = 3;
            // lblTituloProductos
            this.lblTituloProductos.Name = "lblTituloProductos";
            this.lblTituloProductos.Location = new System.Drawing.Point(20, 18);
            this.lblTituloProductos.Size = new System.Drawing.Size(700, 28);
            this.lblTituloProductos.Text = "Productos";
            this.lblTituloProductos.TabIndex = 4;
            this.lblTituloProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            // tabReportes
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabReportes.Location = new System.Drawing.Point(4, 24);
            this.tabReportes.Size = new System.Drawing.Size(1052, 626);
            this.tabReportes.Text = "Reportes de ventas";
            this.tabReportes.TabIndex = 7;
            // lblTituloReportes
            this.lblTituloReportes.Name = "lblTituloReportes";
            this.lblTituloReportes.Location = new System.Drawing.Point(20, 18);
            this.lblTituloReportes.Size = new System.Drawing.Size(700, 28);
            this.lblTituloReportes.Text = "Reportes de ventas";
            this.lblTituloReportes.TabIndex = 8;
            this.lblTituloReportes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            // tabInventario
            this.tabInventario.Name = "tabInventario";
            this.tabInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInventario.Location = new System.Drawing.Point(4, 24);
            this.tabInventario.Size = new System.Drawing.Size(1052, 626);
            this.tabInventario.Text = "Inventario";
            this.tabInventario.TabIndex = 9;
            // lblTituloInventario
            this.lblTituloInventario.Name = "lblTituloInventario";
            this.lblTituloInventario.Location = new System.Drawing.Point(20, 18);
            this.lblTituloInventario.Size = new System.Drawing.Size(700, 28);
            this.lblTituloInventario.Text = "Inventario";
            this.lblTituloInventario.TabIndex = 10;
            this.lblTituloInventario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            // menuPrincipal
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Size = new System.Drawing.Size(1060, 24);
            this.menuPrincipal.TabIndex = 11;
            this.menuPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            // menuProductos
            this.menuProductos.Name = "menuProductos";
            this.menuProductos.Text = "Productos";
            this.menuProductos.Click += new System.EventHandler(this.Menu_Click);
            // menuReportes
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Text = "Reportes";
            this.menuReportes.Click += new System.EventHandler(this.Menu_Click);
            // menuInventario
            this.menuInventario.Name = "menuInventario";
            this.menuInventario.Text = "Inventario";
            this.menuInventario.Click += new System.EventHandler(this.Menu_Click);
            // barraEstado
            this.barraEstado.Name = "barraEstado";
            this.barraEstado.Location = new System.Drawing.Point(0, 678);
            this.barraEstado.Size = new System.Drawing.Size(1060, 22);
            this.barraEstado.TabIndex = 12;
            // lblSesion
            this.lblSesion.Name = "lblSesion";
            this.lblSesion.Text = "Usuario: sin sesión | Moneda: USD";
            // lblBuscar
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Location = new System.Drawing.Point(20, 67);
            this.lblBuscar.Size = new System.Drawing.Size(65, 23);
            this.lblBuscar.Text = "Buscar:";
            this.lblBuscar.TabIndex = 18;
            // txtBuscar
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Location = new System.Drawing.Point(85, 64);
            this.txtBuscar.Size = new System.Drawing.Size(300, 23);
            this.txtBuscar.TabIndex = 19;
            this.txtBuscar.MaxLength = 120;
            // chkInactivos
            this.chkInactivos.Name = "chkInactivos";
            this.chkInactivos.Location = new System.Drawing.Point(410, 65);
            this.chkInactivos.Size = new System.Drawing.Size(200, 25);
            this.chkInactivos.Text = "Incluir inactivos";
            this.chkInactivos.TabIndex = 20;
            this.chkInactivos.CheckedChanged += new System.EventHandler(this.FiltroProductos_Changed);
            // btnNuevoProducto
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Location = new System.Drawing.Point(20, 105);
            this.btnNuevoProducto.Size = new System.Drawing.Size(145, 30);
            this.btnNuevoProducto.Text = "Nuevo producto";
            this.btnNuevoProducto.TabIndex = 21;
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.BtnNuevoProducto_Click);
            // btnEditarProducto
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Location = new System.Drawing.Point(175, 105);
            this.btnEditarProducto.Size = new System.Drawing.Size(105, 30);
            this.btnEditarProducto.Text = "Editar";
            this.btnEditarProducto.TabIndex = 22;
            this.btnEditarProducto.UseVisualStyleBackColor = true;
            this.btnEditarProducto.Click += new System.EventHandler(this.BtnEditarProducto_Click);
            // btnEliminarProducto
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Location = new System.Drawing.Point(290, 105);
            this.btnEliminarProducto.Size = new System.Drawing.Size(105, 30);
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.TabIndex = 23;
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.BtnEliminarProducto_Click);
            // dgvProductos
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Location = new System.Drawing.Point(20, 150);
            this.dgvProductos.Size = new System.Drawing.Size(1010, 405);
            this.dgvProductos.TabIndex = 24;
            this.dgvProductos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoGenerateColumns = false;
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // dgvProductosColumn0
            this.dgvProductosColumn0.Name = "dgvProductosColumn0";
            this.dgvProductosColumn0.DataPropertyName = "Sku";
            this.dgvProductosColumn0.HeaderText = "Código";
            this.dgvProductosColumn0.Name = "Sku";
            this.dgvProductosColumn0.FillWeight = 70F;
            this.dgvProductosColumn0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // dgvProductosColumn1
            this.dgvProductosColumn1.Name = "dgvProductosColumn1";
            this.dgvProductosColumn1.DataPropertyName = "Name";
            this.dgvProductosColumn1.HeaderText = "Producto";
            this.dgvProductosColumn1.Name = "Name";
            this.dgvProductosColumn1.FillWeight = 180F;
            this.dgvProductosColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // dgvProductosColumn2
            this.dgvProductosColumn2.Name = "dgvProductosColumn2";
            this.dgvProductosColumn2.DataPropertyName = "Category";
            this.dgvProductosColumn2.HeaderText = "Categoría";
            this.dgvProductosColumn2.Name = "Category";
            this.dgvProductosColumn2.FillWeight = 95F;
            this.dgvProductosColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // dgvProductosColumn3
            this.dgvProductosColumn3.Name = "dgvProductosColumn3";
            this.dgvProductosColumn3.DataPropertyName = "Price";
            this.dgvProductosColumn3.HeaderText = "Precio";
            this.dgvProductosColumn3.Name = "Price";
            this.dgvProductosColumn3.FillWeight = 75F;
            this.dgvProductosColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // dgvProductosColumn4
            this.dgvProductosColumn4.Name = "dgvProductosColumn4";
            this.dgvProductosColumn4.DataPropertyName = "Stock";
            this.dgvProductosColumn4.HeaderText = "Stock";
            this.dgvProductosColumn4.Name = "Stock";
            this.dgvProductosColumn4.FillWeight = 55F;
            this.dgvProductosColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // dgvProductosColumn5
            this.dgvProductosColumn5.Name = "dgvProductosColumn5";
            this.dgvProductosColumn5.DataPropertyName = "Status";
            this.dgvProductosColumn5.HeaderText = "Estado";
            this.dgvProductosColumn5.Name = "Status";
            this.dgvProductosColumn5.FillWeight = 95F;
            this.dgvProductosColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // lblTotalProductos
            this.lblTotalProductos.Name = "lblTotalProductos";
            this.lblTotalProductos.Location = new System.Drawing.Point(20, 574);
            this.lblTotalProductos.Size = new System.Drawing.Size(1000, 30);
            this.lblTotalProductos.Text = "0 productos";
            this.lblTotalProductos.TabIndex = 25;
            this.lblTotalProductos.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            // lblReportesDesde
            this.lblReportesDesde.Name = "lblReportesDesde";
            this.lblReportesDesde.Location = new System.Drawing.Point(20, 67);
            this.lblReportesDesde.Size = new System.Drawing.Size(50, 23);
            this.lblReportesDesde.Text = "Desde:";
            this.lblReportesDesde.TabIndex = 35;
            // dtReportesDesde
            this.dtReportesDesde.Name = "dtReportesDesde";
            this.dtReportesDesde.Location = new System.Drawing.Point(75, 64);
            this.dtReportesDesde.Size = new System.Drawing.Size(140, 23);
            this.dtReportesDesde.TabIndex = 36;
            this.dtReportesDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtReportesDesde.CustomFormat = "dd/MM/yyyy";
            // lblReportesHasta
            this.lblReportesHasta.Name = "lblReportesHasta";
            this.lblReportesHasta.Location = new System.Drawing.Point(240, 67);
            this.lblReportesHasta.Size = new System.Drawing.Size(50, 23);
            this.lblReportesHasta.Text = "Hasta:";
            this.lblReportesHasta.TabIndex = 37;
            // dtReportesHasta
            this.dtReportesHasta.Name = "dtReportesHasta";
            this.dtReportesHasta.Location = new System.Drawing.Point(295, 64);
            this.dtReportesHasta.Size = new System.Drawing.Size(140, 23);
            this.dtReportesHasta.TabIndex = 38;
            this.dtReportesHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtReportesHasta.CustomFormat = "dd/MM/yyyy";
            // lblProductoReporte
            this.lblProductoReporte.Name = "lblProductoReporte";
            this.lblProductoReporte.Location = new System.Drawing.Point(460, 67);
            this.lblProductoReporte.Size = new System.Drawing.Size(65, 23);
            this.lblProductoReporte.Text = "Producto:";
            this.lblProductoReporte.TabIndex = 39;
            // cmbProductoReporte
            this.cmbProductoReporte.Name = "cmbProductoReporte";
            this.cmbProductoReporte.Location = new System.Drawing.Point(535, 64);
            this.cmbProductoReporte.Size = new System.Drawing.Size(490, 23);
            this.cmbProductoReporte.TabIndex = 40;
            this.cmbProductoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // btnConsultarReporte
            this.btnConsultarReporte.Name = "btnConsultarReporte";
            this.btnConsultarReporte.Location = new System.Drawing.Point(20, 105);
            this.btnConsultarReporte.Size = new System.Drawing.Size(160, 30);
            this.btnConsultarReporte.Text = "Consultar reporte";
            this.btnConsultarReporte.TabIndex = 41;
            this.btnConsultarReporte.UseVisualStyleBackColor = true;
            this.btnConsultarReporte.Click += new System.EventHandler(this.BtnConsultarReporte_Click);
            // dgvReportes
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.Location = new System.Drawing.Point(20, 150);
            this.dgvReportes.Size = new System.Drawing.Size(1010, 405);
            this.dgvReportes.TabIndex = 43;
            this.dgvReportes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvReportes.AllowUserToAddRows = false;
            this.dgvReportes.AllowUserToDeleteRows = false;
            this.dgvReportes.AutoGenerateColumns = false;
            this.dgvReportes.ReadOnly = true;
            this.dgvReportes.MultiSelect = false;
            this.dgvReportes.RowHeadersVisible = false;
            this.dgvReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // dgvReportesColumn0
            this.dgvReportesColumn0.Name = "dgvReportesColumn0";
            this.dgvReportesColumn0.DataPropertyName = "Sku";
            this.dgvReportesColumn0.HeaderText = "Código";
            this.dgvReportesColumn0.Name = "Sku";
            this.dgvReportesColumn0.FillWeight = 75F;
            this.dgvReportesColumn0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // dgvReportesColumn1
            this.dgvReportesColumn1.Name = "dgvReportesColumn1";
            this.dgvReportesColumn1.DataPropertyName = "ProductName";
            this.dgvReportesColumn1.HeaderText = "Producto vendido";
            this.dgvReportesColumn1.Name = "ProductName";
            this.dgvReportesColumn1.FillWeight = 210F;
            this.dgvReportesColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // dgvReportesColumn2
            this.dgvReportesColumn2.Name = "dgvReportesColumn2";
            this.dgvReportesColumn2.DataPropertyName = "Quantity";
            this.dgvReportesColumn2.HeaderText = "Unidades vendidas";
            this.dgvReportesColumn2.Name = "Quantity";
            this.dgvReportesColumn2.FillWeight = 100F;
            this.dgvReportesColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // dgvReportesColumn3
            this.dgvReportesColumn3.Name = "dgvReportesColumn3";
            this.dgvReportesColumn3.DataPropertyName = "Amount";
            this.dgvReportesColumn3.HeaderText = "Monto acumulado";
            this.dgvReportesColumn3.Name = "Amount";
            this.dgvReportesColumn3.FillWeight = 115F;
            this.dgvReportesColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // lblTotalReporte
            this.lblTotalReporte.Name = "lblTotalReporte";
            this.lblTotalReporte.Location = new System.Drawing.Point(20, 574);
            this.lblTotalReporte.Size = new System.Drawing.Size(1000, 30);
            this.lblTotalReporte.Text = "0 productos vendidos";
            this.lblTotalReporte.TabIndex = 44;
            this.lblTotalReporte.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            // lblFiltroStock
            this.lblFiltroStock.Name = "lblFiltroStock";
            this.lblFiltroStock.Location = new System.Drawing.Point(20, 67);
            this.lblFiltroStock.Size = new System.Drawing.Size(65, 23);
            this.lblFiltroStock.Text = "Producto:";
            this.lblFiltroStock.TabIndex = 45;
            // cmbProductoStock
            this.cmbProductoStock.Name = "cmbProductoStock";
            this.cmbProductoStock.Location = new System.Drawing.Point(95, 64);
            this.cmbProductoStock.Size = new System.Drawing.Size(480, 23);
            this.cmbProductoStock.TabIndex = 46;
            this.cmbProductoStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // btnConsultarStock
            this.btnConsultarStock.Name = "btnConsultarStock";
            this.btnConsultarStock.Location = new System.Drawing.Point(20, 105);
            this.btnConsultarStock.Size = new System.Drawing.Size(145, 30);
            this.btnConsultarStock.Text = "Consultar stock";
            this.btnConsultarStock.TabIndex = 48;
            this.btnConsultarStock.UseVisualStyleBackColor = true;
            this.btnConsultarStock.Click += new System.EventHandler(this.BtnConsultarStock_Click);
            // dgvInventario
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.Location = new System.Drawing.Point(20, 150);
            this.dgvInventario.Size = new System.Drawing.Size(1010, 405);
            this.dgvInventario.TabIndex = 50;
            this.dgvInventario.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.AutoGenerateColumns = false;
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.MultiSelect = false;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // dgvInventarioColumn0
            this.dgvInventarioColumn0.Name = "dgvInventarioColumn0";
            this.dgvInventarioColumn0.DataPropertyName = "Sku";
            this.dgvInventarioColumn0.HeaderText = "Código";
            this.dgvInventarioColumn0.Name = "Sku";
            this.dgvInventarioColumn0.FillWeight = 70F;
            this.dgvInventarioColumn0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // dgvInventarioColumn1
            this.dgvInventarioColumn1.Name = "dgvInventarioColumn1";
            this.dgvInventarioColumn1.DataPropertyName = "Name";
            this.dgvInventarioColumn1.HeaderText = "Producto";
            this.dgvInventarioColumn1.Name = "Name";
            this.dgvInventarioColumn1.FillWeight = 180F;
            this.dgvInventarioColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // dgvInventarioColumn2
            this.dgvInventarioColumn2.Name = "dgvInventarioColumn2";
            this.dgvInventarioColumn2.DataPropertyName = "Category";
            this.dgvInventarioColumn2.HeaderText = "Categoría";
            this.dgvInventarioColumn2.Name = "Category";
            this.dgvInventarioColumn2.FillWeight = 95F;
            this.dgvInventarioColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // dgvInventarioColumn3
            this.dgvInventarioColumn3.Name = "dgvInventarioColumn3";
            this.dgvInventarioColumn3.DataPropertyName = "Price";
            this.dgvInventarioColumn3.HeaderText = "Precio";
            this.dgvInventarioColumn3.Name = "Price";
            this.dgvInventarioColumn3.FillWeight = 75F;
            this.dgvInventarioColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // dgvInventarioColumn4
            this.dgvInventarioColumn4.Name = "dgvInventarioColumn4";
            this.dgvInventarioColumn4.DataPropertyName = "Stock";
            this.dgvInventarioColumn4.HeaderText = "Stock";
            this.dgvInventarioColumn4.Name = "Stock";
            this.dgvInventarioColumn4.FillWeight = 55F;
            this.dgvInventarioColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // dgvInventarioColumn5
            this.dgvInventarioColumn5.Name = "dgvInventarioColumn5";
            this.dgvInventarioColumn5.DataPropertyName = "Status";
            this.dgvInventarioColumn5.HeaderText = "Estado";
            this.dgvInventarioColumn5.Name = "Status";
            this.dgvInventarioColumn5.FillWeight = 95F;
            this.dgvInventarioColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // lblTotalStock
            this.lblTotalStock.Name = "lblTotalStock";
            this.lblTotalStock.Location = new System.Drawing.Point(20, 574);
            this.lblTotalStock.Size = new System.Drawing.Size(1000, 35);
            this.lblTotalStock.Text = "0 productos. Rojo: agotado. Ámbar: 1 a 5 unidades.";
            this.lblTotalStock.TabIndex = 51;
            this.lblTotalStock.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.menuPrincipal.Items.Add(this.menuProductos);
            this.menuPrincipal.Items.Add(this.menuReportes);
            this.menuPrincipal.Items.Add(this.menuInventario);
            this.barraEstado.Items.Add(this.lblSesion);
            this.dgvProductosColumn3.DefaultCellStyle.Format = "C2";
            this.dgvProductosColumn3.DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-US");
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colProductoId, this.dgvProductosColumn0, this.dgvProductosColumn1, this.dgvProductosColumn2, this.dgvProductosColumn3, this.dgvProductosColumn4, this.dgvProductosColumn5 });
            this.dgvReportesColumn3.DefaultCellStyle.Format = "C2";
            this.dgvReportesColumn3.DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-US");
            this.dgvReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvReportesColumn0, this.dgvReportesColumn1, this.dgvReportesColumn2, this.dgvReportesColumn3 });
            this.dgvInventarioColumn3.DefaultCellStyle.Format = "C2";
            this.dgvInventarioColumn3.DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-US");
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvInventarioColumn0, this.dgvInventarioColumn1, this.dgvInventarioColumn2, this.dgvInventarioColumn3, this.dgvInventarioColumn4, this.dgvInventarioColumn5 });
            this.Controls.Add(this.tabPrincipal);
            this.tabPrincipal.Controls.Add(this.tabProductos);
            this.tabProductos.Controls.Add(this.lblTituloProductos);
            this.tabPrincipal.Controls.Add(this.tabReportes);
            this.tabReportes.Controls.Add(this.lblTituloReportes);
            this.tabPrincipal.Controls.Add(this.tabInventario);
            this.tabInventario.Controls.Add(this.lblTituloInventario);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.barraEstado);
            this.tabProductos.Controls.Add(this.lblBuscar);
            this.tabProductos.Controls.Add(this.txtBuscar);
            this.tabProductos.Controls.Add(this.chkInactivos);
            this.tabProductos.Controls.Add(this.btnNuevoProducto);
            this.tabProductos.Controls.Add(this.btnEditarProducto);
            this.tabProductos.Controls.Add(this.btnEliminarProducto);
            this.tabProductos.Controls.Add(this.dgvProductos);
            this.tabProductos.Controls.Add(this.lblTotalProductos);
            this.tabReportes.Controls.Add(this.lblReportesDesde);
            this.tabReportes.Controls.Add(this.dtReportesDesde);
            this.tabReportes.Controls.Add(this.lblReportesHasta);
            this.tabReportes.Controls.Add(this.dtReportesHasta);
            this.tabReportes.Controls.Add(this.lblProductoReporte);
            this.tabReportes.Controls.Add(this.cmbProductoReporte);
            this.tabReportes.Controls.Add(this.btnConsultarReporte);
            this.tabReportes.Controls.Add(this.dgvReportes);
            this.tabReportes.Controls.Add(this.lblTotalReporte);
            this.tabInventario.Controls.Add(this.lblFiltroStock);
            this.tabInventario.Controls.Add(this.cmbProductoStock);
            this.tabInventario.Controls.Add(this.btnConsultarStock);
            this.tabInventario.Controls.Add(this.dgvInventario);
            this.tabInventario.Controls.Add(this.lblTotalStock);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 700);
            this.Name = "MainForm";
            this.Text = "Sistema de ventas - Tienda electrónica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MinimumSize = new System.Drawing.Size(1020, 690);
            this.MainMenuStrip = this.menuPrincipal;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.txtBuscar.TextChanged += new System.EventHandler(this.FiltroProductos_Changed);
            this.dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductos_CellDoubleClick);
            this.dgvProductos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.Stock_DataBindingComplete);
            this.dgvInventario.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.Stock_DataBindingComplete);
            this.tabPrincipal.ResumeLayout(false);
            this.tabPrincipal.PerformLayout();
            this.tabProductos.ResumeLayout(false);
            this.tabProductos.PerformLayout();
            this.tabReportes.ResumeLayout(false);
            this.tabReportes.PerformLayout();
            this.tabInventario.ResumeLayout(false);
            this.tabInventario.PerformLayout();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.barraEstado.ResumeLayout(false);
            this.barraEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colProductoId;
        private System.Windows.Forms.Panel tabPrincipal;
        private System.Windows.Forms.Panel tabProductos;
        private System.Windows.Forms.Label lblTituloProductos;
        private System.Windows.Forms.Panel tabReportes;
        private System.Windows.Forms.Label lblTituloReportes;
        private System.Windows.Forms.Panel tabInventario;
        private System.Windows.Forms.Label lblTituloInventario;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuProductos;
        private System.Windows.Forms.ToolStripMenuItem menuReportes;
        private System.Windows.Forms.ToolStripMenuItem menuInventario;
        private System.Windows.Forms.StatusStrip barraEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblSesion;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.CheckBox chkInactivos;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Button btnEditarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductosColumn0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductosColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductosColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductosColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductosColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductosColumn5;
        private System.Windows.Forms.Label lblTotalProductos;
        private System.Windows.Forms.Label lblReportesDesde;
        private System.Windows.Forms.DateTimePicker dtReportesDesde;
        private System.Windows.Forms.Label lblReportesHasta;
        private System.Windows.Forms.DateTimePicker dtReportesHasta;
        private System.Windows.Forms.Label lblProductoReporte;
        private System.Windows.Forms.ComboBox cmbProductoReporte;
        private System.Windows.Forms.Button btnConsultarReporte;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReportesColumn0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReportesColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReportesColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReportesColumn3;
        private System.Windows.Forms.Label lblTotalReporte;
        private System.Windows.Forms.Label lblFiltroStock;
        private System.Windows.Forms.ComboBox cmbProductoStock;
        private System.Windows.Forms.Button btnConsultarStock;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventarioColumn0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventarioColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventarioColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventarioColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventarioColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventarioColumn5;
        private System.Windows.Forms.Label lblTotalStock;
    }
}
