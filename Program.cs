// See https://aka.ms/new-console-template for more information

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


//int sum = 0;

//for (int i = 0; i < 10; i++)

//{
//    Console.WriteLine("Inserisci un numero");

//    int numero = Convert.ToInt32(Console.ReadLine());

//    sum = sum + numero;

//}

//Console.WriteLine($"La somma equivale a {sum}");



//Snack 4

//int sum = 0;

//int max = 10;

//int min = 2;

//for (int i = min; i <= max; i++)
//{
//    sum = sum + i;
//}

//float average = sum / (max - min);

//Console.WriteLine($"La somma è {sum}, la media è {average}");




//Snack 5


//Console.WriteLine("Inserisci un numero");

//int numero = Convert.ToInt32(Console.ReadLine());

//if (numero % 2 == 0 )
//{
//    Console.WriteLine($"Il numero {numero} è pari");
//} else
//{
//    Console.WriteLine($"Il numero successivo {numero + 1} è pari");
//}




//Snack 6

//string[] invitati = {"Jay Gatsby", "Nick Carraway", "Jordan Baker", "Myrtle Wilson"};

//Console.WriteLine("Inserisci uil nome dell'invitato");

//string nome = Console.ReadLine();

//if (invitati.Contains(nome))
//{
//    Console.WriteLine($"{nome} è ammesso alla festa");
//} else
//{
//    Console.WriteLine($"{nome} non è ammesso alla festa");
//}




int[] numeriDispari = new int[6];

for (int i = 0; i < numeriDispari.Length; i++)
{
    Console.WriteLine("Inserisci un numero");

    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero % 2 == 1)
    {
        numeriDispari[i] = numero;
    }
}


