using System;
using System.Windows.Input;
using CombiGame.Models;
using CombiGame.ViewModels;

namespace CombiGame;

public class AddItemCommand : ICommand
{
    private readonly MainViewModel _mainViewModel;

    public AddItemCommand(MainViewModel mainViewModel)
    {
        _mainViewModel = mainViewModel;
    }

    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        var model = NodeFactory.CreateItem((Item)parameter);
        
        this._mainViewModel.Editor.Drawing.Nodes.Add(model);
    }

    public event EventHandler? CanExecuteChanged;
}