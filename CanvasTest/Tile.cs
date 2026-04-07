using CommunityToolkit.Mvvm.ComponentModel;

namespace CanvasTest
{
    public partial class Tile : ObservableObject 
    {
        [ObservableProperty]
        private int _size;

        [ObservableProperty]
        public int _topX;

        [ObservableProperty]
        public int _topY;

        public Tile(int size, int topX, int topY)
        {
            Size = size;
            TopX = topX;
            TopY = topY;
        }
    }
}
