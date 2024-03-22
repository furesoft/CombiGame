using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CombiGame.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using NodeEditor.Model;
using NodeEditor.Mvvm;

namespace CombiGame.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private EditorViewModel? _editor;

    public MainViewModel()
    {
        AddItemCommand = new AddItemCommand(this);

        _editor = new()
        {
            Serializer = new NodeSerializer(typeof(ObservableCollection<>)),
            Factory = new NodeFactory()
        };

        _editor.Templates = new List<INodeTemplate>(_editor.Factory.CreateTemplates());
        _editor.Drawing = _editor.Factory.CreateDrawing();
        _editor.Drawing.SetSerializer(_editor.Serializer);
    }

    public ObservableCollection<Item> Items { get; set; } = new();

    public ICommand AddItemCommand { get; set; }
}