using System;
using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();
    }

    private async void OnProximoClicked(object sender, EventArgs e)
    {
        // Capturar valores do formulário
        var dataEntrada = DateEntrada.Date;
        var dataSaida = DateSaida.Date;
        int adultos = int.TryParse(EntryAdultos.Text, out var a) ? a : 0;
        int criancas = int.TryParse(EntryCriancas.Text, out var c) ? c : 0;

        // Montar query string com encoding
        var entradaStr = Uri.EscapeDataString(dataEntrada.ToString("o"));
        var saidaStr = Uri.EscapeDataString(dataSaida.ToString("o"));
        var query = $"?entrada={entradaStr}&saida={saidaStr}&adultos={adultos}&criancas={criancas}";

        // Navegar via Shell para a rota registrada
        await Shell.Current.GoToAsync($"{nameof(HospedagemContratada)}{query}");
    }
}