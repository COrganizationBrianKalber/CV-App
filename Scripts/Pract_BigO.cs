using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReescriviendoCSharp.Scripts
{
    internal class Pract_BigO
    {
        /*
 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
 La notacion Big O se escribe como O(f(n)), donde:
    - La letra "o" representa el orden de magnitud.
    - Los terminos entre parentesis representan la funcion de complejidad del tiempo.
    - "f(n)" representa la funcion que describe la complejidad temporal del algoritmo.
 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    BIG O:
        ¿Qué es Big O?
        Notacion Big O.
            - Representa la complejidad del peor de los casos de un algoritmo. Utiliza terminos algebraicos para describir la complejidad de un algoritmo.
            
            - El Big O define el tiempo de ejecucion necesario para ejecutar un algoritmo identificando como cambiara el rendimiento de su algoritmoa medida que crece el tamano de la entrada. Pero no le dice que tan rapido es el tiempo de ejecucion de su algoritmo.

        En notacion Big O, existen 6 tipos de complejidades (tiempo y espacio):
        
        - Constante: O(1)
        - Lineal: O(n)
        - Logaritmica: O(n log n)
        - Cuadratica: O(n^2)
        - Exponencial: O(2^n)
        - Factorial: O(n!)

        En el grafico de esta URL: https://www.freecodecamp.org/espanol/news/hoja-de-trucos-big-o/ dice que O(1), complejidad de tiempo constante, es el mejor. Esto implica que su algoritmo procesa solo una declaracion sin ninguna interacion. Luego esta O(log n), que es bueno, y otros similares:
          
          - O(1) - Excelente/Mejor
          - O(log n) - Bueno
          - O(n) - Aceptable
          - O(n log n) - Malo
          - O(n^2), O(2^n) y O(n!) - Horrible/Peor

        Por que la complejidad del tiempo esta en funcion del tamano de entrada?
            Un algoritmo que calcula la suma de numeros en funcion de su entrada. Si su entrada es 4, sumaremos 1 + 2 + 3 + 4 y la salida seria 10; si su entrada es 5 la salida sera 15.
        
        Codigo en JavaScript.
            const calcularSuma = (entrada) => {
                let suma = 0; // 1ra declaración 
                for (let i = 0; i <= entrada; i++) {
                    suma += i; // 2da declaración
                }
                return suma; // 3ra declaración
                };

    Cuando usar un algoritmo u otro.
        - Cuando el calculo no depende del tamano de una entrada, es una complejidad de tiempo constante O(1).
        - Cuando el tamano de entrada se reduce a la mitad, tal vez al iterarm manejar ++recursividad++, o lo que sea, es una complejidad de tiempo logaritmica O(log n).
        - Cuando tiene un solo bucle dentro de sus algoritmos, es complejidad de tiempo lineal O(n).
        - Cuando tiene dos bucles anidados dentro de su algoritmo, es decir, un bucle dentro de otro bucle, es una complejidad de tiempo cuadratica O(n^2).
        - Cuando la taza de crecimiento se duplica con cada iteracion a la entrada, se trata de una complejidad temporal exponencial O(2^n).
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




Big O: Ejemplos de Tiempo de Complejidad:
    Tiempo Constante: O(1):
        Cuando su algoritmo no depende del tamano de entrada n, se dice que tiene una complejidad temporal constante con orden O(1). Esto significa que el tiempo de ejecucion siempre sera el mismo independientemente del tamano de entrada.
        Por ejemplo, si un algoritmo debe devolver el primer elemento de un arreglo. Incluso si el arreglo tiene 1 millon de elementos, la complejidad temporal sera constante si utiliza este enfoque:
    


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////







        
        //Observaciones: El codigo solo tiene 3 declaraciones. Aun asi, debido a que hay un bucle, la segunda declaracion se ejecutara segun el tamano de la entrada, por lo que si la entrada es 4, la segunda declaracion se ejecutara 4 veces, lo que significa que todo el algoritmo se ejecutara 6 veces. 
        //Se ejecutara entrada + 2 veces, donde la entrada puede ser cualquier numero 
        //
    








///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Anagrama
    Un anagrama es una palabra creada a partir de ka reordenacion de las letras de otras palabras. Ej: saco - caso.
    Dado un array de strings, devuelve los anagramas agrupados. Cualquier orden es valido.
    
    Ejemplo:
        Input: words = ["saco", "arresto", "programa", "rastreo", "caso"].
        Output: [["saco", "caso"],["arresto","rastreo"], ["programa"]]
    */
        //Big O: Tiempo de Complejidad
        //Tiempo Constante: O(1)
        //Codigo:
        public void Modulo()
        {
            int[] arraySs = { 10, 20, 30, 40 };
            Console.WriteLine(arraySs[0]);
        }




        //Tiempo Lineal: O(n)

        //Tiempo Logaritmico: O(log n)

        //Tiempo Cuadratico: O(n^2)

        //Tiempo Exponencial: O(2^n)



    }
}
