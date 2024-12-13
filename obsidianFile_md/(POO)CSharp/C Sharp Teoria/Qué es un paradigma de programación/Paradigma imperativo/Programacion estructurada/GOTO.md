Sintaxis basica

C# :
```
[modificador_acceso] [tipo_retorno] NombreMetodo([parámetros])
{
    // Código de la subrutina
    return valor; // Opcional, según el tipo de retorno
}

```



En C#, [GOTO] es una instruccion que permite transferir el flujo de control a una etiqueta especifica en el codigo. Aunque puede ser util en algunos casos, su uso no es recomendado en la mayoria de los escenarios porque puede hacer que el codigo sea dificil de leer y mantener.

Sintaxis de [GOTO]: 
```
goto etiqueta;

// Definición de la etiqueta:
etiqueta:
    // Código al que se redirige el flujo

```

Casos de uso de [GOTO]:

1 - Salir de multiples bucles anidados: En lugar de usar varias condiciones o banderas para salir de multiples niveles de bucles, GOTO puede ser util.

- Saltar dentro del codigo
```
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Inicio del programa");

        goto Salto; // Salta a la etiqueta 'Salto'

        Console.WriteLine("Este mensaje será omitido");

        Salto:
        Console.WriteLine("Llegamos al salto");
    }
}

```

- Salir de multiples bucles
```
using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i == 2 && j == 2)
                {
                    goto Fin; // Salir de ambos bucles
                }
                Console.WriteLine($"i: {i}, j: {j}");
            }
        }

        Fin:
        Console.WriteLine("Saliste de los bucles.");
    }
}

```

2 - Switch avanzado: Se puede usar GOTO para saltar entre casos en una estructura switch. 

- Uso en Switch
```
using System;

class Program
{
    static void Main()
    {
        int opcion = 2;

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Opción 1");
                goto case 2; // Salta al caso 2
            case 2:
                Console.WriteLine("Opción 2");
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }
}
```
