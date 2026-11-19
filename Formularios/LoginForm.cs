using Tienda.Core;

namespace Tienda.WinForms
{
    public partial class LoginForm : Form
    {
        private AuthService? auth;
        public Session? Session { get; private set; }

        // El diseñador utiliza este constructor sin acceder a la base de datos.
        public LoginForm() { InitializeComponent(); }
        public LoginForm(AuthService auth) : this() { this.auth = auth; }

        private void BtnEntrar_Click(object? sender, EventArgs e)
        {
            if (auth == null) return;
            try
            {
                Session = auth.Login(txtUsuario.Text, txtClave.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ArgumentException ex) { lblError.Text = ex.Message; txtClave.Clear(); txtClave.Focus(); }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void ChkMostrar_CheckedChanged(object? sender, EventArgs e) { txtClave.UseSystemPasswordChar = !chkMostrar.Checked; }
    }
}
