#nullable disable
namespace Tienda.WinForms
{
    partial class LoginForm
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.chkMostrar = new System.Windows.Forms.CheckBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblUsuario
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Location = new System.Drawing.Point(25, 31);
            this.lblUsuario.Size = new System.Drawing.Size(85, 23);
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.TabIndex = 0;
            // txtUsuario
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Location = new System.Drawing.Point(120, 28);
            this.txtUsuario.Size = new System.Drawing.Size(240, 23);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.MaxLength = 30;
            // lblClave
            this.lblClave.Name = "lblClave";
            this.lblClave.Location = new System.Drawing.Point(25, 76);
            this.lblClave.Size = new System.Drawing.Size(90, 23);
            this.lblClave.Text = "Contraseña:";
            this.lblClave.TabIndex = 2;
            // txtClave
            this.txtClave.Name = "txtClave";
            this.txtClave.Location = new System.Drawing.Point(120, 73);
            this.txtClave.Size = new System.Drawing.Size(240, 23);
            this.txtClave.TabIndex = 3;
            this.txtClave.MaxLength = 200;
            this.txtClave.UseSystemPasswordChar = true;
            // chkMostrar
            this.chkMostrar.Name = "chkMostrar";
            this.chkMostrar.Location = new System.Drawing.Point(120, 110);
            this.chkMostrar.Size = new System.Drawing.Size(210, 25);
            this.chkMostrar.Text = "Mostrar contraseña";
            this.chkMostrar.TabIndex = 4;
            this.chkMostrar.CheckedChanged += new System.EventHandler(this.ChkMostrar_CheckedChanged);
            // lblError
            this.lblError.Name = "lblError";
            this.lblError.Location = new System.Drawing.Point(25, 145);
            this.lblError.Size = new System.Drawing.Size(330, 40);
            this.lblError.Text = "";
            this.lblError.TabIndex = 5;
            this.lblError.ForeColor = System.Drawing.Color.Firebrick;
            // btnEntrar
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Location = new System.Drawing.Point(120, 193);
            this.btnEntrar.Size = new System.Drawing.Size(110, 30);
            this.btnEntrar.Text = "Ingresar";
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // btnSalir
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Location = new System.Drawing.Point(245, 193);
            this.btnSalir.Size = new System.Drawing.Size(110, 30);
            this.btnSalir.Text = "Salir";
            this.btnSalir.TabIndex = 7;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.chkMostrar);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnSalir);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 240);
            this.Name = "LoginForm";
            this.Text = "Inicio de sesión";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.AcceptButton = this.btnEntrar;
            this.CancelButton = this.btnSalir;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.CheckBox chkMostrar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSalir;
    }
}
