using MercadinhoBrasil.Telas;

namespace MercadinhoBrasil;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        Application.Run(new FormPrincipal());
    }
}
