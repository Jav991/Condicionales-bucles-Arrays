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

/*
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
*/
/*Ejercicio 10*/

/*
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
*/
/*Nivel 4 Ejercicio 11*/
/*
int Dia = 0;
Console.WriteLine ("Introduce un numero del 1-7");
Dia = int.Parse(Console.ReadLine()!);

switch (Dia)
{
    case 1:
        Console.WriteLine("Lunes");
        break;
     case 2:
        Console.WriteLine("Martes");
        break;
     case 3:
        Console.WriteLine("Miercoles");
        break;
    case 4:
        Console.WriteLine("Jueves");
        break;
    case 5:
        Console.WriteLine("Viernes");
        break;
    case 6:
        Console.WriteLine("Sabado");
        break;
    case 7:
        Console.WriteLine("Domingo");
        break;
    default: 
        break;
}

*/
/* Ejercicio 12*/
/*
int opcion = 0;
Console.WriteLine("=== MENÚ PRINCIPAL === \n1. Crear\n2. Consultar\n3 Modificar\n4 Eliminar\n");
Console.WriteLine("===================================");
Console.WriteLine(" 1. Crear");
Console.WriteLine(" 2. Consultar");
Console.WriteLine(" 3. Modificar");
Console.WriteLine(" 4. Eliminar");
Console.WriteLine("===================================");

Console.WriteLine("Seleccione una opción porfavor: ");
opcion = int.Parse(Console.ReadLine()!);

switch (opcion)
{
    case 1:
        Console.WriteLine("Opción de 'Crear' Seleccionada 😉");
        break;
    case 2:
        Console.WriteLine("Opción de 'Consultar' seleccionada 😉");
        break;
    case 3:
        Console.WriteLine("Opción de 'Modificar' Seleccionada 😉");
        break;
    case 4:
        Console.WriteLine("Opción de 'Eliminar' Seleccionada 😉");
        break;
    default:
        Console.WriteLine("Opción no valida");
        break;
}
*/
/*Ejercicio 13*/ 
/*

int N1 = 0, N2 = 0 , operacion = 0;
double suma = 0.0, resta = 0.0, multiplicacion = 0.0, division = 0.0;
Console.WriteLine ("Introduzca primer numero");
N1= int.Parse(Console.ReadLine()!);

Console.WriteLine ("Introduzca segundo numero");
N2= int.Parse(Console.ReadLine()!);
Console.WriteLine("=== MENÚ PRINCIPAL === \n1. Sumar\n2. Restar\n3 Multiplicar\n4 Dividir\n");
Console.WriteLine("===================================");
Console.WriteLine(" 1. Sumar");
Console.WriteLine(" 2. Restar");
Console.WriteLine(" 3. Multiplicar");
Console.WriteLine(" 4. Dividir");
Console.WriteLine("===================================");

Console.WriteLine("Seleccione una opción porfavor: ");
operacion  = int.Parse (Console.ReadLine()!);
 
switch (operacion)
{
    case 1:
        suma = N1 + N2;
        Console.WriteLine($"Suma de n1 + n2: {suma}");
        break;
    case 2:
         resta = N1 - N2;
        Console.WriteLine($"resta de n1 - n2: {resta}");
        break;
    case 3:
        multiplicacion = N1 * N2;
        Console.WriteLine($"multiplicaion de n1 * n2: {multiplicacion}");
        break;
    case 4:
        division = N1 / N2;
        Console.WriteLine($"division de n1 / n2: {division}");
        break;
    default:
        Console.WriteLine("Opción no valida");
        break;
}
*/

/* Ejercicio 15: */
/*

int mes = 0;
Console.WriteLine("Introduzca un número del 1-12: ");
mes = int.Parse(Console.ReadLine()!);

switch (mes)
{
    case 1: 
        Console.Write($"{mes}: Enero");
        break;
    case 2:
        Console.WriteLine($"{mes}: Febrero");
        break;
    case 3:
        Console.WriteLine($"{mes}: Marzo");
        break;
    case 4:
        Console.WriteLine($"{mes}: Abril");
        break;
    case 5:
        Console.WriteLine($"{mes}: Mayo");
        break;

    case 6:
        Console.WriteLine($"{mes}: Junio");
        break;

    case 7:
        Console.WriteLine($"{mes}: Julio");
        break;
    case 8:
        Console.WriteLine($"{mes}: Agosto");
        break;
    case 9:
        Console.WriteLine($"{mes}: Septiembre");
        break;
    case 10:
        Console.WriteLine($"{mes}: Octubre");
        break;
    case 11:
        Console.WriteLine($"{mes}: Noviembre");
        break;
    case 12:
        Console.WriteLine($"{mes}: Diciembre");
        break;
    default:
        Console.WriteLine("Número no válido. Tiene que ser entre el 1 y el 12");
        break;
}
*/
/* Nivel 5* ☕☕/

/* Ejercicio 16*/
/*
int opcion = 0;

Console.WriteLine("Introduzca un número del 1-3");
opcion = int.Parse(Console.ReadLine()!);

string mensaje = opcion  switch
{
    1 => "Bajo",
    2 => "Medio",
    3 => "Alto",
    _ => "Opción no válida"
};
Console.WriteLine($"{opcion}: {mensaje}");

int e1 = 0;
Console.WriteLine("Introduzca un número del 1-7");
e1 = int.Parse(Console.ReadLine()!);

string elecccion = e1 switch
{
    1 => "Lun",
    2 => "Mar",
    3 => "Mie",
    4 => "Jue",
    5 => "Vie",
    6 => "Sab",
    7 => "Dom",
    _ => "Opcion no valida mi rey 👑"
};

Console.WriteLine($"{e1} {elecccion}");
*/
/*Ejercicio 17*/
/*

object dato = 25;
if (dato is int numeroEntero)
{
    Console.WriteLine ($"Es un numero entero{numeroEntero}");
}
else
{
    Console.WriteLine("No es un entero");
}
*/

/* Ejercicio 18*/
/*
object numero = 23;

if(numero is int numeroValido)
{
    if (numeroValido > 18)
    {
        Console.WriteLine($"El numero válido: {numeroValido}, es mayor a 18");
    }
    else
    {
        Console.WriteLine($"El número valido: {numeroValido}, es menor a 18");
    }
}
else
{
   Console.WriteLine($"El número {numero} introducido no es válido. Sorry mi 👑");
}
*/
/* Ejercicio 19*/
/*
object dato1 = 25;
object dato2 = "Hola";
object dato3 = 8.5;

string mensaje = dato1 switch
{
    int i => $"Es un numero entero: {i}",
    string s => $"Es un string: {s}",
    double d => $"Es un double: {d}",
    _=> $"No es nada de lo anterior"
};

string mensaje2 = dato2 switch
{
    int i => $"Es un número entero: {i}",
    string s => $"Es un string: {s}",
    double d => $"Es un double: {d}",
    _=> $"No es nada de lo anterior"  
};
string mensaje3 = dato3 switch
{
    int i => $"Es un número entero: {i}",
    string s => $"Es un string: {s}",
    double d => $"Es un double: {d}",
    _=> $"No es nada de lo anterior"
};
Console.WriteLine($"El dato 1 es de tipo: {mensaje}");
Console.WriteLine($"El dato 2 es de tipo: {mensaje2}");
Console.WriteLine($"El dato 3 es de tipo: {mensaje3}");
*/

/*Nivel 7 Ejercicio 20*/

for (int i = 20; i>=0; i--)
{
    Console.WriteLine($"{i}");

}
