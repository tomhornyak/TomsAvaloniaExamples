// Copyright (c) 2026 Thomas F. Hornyak, Tom Hornyak Enterprise LLC

using Avalonia;
using Avalonia.Controls.Shapes;

namespace CanvasTest2
{
    public class CustomLine : Line, ICustomControl
    {
        public static readonly StyledProperty<double> TopYProperty =
    AvaloniaProperty.Register<CustomLine, double>(nameof(TopY), defaultValue: -1);

        public double TopY
        {
            get => (double)GetValue(TopYProperty);
            set => SetValue(TopYProperty, value);
        }

        public static readonly AvaloniaProperty<double> TopXProperty =
            AvaloniaProperty.Register<CustomLine, double>(nameof(TopX), defaultValue: -1);

        public double TopX
        {
            get => (double)GetValue(TopXProperty);
            set => SetValue(TopXProperty, value);
        }

    }
}
