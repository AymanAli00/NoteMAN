using System;
using System.Collections.Generic;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NoteMAN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rdhome.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
        }

        private void rdhome_Click_1(object sender, RoutedEventArgs e)
        {
            pageView.Navigate(new System.Uri("Pages/Home.xaml", UriKind.RelativeOrAbsolute));
            rdhome.Background = new SolidColorBrush(Color.FromRgb(203, 232, 246));
            rdadd.Background = new SolidColorBrush(Color.FromRgb(243, 243, 243));
            rdsets.Background = new SolidColorBrush(Color.FromRgb(243, 243, 243));
            //rdadd.ClearValue(Button.BackgroundProperty);
            //rdsets.ClearValue(Button.BackgroundProperty);
            ActivePage.Text = homeLabel.Text;
        }

        public void rdadd_Click(object sender, RoutedEventArgs e)
        {
            pageView.Navigate(new System.Uri("Pages/AddNote.xaml", UriKind.RelativeOrAbsolute));
            rdadd.Background = new SolidColorBrush(Color.FromRgb(203, 232, 246));
            rdsets.Background = new SolidColorBrush(Color.FromRgb(243, 243, 243));
            rdhome.Background = new SolidColorBrush(Color.FromRgb(243, 243, 243));
            ActivePage.Text = addNoteLabel.Text;
        }

        private void close_btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void minimize_btn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void rdsets_Click(object sender, RoutedEventArgs e)
        {
            pageView.Navigate(new System.Uri("Pages/Settings.xaml", UriKind.RelativeOrAbsolute));
            rdsets.Background = new SolidColorBrush(Color.FromRgb(203, 232, 246));
            rdadd.Background = new SolidColorBrush(Color.FromRgb(243, 243, 243));
            rdhome.Background = new SolidColorBrush(Color.FromRgb(243, 243, 243));
            //rdadd.ClearValue(Button.BackgroundProperty);
            //rdhome.ClearValue(Button.BackgroundProperty);
            ActivePage.Text = settingsLabel.Text;
        }
    }
}
