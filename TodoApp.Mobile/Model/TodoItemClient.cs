using System.Collections.Generic;
using Microsoft.Maui.Graphics;
using TodoApp.Shared.Models;

namespace TodoApp.Mobile.Model;

public class TodoItemClient : TodoItem
{
    public IEnumerable<string> TagsString { get; set; }
    public Color SoftColor { get; set; }
    public Color SolidColor { get; set; }
}