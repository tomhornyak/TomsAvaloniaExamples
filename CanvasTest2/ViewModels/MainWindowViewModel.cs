using Avalonia;
using Avalonia.Collections;
using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CanvasTest2.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty]
        public AvaloniaList<ICustomControl> tileList = new();

        public MainWindowViewModel()
        {
            TileList.Add(new Tile(70, 10, "Tile 1"));
            TileList.Add(new Tile(40, 50, "Tile 2"));
            TileList.Add(new Tile(10, 90, "Tile 3"));
            var line = new CustomLine
            {
                StartPoint = new Point(0, 0),
                EndPoint = new Point(100,100),
                Stroke = Brushes.Green,
                StrokeThickness = 3
            };
            TileList.Add(line);

        }

        [RelayCommand]
        private void AddTile() => this.TileList.Add(new Tile(50, 150, "Hello World!"));

        [RelayCommand]
        private void MoveTile() => this.TileList[^1].TopX += 40;
    }
}
