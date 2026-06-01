using Microsoft.Maui.Controls;
using MauiAppHotel.Views;

namespace MauiAppHotel;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Registrar rota para HospedagemContratada
        Routing.RegisterRoute(nameof(HospedagemContratada), typeof(HospedagemContratada));
    }
}
