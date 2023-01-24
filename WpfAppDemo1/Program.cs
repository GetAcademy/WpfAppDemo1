using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfAppDemo1
{
    internal class Program
    {
        private static int _count;
        private static Label _label;

        [STAThread]
        public static void Main(string[] args)
        {
            var app = new Application();
            var window = new Window();
            window.Background = new SolidColorBrush(Color.FromRgb(200, 100, 50));

            var panel = new StackPanel();

            var clicker1 = new ClickerPanel();
            var clicker2 = new ClickerPanel();
            var clicker3 = new ClickerPanel();

            panel.Children.Add(clicker1);
            panel.Children.Add(clicker2);
            panel.Children.Add(clicker3);

            //var clicker1 = new Clicker();
            //var clicker2 = new Clicker();
            //var clicker3 = new Clicker();

            //panel.Children.Add(clicker1.Panel);
            //panel.Children.Add(clicker2.Panel);
            //panel.Children.Add(clicker3.Panel);

            window.Content = panel;

            app.Run(window);

            //var app = new Application();
            //var window = new Window();

            //var panel = new StackPanel
            //{
            //    Orientation = Orientation.Horizontal
            //};
            //var button = new Button
            //{
            //    Content = "Trykk her!"
            //};
            //button.Click += ButtonClick;
            //_label = new Label
            //{
            //    Content = "0"
            //};
            //panel.Children.Add(button);
            //panel.Children.Add(_label);

            //window.Content = panel;

            //app.Run(window);
        }

        private static void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count;
        }
    }
}
