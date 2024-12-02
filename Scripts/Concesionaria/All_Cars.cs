using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReescriviendoCSharp.Scripts.Concesionaria
{
    //Hacer una clase protected de autos que solo el ultimo empleado lo pueda usar. Osea el empleador 6.
    public class All_Cars
    {
        //Solo el empleador 6 puede entrar a esta seleccion y cambiar los demas lo pueden leer nomas

        ///<param name="Caracteristicas" > Caracteristicas especificas del auto solicitado</param>
        //inicialización y crear a valores
        //Si busco un nombre o marca de un auto, me tiene que devolver datos de ese mismo.
        Dictionary<string, string> autos = new Dictionary<string, string>()
        {
            {"Munstang", "Ford"},
            {"Camaro", "Chevrolet"},
            {"Ram", "Dogger"},

        };
        //añadir valores
        //autos.Add("Toyota", "");
        
        //string Camaro = "Chevrolet";
        //string Ram = "Dogger";
        //string Toyota = "Hylux";
        //string Bugatti = "Chiron";
        //string Audi = "";
        //string BMW = "Z8";
        //string Alpina = "";
        //string Volkswagen = "Golf";
        //string Smart = "Cortito";
        //string  = "";

    }
}
