using Avalonia.Collections;
using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CanvasTest2.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public AvaloniaList<Tile> TileList { get; set; } = new();

        private List<Tile>  _list = new();
        public MainWindowViewModel()
        {
            TileList.CollectionChanged += TileList_CollectionChanged;
            _list = new List<Tile>
            {
                new(-1, -1, "Tile 1"),
                new(-1, -1, "Tile 2"),
                new(-1, -1, "Tile 3"),
            };
            TileList.Add(_list[0]);
            _list[0].TopX = 10;
            _list[0].TopY = 10;

            TileList.Add(_list[1]);
            _list[1].TopX = 30;
            _list[1].TopY = 30;

            TileList.Add(_list[2]);
            _list[2].TopX = 50;
            _list[2].TopY = 50;
        }

        private void TileList_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Debug.WriteLine($"Collection changed: Action={e.Action}, Count={TileList.Count}");
        }

        private Tile _addedTile = new(-1, -1, "Added");

        [RelayCommand]
        private void AddTile()
        {
            _addedTile.PropertyChanged+= (s, e) =>
            {
                {
                    Debug.WriteLine($"Property {e.Property.Name} changed. New values: TopX={_addedTile.TopX}, TopY={_addedTile.TopY}");
                }
            };
            TileList.Add(_addedTile);
            _addedTile.TopX = 1;
            _addedTile.TopY = 1;
        }

        [RelayCommand]
        private void MoveTile()
        {
            _addedTile.TopX += 10;
        }
    }    
}
