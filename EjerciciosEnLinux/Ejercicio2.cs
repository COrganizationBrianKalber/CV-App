//Para abrir la terminal en Visual Studio Code: Ctrl + ` : esta alado del 1










///Pagina de RETOS: https://retosdeprogramacion.com/ejercicios
///<summary>
///
/// Escribe una función que (reciba dos palabras) \ (String) y retorne
/// verdadero o falso (Bool) según sean o no anagramas.
/// 
/// - Un Anagrama consiste en formar una palabra reordenando TODAS
///   las letras de otra palabra inicial.
/// - NO hace falta comprobar que ambas palabras existan.
/// - Dos palabras exactamente iguales no son anagrama.
///
///</summary>
//Ejercicio 2

// Anagrama

namespace Ejercicio2
{
    public class PrimeraClaseAnagrama
    {
        public void anagramaPalabras()
        {

            //Anagrama es roma = amor
            string palabraUnoVerdadero = "roma";
            string palabraUno_Verdadero = "amor";

            //Este no es un anagrama porque no tiene las mismas letras
            string palabraDosFalso = "aaaa";
            string palabraDos_Falso = "bbbb";

            //Mis booleanos
            bool miBooleanoVerdadero = true;
            bool miBooleanoFalso = false;
            
            //Condicion
            if(palabraUnoVerdadero == palabraUno_Verdadero)
            {
                Console.WriteLine(miBooleanoFalso);
            }
            else
            {
                Console.WriteLine($"{palabraUnoVerdadero} y {palabraUno_Verdadero} es: {miBooleanoVerdadero}");
            }

            if(palabraDosFalso != palabraDos_Falso)
            {
                Console.WriteLine($"{palabraDos_Falso} y {palabraDosFalso} es: {miBooleanoFalso}");
            }
            else
            {
                Console.WriteLine(miBooleanoVerdadero);
            }
        }
    }
}










