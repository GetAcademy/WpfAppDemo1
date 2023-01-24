using System.Windows.Controls;
using System.Windows;
using System;

namespace WpfAppDemo1
{
    internal class Clicker
    {
        private  int _count;
        private  Label _label;
        public StackPanel Panel { get; }

        public Clicker()
        {
            Panel = new StackPanel
            {
                Orientation = Orientation.Horizontal
            };
            var button = new Button
            {
                Content = "Trykk her!"
            };
            button.Click += ButtonClick;
            _label = new Label
            {
                Content = "0"
            };
            Panel.Children.Add(button);
            Panel.Children.Add(_label);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count;
        }
    }
}
