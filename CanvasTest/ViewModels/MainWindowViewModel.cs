using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Windows.Input;

namespace CanvasTest.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Tile> TileList { get; set; }

        public MainWindowViewModel()
        {
            TileList = new ObservableCollection<Tile>(new List<Tile>
            {
                new Tile(10, 10, 10),
                new Tile(10, 20, 20),
                new Tile(10, 30, 30),
            });
        }

        private Tile _addedTile = new (10, 1, 1);

        [RelayCommand]
        private void AddTile()
        {
            TileList.Add(_addedTile);
        }

        [RelayCommand]
        private void MoveTile()
        {
            _addedTile.TopX += 10;
        }
    }
}
