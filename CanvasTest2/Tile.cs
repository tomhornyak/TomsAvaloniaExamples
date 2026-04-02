using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace CanvasTest2
{
    public partial class Tile : TextBox
    {
        public static readonly StyledProperty<double> TopXProperty =
        AvaloniaProperty.Register<Tile, double>(nameof(TopX), defaultValue: -1);

        public double TopX
        {
            get => (double)GetValue(TopXProperty);
            set => SetValue(TopXProperty, value);
        }

        public static readonly StyledProperty<double> TopYProperty =
            AvaloniaProperty.Register<Tile, double>(nameof(TopY), defaultValue: -1);

        public double TopY
        {
            get => (double)GetValue(TopYProperty);
            set => SetValue(TopYProperty, value);
        }

        public Tile()
        {
            Height = 10;
            Width = 30;
            Background = new SolidColorBrush(Colors.Red);
        }

        public Tile(int topX, int topY, string text) : this()
        {
            {
                TopX = topX;
                TopY = topY;
                Text = text;
            }
        }
    }
}
