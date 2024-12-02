using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReescriviendoCSharp.Scripts.Concesionaria
{
    public class LogicSala
    {
        ControlRoomsPrincipal controlRoomMain = new ControlRoomsPrincipal();
        

        int horasDelDia = 24;
        int horasExtras_CadaDosHoras = 10;

        /// <summary> Calcula cuanto gano por las horas extras. </summary>


        /// <param name="gananciasPorHorasExtras">Cantidad de ganancias por horas extras que hace el empleador       <param>

        /// <return> horas extras </return>
        public float MetodoDePrueba(float gananciasPorHorasExtras)
        {
            float resultado = gananciasPorHorasExtras* horasDelDia / horasExtras_CadaDosHoras;
            return resultado;
        }
        //El resultado de este calculo es lo que gana por horas extras en el dia un empleado
    }
}
