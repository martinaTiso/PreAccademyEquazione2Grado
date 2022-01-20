using PreAccademyEquazione2Grado.Core;
using Xunit;

namespace PreAccademyEquazione2Grado.Test
{
    public class EquazioneTest
    {
        [Fact]
        public void Test1()
        {
            //ARRANGE: predisposizione /prerequisiti del test
            Equation equazione = new Equation(); // classe equazione
            double a = 1;
            double b = -3;
            double c = 2;

            // ACT:CHIAMATA DELLE FUNZIONALITà DA TESTARE
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(a, b, c);

            // ASSERT:VALUTAZIONE DEL RISULTATO ATTESO VS OTTENUTO

            Assert.True(risultato.Length == 2);// lunghezza dell'array

            // Equals
            Assert.Equal(1, risultato[0]);// in alternativa Assert.True(risultato[0] == 1);
            Assert.Equal(2, risultato[1]);// in alternativa Assert.True(risultato[0] == 2);



        }
        [Fact]
        public void Test2()
        {
            Equation equazione = new Equation(); // classe equazione
            double a = 1;
            double b = -5;
            double c = 6;

            // ACT:CHIAMATA DELLE FUNZIONALITà DA TESTARE
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(a, b, c);

            // ASSERT:VALUTAZIONE DEL RISULTATO ATTESO VS OTTENUTO

            Assert.True(risultato.Length == 2);// lunghezza dell'array

            // Equals
            Assert.Equal(2, risultato[0]);// in alternativa Assert.True(risultato[0] == 2);
            Assert.Equal(3, risultato[1]);// in alternativa Assert.True(risultato[0] == 3);


        }
        [Fact]
        public void Test3()
        {
            Equation equazione = new Equation(); // classe equazione
            double a = 1;
            double b = 2;
            double c = 1;

            // ACT:CHIAMATA DELLE FUNZIONALITà DA TESTARE
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(a, b, c);

            // ASSERT:VALUTAZIONE DEL RISULTATO ATTESO VS OTTENUTO

            Assert.True(risultato.Length == 1);// lunghezza dell'array

            // Equals
            Assert.Equal(-1, risultato[0]);// in alternativa Assert.True(risultato[0] == -1);
           


        }
        [Fact]
        public void Test4()
        {
            Equation equazione = new Equation(); // classe equazione
            double a = 1;
            double b = -3;
            double c = 10;

            // ACT:CHIAMATA DELLE FUNZIONALITà DA TESTARE
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(a, b, c);

            // ASSERT:VALUTAZIONE DEL RISULTATO ATTESO VS OTTENUTO

            Assert.Null(risultato);


        }
    }
}