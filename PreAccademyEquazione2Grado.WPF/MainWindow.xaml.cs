using PreAccademyEquazione2Grado.Core;
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

namespace PreAccademyEquazione2Grado.WPF
{

    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Equation eq = new Equation();
        double a;
        double b;
        double c;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void TextBox1a_Text(object sender, RoutedEventArgs e)
        {
            TextBox1a.Text = TextBox1a.Text.Trim();
        }
        private void TextBox1b_Text(object sender, RoutedEventArgs e)
        {
            TextBox1b.Text = TextBox1b.Text.Trim();
        }
        private void TextBox1c_Text(object sender, RoutedEventArgs e)
        {
            TextBox1c.Text = TextBox1c.Text.Trim();
        }
        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {
            a = double.Parse(TextBox1a.Text);
            b = double.Parse(TextBox1b.Text);
            c = double.Parse(TextBox1c.Text);
            var risultato = eq.RisolviEquazioneDiSecondoGrado(a, b, c);
            TextBoxRisultato.Text = (risultato == null) ? "Errore" : (risultato.Length == 1) ? risultato[0].ToString() : $"x1={risultato[0]} x2={risultato[1]}";
        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            TextBoxRisultato.Clear();
            TextBox1a.Clear();
            TextBox1b.Clear();
            TextBox1c.Clear();
        }

        
    }
}
