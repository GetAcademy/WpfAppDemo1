using System.Windows.Controls;
using System.Windows;

namespace WpfAppDemo1
{
    internal class ClickerPanel : StackPanel
    {
        private int _count;
        private Label _label;

        public ClickerPanel()
        {
            Orientation = Orientation.Horizontal;
            var button = new Button
            {
                Content = "Trykk her!"
            };
            button.Click += ButtonClick;
            _label = new Label
            {
                Content = "0"
            };
            Children.Add(button);
            Children.Add(_label);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count;
        }
    }
}
