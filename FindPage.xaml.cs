using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for FindPage.xaml
    /// </summary>
    public partial class FindPage : Page
    {
        public FindPage()
        {
            InitializeComponent();

            
        }

       
        private void textboxMasinaMarca_TextChanged(object sender, TextChangedEventArgs e)
        {

            // validarea cu Regex 
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;

            if (!Regex.IsMatch(text, "^[a-zA-Z0-9\\s]*$"))
            {
                // Interzice caracterele nedorite și afișează un mesaj de eroare
                textBox.Text = Regex.Replace(text, "[^a-zA-Z0-9\\s]", "");
                MessageBox.Show("Introdu Corect Numele si Modelul");
            }


        }
    }
}
