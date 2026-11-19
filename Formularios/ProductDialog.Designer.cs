#nullable disable
namespace Tienda.WinForms
{
    partial class ProductDialog
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblStock = new System.Windows.Forms.Label();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            this.SuspendLayout();
            // lblCodigo
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Location = new System.Drawing.Point(25, 28);
            this.lblCodigo.Size = new System.Drawing.Size(140, 23);
            this.lblCodigo.Text = "Código / SKU:";
            this.lblCodigo.TabIndex = 0;
            // txtCodigo
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Location = new System.Drawing.Point(180, 25);
            this.txtCodigo.Size = new System.Drawing.Size(280, 23);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.MaxLength = 25;
            // lblNombre
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Location = new System.Drawing.Point(25, 73);
            this.lblNombre.Size = new System.Drawing.Size(140, 23);
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TabIndex = 2;
            // txtNombre
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Location = new System.Drawing.Point(180, 70);
            this.txtNombre.Size = new System.Drawing.Size(280, 23);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.MaxLength = 120;
            // lblCategoria
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Location = new System.Drawing.Point(25, 118);
            this.lblCategoria.Size = new System.Drawing.Size(140, 23);
            this.lblCategoria.Text = "Categoría:";
            this.lblCategoria.TabIndex = 4;
            // txtCategoria
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Location = new System.Drawing.Point(180, 115);
            this.txtCategoria.Size = new System.Drawing.Size(280, 23);
            this.txtCategoria.TabIndex = 5;
            this.txtCategoria.MaxLength = 60;
            // lblPrecio
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Location = new System.Drawing.Point(25, 163);
            this.lblPrecio.Size = new System.Drawing.Size(140, 23);
            this.lblPrecio.Text = "Precio (USD):";
            this.lblPrecio.TabIndex = 6;
            // numPrecio
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Location = new System.Drawing.Point(180, 160);
            this.numPrecio.Size = new System.Drawing.Size(140, 23);
            this.numPrecio.TabIndex = 7;
            this.numPrecio.DecimalPlaces = 2;
            this.numPrecio.Minimum = 0.01M;
            this.numPrecio.Maximum = 1000000M;
            this.numPrecio.Value = 0.01M;
            // lblStock
            this.lblStock.Name = "lblStock";
            this.lblStock.Location = new System.Drawing.Point(25, 208);
            this.lblStock.Size = new System.Drawing.Size(140, 23);
            this.lblStock.Text = "Existencias:";
            this.lblStock.TabIndex = 8;
            // numStock
            this.numStock.Name = "numStock";
            this.numStock.Location = new System.Drawing.Point(180, 205);
            this.numStock.Size = new System.Drawing.Size(140, 23);
            this.numStock.TabIndex = 9;
            this.numStock.Maximum = 1000000M;
            // chkActivo
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Location = new System.Drawing.Point(180, 250);
            this.chkActivo.Size = new System.Drawing.Size(280, 25);
            this.chkActivo.Text = "Producto activo";
            this.chkActivo.TabIndex = 10;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            // lblError
            this.lblError.Name = "lblError";
            this.lblError.Location = new System.Drawing.Point(25, 295);
            this.lblError.Size = new System.Drawing.Size(435, 50);
            this.lblError.Text = "";
            this.lblError.TabIndex = 11;
            this.lblError.ForeColor = System.Drawing.Color.Firebrick;
            // btnGuardar
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Location = new System.Drawing.Point(330, 380);
            this.btnGuardar.Size = new System.Drawing.Size(130, 30);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // btnCancelar
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Location = new System.Drawing.Point(180, 380);
            this.btnCancelar.Size = new System.Drawing.Size(130, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.numPrecio);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.numStock);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 435);
            this.Name = "ProductDialog";
            this.Text = "Producto";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.AcceptButton = this.btnGuardar;
            this.CancelButton = this.btnCancelar;
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
