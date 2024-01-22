using System.Text.Json.Serialization;
using CommunityToolkit.Mvvm.ComponentModel;

namespace TodoApp.Shared.Models;

public class ToDoItem : ObservableObject
{
    [JsonPropertyName("id")] public int Id { get; set; }

    [JsonPropertyName("title")] public string Title { get; set; }

    [JsonPropertyName("content")] public string Content { get; set; }

    [JsonPropertyName("updateDate")] public DateTime UpdateDate { get; set; }

    private ICollection<Tag>? _Tags;

    [JsonPropertyName("tags")]
    public ICollection<Tag>? Tags
    {
        get => _Tags;
        set
        {
            SetProperty(ref _Tags, value);
            OnPropertyChanged(nameof(TagsString));
        }
    }

    private string _TagsString;

    public string TagsString
    {
        get => Tags?.Any() == true ? string.Join(',', Tags.Select(x => x.Title)) : "";
        set => SetProperty(ref _TagsString, value);
    }
}