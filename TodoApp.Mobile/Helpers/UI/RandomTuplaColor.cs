using System;
using System.Collections.Generic;
using Microsoft.Maui.Graphics;

namespace TodoApp.Mobile.Helpers.UI;

public static class RandomTuplaColor
{
    public static (Color, Color) GetRandomTuplaColor()
    {
        var random = new Random();
        var listOfTupla = new List<(string, string)>
        {
            ("#EEF9FF", "#BDE3FC"),
            ("#F7F1FE", "#D9BAFC"),
            ("#FFF2EF", "#FBA999"),
            ("#E6EBFF", "#AFC1FD"),
            ("#FFFBEF", "#FCE8A0"),
        };
        var randomIndex = random.Next(0, listOfTupla.Count - 1);
        var randomTupla = listOfTupla[randomIndex];
        return (Color.FromArgb(randomTupla.Item1), Color.FromArgb(randomTupla.Item2));
    }
}