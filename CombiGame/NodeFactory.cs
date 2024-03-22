using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using CombiGame.Models;
using NodeEditor.Model;
using NodeEditor.Mvvm;

namespace CombiGame;

public class NodeFactory : INodeFactory
{
    public IDrawingNode CreateDrawing(string? name = null)
    {
        var drawing = new DrawingNodeViewModel
        {
            Name = name,
            X = 0,
            Y = 0,
            Width = 900,
            Height = 600,
            Nodes = new ObservableCollection<INode>(),
            Connectors = new ObservableCollection<IConnector>(),
            EnableMultiplePinConnections = true,
            EnableSnap = false,
            SnapX = 15.0,
            SnapY = 15.0,
            EnableGrid = true,
            GridCellWidth = 15.0,
            GridCellHeight = 15.0
        };


        return drawing;
    }

    public IList<INodeTemplate> CreateTemplates()
    {
        return new ObservableCollection<INodeTemplate>
        {
            new NodeTemplateViewModel
            {
                Title = ItemDefinitions.PLANT.Name,
                Template = CreateItem(ItemDefinitions.PLANT),
                Preview = null
            }
        };
    }


    public static INode CreateItem(Item item)
    {
        var node = new NodeViewModel
        {
            Name = item.Name,
            X = 150,
            Y = 150,
            Width = 50,
            Height = 50,
            Pins = new ObservableCollection<IPin>(),
            Content = new Button {Content = item}
        };

        node.Created += (sender, args) =>
        {
            node.Move(Random.Shared.Next(150), Random.Shared.Next(150));
        };

        return node;
    }

    internal static IConnector CreateConnector(IPin? start, IPin? end)
    {
        return new ConnectorViewModel
        {
            Start = start,
            End = end
        };
    }
}