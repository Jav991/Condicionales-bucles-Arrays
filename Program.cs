/*Console.WriteLine("Hello, World!");*/

/* Ejercicio 1: */
int Edad = 0;

Console.WriteLine ("Edad: ");
Edad = int.Parse(Console.ReadLine()!);

if (Edad >= 18 )
{
    Console.WriteLine ("Mayor de edad");
}
else
{
    Console.WriteLine("Eres menor 😢");
}

/* Ejercicio 2*/
int Numero = 0;
Console.WriteLine ("Introduzca numero: ");
Numero = int.Parse(Console.ReadLine()!);

if (Numero < 0)
{
    Console.WriteLine("No se admiten números menores a 0");
}

/* Ejercicio 3*/

int Nota = 0;
Console.WriteLine ("Introduzca nota: ");
Nota = int.Parse(Console.ReadLine()!);

if (Nota >= 5)
{
    Console.WriteLine("Aprobado");
}

/*Ejercicio 4*/

double Temperatura = 0; 
Console.WriteLine ("Introduzca Temperatura: ");
Temperatura = double.Parse(Console.ReadLine()!);

if (Temperatura > 30)
{
    Console.WriteLine("hace calor🥵🥵");
}