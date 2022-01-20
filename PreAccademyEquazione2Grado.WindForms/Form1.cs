

using PreAccademyEquazione2Grado.Core;

namespace PreAccademyEquazione2Grado.WindForms
{
    public partial class Form1 : Form
    {
        Equation eq = new Equation();
        double a;
        double b;
        double c;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1a_TextChanged(object sender, EventArgs e)
        {
            textBox1a.Text = textBox1a.Text.Trim();
        }

        private void textBox1b_TextChanged(object sender, EventArgs e)
        {
            textBox1b.Text = textBox1b.Text.Trim();
        }

        private void textBox1c_TextChanged(object sender, EventArgs e)
        {
            textBox1c.Text = textBox1c.Text.Trim();
        }
        private void btnCalcola_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1a.Text);
            b = double.Parse(textBox1b.Text);
            c = double.Parse(textBox1c.Text);
            var risultato = eq.RisolviEquazioneDiSecondoGrado(a, b,c);
            textBoxRisultato.Text = (risultato == null) ? "Errore" : (risultato.Length == 1) ? risultato[0].ToString() : $"x1={risultato[0]} x2={risultato[1]}";
        }
        private void btnReset_Click(object sender,EventArgs e)
        {
            textBoxRisultato.Clear();
            textBox1a.Clear();
            textBox1b.Clear();
            textBox1c.Clear();
        }

        
    }
}