// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola Mundo !!!!");

// Ejercicio:
// Modificar para que muestre de 1 a 10

// Variables locales
int a = 0;

// Ejemplo de for // lo hago yo?
//for (int i = 1; i <= 10; i++)
//{

//    Console.WriteLine(i);

//} 
// hago un cambio, yo no he sido
// (c) Jose Antonio
//for (int i = 1; i <= 10; i++) {


//    Console.Write(" la suma de " + i + " + " + a);
//	a += i;

//	Console.Write(" es " + a + "\n");


//}

// Mostrar por pantalla el numero a encontrar
//int numero = 5;
//Console.WriteLine("Numero a encontrar: " + numero);

//for (int i = 0; i <= 10; i++)
//{
//    if (i == numero)
//    {
//        Console.WriteLine("Numero encontrado: " + i);
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Numero no encontrado: " + i);
//    }
//}
//Console.WriteLine("Fin del programa");

//  Vuelta 1 - i es cero, no es igual a 5
//  Vuelta 2 - i es uno, no es igual a 5
//  Vuelta 3 - i es dos, no es igual a 5
//  Vuelta 4 - i es tres, no es igual a 5
//  Vuelta 5 - i es cuatro, no es igual a 5
//  Vuelta 6 - i es cinco, es igual a 5 y se sale del bucle


// Modificar para incorporar las siguientes características:    
// Indicar el numero de intentos que le quedan
// Indicar si el número a adivinar es mayor o menor que el introducido


// Pedir al usuario que ingrese un número a adivinar
Console.Write("Introduce un número para que otro jugador lo adivine: ");
int numeroAdivinar = int.Parse(Console.ReadLine());

// Limpiar la consola para que el segundo jugador no vea el número
Console.Clear();

// Dar tres oportunidades para adivinar el número
for (int i = 1; i <= 3; i++)
{
    Console.Write("Adivina el número: ");
    int intento = int.Parse(Console.ReadLine());

    if (intento == numeroAdivinar)
    {
        Console.WriteLine("¡Felicidades! Has adivinado el número.");
        return;
    }
    else
    {
        if (intento > numeroAdivinar)
            Console.WriteLine("Numero es mayor al introducido");
        if (intento < numeroAdivinar)
            Console.WriteLine("Numero es menor al introducido");
        Console.WriteLine("Número incorrecto. Intenta de nuevo. Le quedan {0} intentos.", 3 - i);
    }
}

Console.WriteLine("Lo siento, no has adivinado el número.");