using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Szamologep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        String? eredmeny;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Tetszoleges(object sender, RoutedEventArgs e)
        {
            eredmeny = $"{txtAszam.Text} + {txtBszam.Text} = {Convert.ToDouble(txtAszam.Text) + Convert.ToDouble(txtBszam.Text)}";
            MessageBox.Show("Az összeadás eredménye: " + eredmeny);
            lbEredmenyek.Items.Add(eredmeny);
        }

        private void btnKivon_Click(object sender, RoutedEventArgs e)
        {
            eredmeny = $"{txtAszam.Text} - {txtBszam.Text} = {Convert.ToDouble(txtAszam.Text) - Convert.ToDouble(txtBszam.Text)}";
            MessageBox.Show("A kivonás eredménye: " + eredmeny);
            lbEredmenyek.Items.Add(eredmeny);
            //this.Width *=2;
        }

        private void btnSzoroz_Click(object sender, RoutedEventArgs e)
        {
            eredmeny = $"{txtAszam.Text} * {txtBszam.Text} = {Convert.ToDouble(txtAszam.Text) * Convert.ToDouble(txtBszam.Text)}";
            MessageBox.Show("A szorzás eredménye: " + eredmeny);
            lbEredmenyek.Items.Add(eredmeny);

        }

        private void btnOszt_Click(object sender, RoutedEventArgs e)
        {
            if(Convert.ToDouble(txtBszam.Text) == 0)
            {
                MessageBox.Show("0-val nem osztunk.");
            }
            else
            {
                eredmeny = $"{txtAszam.Text} / {txtBszam.Text} = {Convert.ToDouble(txtAszam.Text) / Convert.ToDouble(txtBszam.Text)}";
                MessageBox.Show("Az osztás eredménye: " + eredmeny);
                lbEredmenyek.Items.Add(eredmeny);
            }
        }

        private void lbEredmenyek_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            //Szedjük ki azt az itemet, amelyre kattintottuk
            ListBoxItem? item = ItemsControl.ContainerFromElement(sender as ListBox, e.OriginalSource as DependencyObject) as ListBoxItem;
            if(item != null)
            {
                //formáljuk stringként és törjük fel
                string[]? splitted = item.Content.ToString()!.Split(" ");
                txtAszam.Text = splitted[0];
                txtBszam.Text = splitted[2];

            }
        }
    }
}
