using ReescriviendoCSharp.Scripts.Concesionaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ReescriviendoCSharp.Scripts.Concesionaria;

//Modificadores de acceso principales en C# Son:
/// <summary> 
///     public = no tiene restricciones de acceso.
///     private = solo son accesibles desde la clase en la que se generan.
///     internal = acceso solo desde el mismo proyecto.
///     protected = solo accesible desde la clase que se genera y sus clases derivadas.
/// 
/// </summary>
//Tipos de no primitivos
/// <summary> 
///     Clases    
///     Struct
///     Enum
///     Array
///     String
///     DateTime
/// </summary>
// var es la variable que se puede colocar en cualquier Variable que querramos, por ejemplo var myInt = 90; Se convierte en un int

//IMPORTANTE: Para importar clases lo puedo hacer con alt+enter y la clase que quiero importar


namespace ReescriviendoCSharp.Scripts.Concesionaria
{
    public class Program
    {
        //Main de la clases a ser llamadas todas las demas
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());




            //Porque te hace almacenar en una variable si despues no se va a poder utilizar?
            ControlRoomsPrincipal rooms = new ControlRoomsPrincipal();
            
            WeekAndDays weekAndDays = WeekAndDays.Monday;
            
            LogicSala logic = new LogicSala();
            All_Cars all_Cars = new All_Cars();
            Console.WriteLine("Hola!,"+ ControlRoomsPrincipal.Brian_Gunner + ".Como estas?");
            //Console.WriteLine("Las ganancias son", LogicSala.MetodoDePrueba());
            int[] myArray = new int[5];
            //DateTime myDateTimeArray = new DateTime(2024-11-26); 

            Console.ReadKey();
            //Combinar proyectos en C# y usar las otras clases de otros proyectos.

        }

        
    }
}
