using System.Collections.ObjectModel;
using System.Windows.Input;
using CombiGame.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using NodeEditor.Mvvm;

namespace CombiGame.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private EditorViewModel? _editor;

    public MainViewModel()
    {
        AddItemCommand = new AddItemCommand(this);

        Editor = new()
        {
            Factory = new NodeFactory()
        };
        Editor.Templates = Editor.Factory.CreateTemplates();

        Editor.Drawing = Editor.Factory.CreateDrawing();
        Editor.Drawing.SetSerializer(Editor.Serializer);

        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.PLANT);
        Items.Add(ItemDefinitions.WATER);
    }

    public ObservableCollection<Item> Items { get; set; } = new();

    public ICommand AddItemCommand { get; set; }
}