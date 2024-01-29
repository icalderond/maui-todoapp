using Microsoft.Maui.Controls;
using TodoApp.Mobile.Helpers.Handlers;

namespace TodoApp.Mobile.UIControls;

public class BorderlessEntry : Entry
{
    public BorderlessEntry()
    {
        ModifyEntry();
    }

    private void ModifyEntry()
    {
        FormHandler.RemoveEntryBorders();
    }
}