// See https://aka.ms/new-console-template for more information
using PreAccademyEquazione2Grado.Core;

Console.WriteLine("Equazione di secondo grado");
Console.WriteLine("Immetti i tre coefficenti dell'equazione completa ax^2+bx+c");
Console.WriteLine("a= ");
double a= double.Parse(Console.ReadLine());
Console.WriteLine("b= ");
double b= double.Parse(Console.ReadLine());
Console.WriteLine("c= ");
double c= double.Parse(Console.ReadLine());

Console.WriteLine($"\nL'equazione da risolvere è :{a}x^2+{b}x+{c}=0");


Equation eq = new Equation();
double[] risultato = eq.RisolviEquazioneDiSecondoGrado(a, b, c);

if (risultato == null)
{
    Console.WriteLine("Equazione impossibile");

}else if(risultato.Length == 1)
{
    Console.WriteLine($"risultato : x1=x2{risultato[0]}");
}
else
{
    Console.WriteLine($"risultato : x1{risultato[0]} x2{risultato[1]}");
}


