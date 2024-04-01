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
using LabPW3.DataSet1TableAdapters;

namespace LabPW3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GamesTableAdapter g = new GamesTableAdapter(); 
        public MainWindow()
        {
            InitializeComponent();
            dg.ItemsSource = g.GetFullInfo();


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dg.Columns[0].Visibility = Visibility.Collapsed;
            dg.Columns[2].Visibility = Visibility.Collapsed;
            dg.Columns[3].Visibility = Visibility.Collapsed;

            dg.Columns[1].Header = "Название игры";
            dg.Columns[4].Header = "Жанр";
            dg.Columns[5].Header = "Описание жанра";
        }
    }
}
