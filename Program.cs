/*Console.WriteLine("Hello, World!");*/

/* NIVEL 1 😎😎*/
/* Ejercicio 1: */
/*int Edad = 0;

Console.WriteLine ("Edad: ");
Edad = int.Parse(Console.ReadLine()!);

if (Edad >= 18 )
{
    Console.WriteLine ("Mayor de edad");
}
else
{
    Console.WriteLine("Eres menor 😢");
} */

/* Ejercicio 2*/

/*int Numero = 0;
Console.WriteLine ("Introduzca numero: ");
Numero = int.Parse(Console.ReadLine()!);

if (Numero < 0)
{
    Console.WriteLine("No se admiten números menores a 0");
}
*/

/* Ejercicio 3*/

/*int Nota = 0;
Console.WriteLine ("Introduzca nota: ");
Nota = int.Parse(Console.ReadLine()!);

if (Nota >= 5)
{
    Console.WriteLine("Aprobado");
}
*/
/*Ejercicio 4*/

/*double Temperatura = 0; 
Console.WriteLine ("Introduzca Temperatura: ");
Temperatura = double.Parse(Console.ReadLine()!);

if (Temperatura > 30)
{
    Console.WriteLine("hace calor🥵🥵");
}
*/

/* NIVEL 2 😎😎*/

/* Ejercicio 5:*/

/*
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

int numero = 0;
Console.WriteLine("Introduzca un número: ");
numero = int.Parse(Console.ReadLine()!);

if (numero < 0)
{
    Console.WriteLine("Debe introducir un número mayor o igual 0");
}

else if(numero % 2 == 0)
{
    Console.WriteLine("Es par");
}
else
{
    Console.WriteLine("Es impar");
}

*/
/* Ejercicio 6 */

/*
int n = 0;
Console.WriteLine("Introduzca un número: ");
n = int.Parse(Console.ReadLine()!);

if(n > 0)
{
    Console.WriteLine("Es positivo");
}
else if(n < 0)
{
    Console.WriteLine("Es Negativo");
}
else
{
    Console.WriteLine("Es 0");
}
*/

/* Ejercicio 7: */
/*
String ContraseñaCorrecta = "1234";
Console.WriteLine("Introduzca contraseña");
String ContraseñaUsuario = Console.ReadLine()!;
if(ContraseñaCorrecta == ContraseñaUsuario)
{
    Console.WriteLine ("Contraseña correcta");
}
else if (ContraseñaCorrecta != ContraseñaUsuario)
{
   Console.WriteLine ("Contraseña Incorrecta"); 
}
else
{
    Console.WriteLine ("Introduzca una contraseña");
}
*/

/* Nivel 3 😎😎*/

/* Ejercicio 8 */

using System.Runtime.InteropServices.Marshalling;

double nota  = 0.0;
Console.WriteLine("Introduzca su nota por favor: ");
nota = int.Parse(Console.ReadLine()!);

if(nota < 0)
{
    Console.WriteLine("No puede ser negativa la nota 😉");
}

else if(nota < 5)
{
    Console.WriteLine("Supenso 😂");
}
else if(nota == 5 || nota == 6)
{
    Console.WriteLine("Aprobado 💪");
}
else if(nota == 7 || nota == 8)
{
    Console.WriteLine("Notable 🤔");
}
else if(nota >= 9 || nota < 10)
{
    Console.WriteLine("Sobresaliente 😁");
}

/*Ejercicio 10*/

Double Precio = 0.0; 
Console.WriteLine ("Dame precio: ");
Precio = double.Parse(Console.ReadLine()!);
if (Precio < 50)
{
    Console.WriteLine("Sin descuento 🤑");
} 
else if (Precio >= 50 && Precio < 100)
{
    double descuento = Precio - (Precio * 0.05);
    Console.WriteLine ($"precio: {Precio}€, precio con descuento: {descuento}€");
}
else if (Precio >= 100)
{
   double descuento = Precio - (Precio * 0.10);
   Console.WriteLine ($"precio: {Precio}€, precio con descuento: {descuento}€");

}