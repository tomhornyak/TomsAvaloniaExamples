using Avalonia.Collections;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;

namespace CanvasTest2.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty]
        public AvaloniaList<Tile> tileList;

        public MainWindowViewModel()
    => this.TileList = [new(60, 10, "Tile 1"), new(30, 40, "Tile 2"), new(10, 80, "Tile 3"),];

        [RelayCommand]
        private void AddTile() => this.TileList.Add(new Tile(50, 50, "Hello World!"));

        [RelayCommand]
        private void MoveTile() => this.TileList[^1].TopX += 40;
    }
}
