using System;
using System.Collections.Generic;
using System.Text;

namespace MauiAppHotel.Models
{
    public class Quarto
    {
        public required string Descricao { get; set; }
        public double ValorDiariaAdulto { get; set; }
        public double ValorDiariaCrianca { get; set; }

    }
}
