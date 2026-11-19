using System.Globalization;
using Tienda.Core;
using Tienda.Infrastructure;

namespace Tienda.WinForms;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.GetCultureInfo("es-SV");
        CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("es-SV");
        Application.ThreadException += (_, e) => MessageBox.Show(e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        try
        {
            // Base SQLite: %LOCALAPPDATA%\TiendaElectronica\tienda.db
            var overridePath = Environment.GetEnvironmentVariable("TIENDA_DB_PATH");
            var path = string.IsNullOrWhiteSpace(overridePath)
                ? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TiendaElectronica", "tienda.db") : overridePath;
            var db = new Database(path);
            db.Initialize();
            var auth = new AuthService(new GenericRepository<User>(db));
            using var login = new LoginForm(auth);
            if (login.ShowDialog() != DialogResult.OK || login.Session is null) return;
            using var main = new MainForm(db, login.Session);
            Application.Run(main);
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
    }
}

