using System;

String nombre;
int a�os;


Console.Write("Escribe tu nombre: ");
nombre = Console.ReadLine();
Console.WriteLine($"Tu nombre es {nombre} ");

Console.Write("Cuantos a�os tienes?: ");
a�os = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Hola {nombre} veo que tienes {a�os} a�os, bienvenido al grupo");