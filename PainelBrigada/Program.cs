using PainelBrigada.Forms;

namespace PainelBrigada;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new FormLogin());
    }
}
