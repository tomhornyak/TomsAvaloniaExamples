using Avalonia.Controls;

namespace CanvasTest2.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetCanvas_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var tilesCanvas = TilesItemControl.ItemsPanelRoot as Canvas;
        }
    }
}