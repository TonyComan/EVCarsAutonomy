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

namespace EVCarsAutonomy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        //Buton minimizare dreapta sus
        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        
        //Eveniment pentru Home
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            AfisareMain.Content = null;
            trymyappTxt.Visibility = Visibility.Collapsed;
            masinutaPoza.Visibility = Visibility.Collapsed;
            textjosdreapta.Visibility = Visibility.Collapsed;
            HomePage homepage = new HomePage();

            AfisareMain.Content = homepage;
        }

        //Eveniment pentru Analyse
        private void AnalyseClickBtn(object sender, RoutedEventArgs e)
        {
            AfisareMain.Content = null;
            trymyappTxt.Visibility = Visibility.Collapsed;
            masinutaPoza.Visibility = Visibility.Collapsed;
            textjosdreapta.Visibility = Visibility.Collapsed;
            AnalyzePage analisepage = new AnalyzePage();

            AfisareMain.Content = analisepage;
        }

        //Eveniment pentru Find
        private void FindClickBtn(object sender, RoutedEventArgs e)
        {
            AfisareMain.Content = null;
            trymyappTxt.Visibility = Visibility.Collapsed;
            masinutaPoza.Visibility = Visibility.Collapsed;
            textjosdreapta.Visibility = Visibility.Collapsed;
            FindPage findPage = new FindPage();

            AfisareMain.Content = findPage;
        }

        //Eveniment Pentru Exit
        private void ExitClickBtn(object sender, RoutedEventArgs e)
        {
           Application.Current.Shutdown();

        }
    }
}
