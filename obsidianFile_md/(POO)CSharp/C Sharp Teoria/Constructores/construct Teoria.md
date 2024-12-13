```
Los constructores en C# son metodos especiales que se utilizan para inicializar objetos de una clase o estructuras cuando se crea una instancia de ella. Un constructor tiene el mismo nombre que la clase o estructura y no tiene un tipo de retorno, ni siquiera void.

Caracteristicas clave de los constructores es la inicializacion de objetos. Los constructores se utilizan pricipalmente para establecer los valores iniciales de los campos y propiedades de un objeto. Sobrecarga de clases o estructuras que puede tener multiples constructores(Esto se llama "Sobrecarga de constructores"), cada uno con diferentes parametros, lo que permite diferentes formas de crear instancias.
Los constructores predeterminados. Si no defines un constructor en una clase, C# proporciona automaticamente un constructor predeterminado sin parametros que inicializa los campos a sus valores predeterminados.


// Clase Principal 
public class Person
{
	// Campos
	public string Name;
	public int Age;
	
	// / // Constructor sin parametros (predeterminados)
	public Person()
	{
		Name = "Unknow";
		Age = 0;
	}
	// / // Contructor con parametros
	public Person(string name, int age)
	{
		Name = name;
		Age = age;
	} 
}
class Person
	{
		static void Main ()
	}



```