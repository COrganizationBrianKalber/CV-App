using System;
using ReescriviendoCSharp.Scripts.Concesionaria;

using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Carpetas definidas en el namespace
namespace ReescriviendoCSharp.Scripts.Concesionaria
{
    public class ControLocal
    {
        
        public class Salas
        {
            private string brian_Gunner = "Empleado_1";
            private string carlos_Stuart = "Empleado_2";
            private string alan_kalber = "Empleado_3";
            private string gustavo_Maldonado = "Empleado_4";
            private string yahirson_Alexander = "Empleado_5";
            
            private string patroclo_Esparta = "Empleado_6"; //El unico empleado con privilegios de cambiar los precios de los vehiculos en la base de datos.
            public void sala_Uno()
            {
                Console.WriteLine(brian_Gunner);
            }
            public void sala_Dos()
            {
                Console.WriteLine(carlos_Stuart);
            }
            public void sala_Tres()
            {
                Console.WriteLine(alan_kalber);
            }
            public void sala_Cuatro()
            {
                Console.WriteLine(gustavo_Maldonado);
            }
            public void sala_Cinco()
            {
                Console.WriteLine(yahirson_Alexander);
            }
            public void sala_Seis()
            {
                Console.WriteLine(patroclo_Esparta);
            }
            var logic = new LogicSala();

            

        }
        

    }
    
    
}


