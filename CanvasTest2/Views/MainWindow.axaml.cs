using Avalonia.Controls;
using System.Diagnostics;

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
            Debug.WriteLine($"Canvas found: Children count: {tilesCanvas?.Children.Count}");
            foreach (var child in tilesCanvas?.Children ?? [])
            {
                Debug.WriteLine($"Child: {child}");
            }

        }
    }
}