//Andres Arizpe
// un metodo es un grupo de sentencias que realizan una tarea especifica
// sirven para realizar una tarea en un momento determinado. no realiza la tarea hasta que se le llama
// sintaxi:
// TipoDeDato nombreMetodo (parametros)¨{
// sentencias }}
// los metodos pueden tener parametros o no
int sumaNumeros() { 
    //int es el tipo de dato, sumaNumeros es el nombre del metodo y en este caso no tiene parametros
    int nume1 = 7;
    int nume2 = 5;
    int resultado = nume1 + nume2;
    return resultado;
}
// todos los metodos deben de ir dentro de una clase
// metodos y funciones son lo mismo en c#
int sumanumeros2(int nume3, int nume4)
    // en este caso si tiene parametros
{
    int resultado = nume3 + nume4;
    return resultado;
}
Console.WriteLine(sumanumeros2(5, 5));
// un metodo que lleva de tipo de dato void no lleva return
void sumanumeros3()
{
    int nume5= 7;
    int nume6 = 5;
    int resultado = nume5 + nume6;
    Console.WriteLine("El resultado es: " + resultado);
}

mensajeenPantalla();
// las referencias son las veces que se llama al metodo en el codigo
void mensajeenPantalla()
{
    Console.WriteLine("Hola mundo");
}
Console.WriteLine("adios mundo");
// para llamar un metodo se escribe el nombre del metodo seguido de parentesis
// el metodo se puede llamar muchas veces

