﻿// See https://aka.ms/new-console-template for more information

//Snack 1

//Console.WriteLine("Inserisci un numero");

//int numero1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Inserisci un secondo numero");

//int numero2 = Convert.ToInt32(Console.ReadLine());

//if (numero1 > numero2)
//{
//    Console.WriteLine($"Il numero maggiore è {numero1}");
//} else if (numero1 < numero2)
//{
//    Console.WriteLine($"Il numero maggiore è {numero2}");
//} else
//{
//    Console.WriteLine("I due numeri sono uguali");
//}


//Snack 2

//Console.WriteLine("Inserisci una parola");

//string parola1 = Console.ReadLine();

//int lunghezza1 = parola1.Length;

//Console.WriteLine("Inserisci una seconda parola");

//string parola2 = Console.ReadLine();

//int lunghezza2 = parola2.Length;

//if (lunghezza1 > lunghezza2)
//{
//    Console.WriteLine($"{parola1},{parola2}");
//}
//else if (lunghezza1 < lunghezza2)
//{
//    Console.WriteLine($"{parola2},{parola1}");
//}
//else
//{
//    Console.WriteLine("Le due parole sono egualmente lunghe");
//}


//Snack 3


int sum = 0;

for (int i = 0; i < 10; i++)

{
    Console.WriteLine("Inserisci un numero");

    int numero = Convert.ToInt32(Console.ReadLine());

    sum = sum + numero;

}

Console.WriteLine($"La somma equivale a {sum}");

