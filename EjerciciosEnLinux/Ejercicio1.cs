//Pagina de RETOS: https://retosdeprogramacion.com/ejercicios
//Control k mas la z luego expandis el visual code a mas

using Microsoft.VisualBasic;
using System;

///<summary>
/// Escribe un programa que muestre por consola (con un print) los
/// números de 1 a 100 (ambos incluidos y con un salto de línea entre
/// cada impresión), sustituyendo los siguientes:
/// - Múltiplos de 3 por la palabra "fizz".
/// - Múltiplos de 5 por la palabra "buzz".
/// - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
///</summary>

//Cosas a tener en cuenta: Dentro de una clase no puedo tener un bucle while sino que debe estar dentro de un constructor funcion 










namespace Ejercicios
{
    public class FizzBuzz
    {

        public void EjecutarBlucle()
        {
            int multiploDeTres = 3;
            int multiploDeCinco = 5;
            for (int i = 0; i < 101; i++)
            {
                int auxTres = i % multiploDeTres;
                int auxCinco = i % multiploDeCinco;

                /*
                P | Q | P ^ Q
                0 | 0 |   0
                0 | 1 |   0
                1 | 0 |   0
                1 | 1 |   1
                */

                /*
                P | Q | P v Q
                0 | 0 |   0
                0 | 1 |   1
                1 | 0 |   1
                1 | 1 |   1
                */
                if (auxTres == 0 && auxCinco == 0)
                {
                    Console.WriteLine("Fizz & Buzz");
                } else if (auxCinco == 0) 
                {
                    Console.WriteLine("Buzz");
                } else if (auxTres == 0) 
                {
                    Console.WriteLine("Fizz");
                } else 
                {
                    Console.WriteLine($"{i}");

                }

            }
        }
    }

}
// dotnet run --proyect /home/briankalber/Documents/codeVSPagWeb/Scripts/Concesionaria/EjerciciosEnLinux 
//Ejecutar el proyecto especifico con este comando  








