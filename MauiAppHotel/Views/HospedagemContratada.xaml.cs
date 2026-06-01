using System;
using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views;

[QueryProperty("Entrada", "entrada")]
[QueryProperty("Saida", "saida")]
[QueryProperty("Adultos", "adultos")]
[QueryProperty("Criancas", "criancas")]
public partial class HospedagemContratada : ContentPage
{
    // Propriedades que receberão os valores via query
    public string Entrada { get => entradaStr; set { entradaStr = value; OnQueryReceived(); } }
    public string Saida { get => saidaStr; set { saidaStr = value; OnQueryReceived(); } }
    public string Adultos { get => adultosStr; set { adultosStr = value; OnQueryReceived(); } }
    public string Criancas { get => criancasStr; set { criancasStr = value; OnQueryReceived(); } }

    private string entradaStr;
    private string saidaStr;
    private string adultosStr;
    private string criancasStr;

    public HospedagemContratada()
    {
        InitializeComponent();
    }

    // Mantém o construtor compatível com navegação direta
    public HospedagemContratada(DateTime entrada, DateTime saida, int adultos, int criancas) : this()
    {
        LabelEntrada.Text = entrada.ToString("dd/MM/yyyy");
        LabelSaida.Text = saida.ToString("dd/MM/yyyy");
        LabelAdultos.Text = adultos.ToString();
        LabelCriancas.Text = criancas.ToString();
    }

    private void OnQueryReceived()
    {
        // Se todos os parâmetros foram preenchidos, converte e atualiza UI
        if (!string.IsNullOrEmpty(entradaStr) && !string.IsNullOrEmpty(saidaStr)
            && !string.IsNullOrEmpty(adultosStr) && !string.IsNullOrEmpty(criancasStr))
        {
            if (DateTime.TryParse(entradaStr, null, System.Globalization.DateTimeStyles.RoundtripKind, out var entrada) &&
                DateTime.TryParse(saidaStr, null, System.Globalization.DateTimeStyles.RoundtripKind, out var saida) &&
                int.TryParse(adultosStr, out var adultos) &&
                int.TryParse(criancasStr, out var criancas))
            {
                LabelEntrada.Text = entrada.ToString("dd/MM/yyyy");
                LabelSaida.Text = saida.ToString("dd/MM/yyyy");
                LabelAdultos.Text = adultos.ToString();
                LabelCriancas.Text = criancas.ToString();
            }
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
        
            Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");
        }
    }
}