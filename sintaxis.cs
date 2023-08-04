// Andres Arizpe
// para definir texto solo es necesario el comando console.writeline.
// mientas que para definir una entrada de texto se usa el comando console.readline.
// para definir una constante se usa el comando const. mientras que para una variable no es necesario
//  sim embargo se usa el comando var.
// para definir algun tipo de numero se usan los siguiees comandos: int, float, double, decimal.
// int se usa cuando es un numero entero, float se usa cuando es un numero con decimales, 
//double se usa cuando es un numero con decimales mas grandes que float,
// decimal se usa cuando es un numero con decimales mas grandes que double.
// mientras que para booleanos se una true o false.
// un string es una cadena de texto.
// para definir una entrada de texto que sea un numero se usa el comando int.parse como se muestra en el ejemplo anterior.
// para hacer operaciones dentro de un writeline se usa "$" antes de las comillas y dentro de las comillas se usa "{}" para definir la operacion.
// para definir una operacion se usan los siguientes comandos: +, -, *, /, %.
// + se usa para sumar, - se usa para restar, * se usa para multiplicar, / se usa para dividir, % se usa para sacar el residuo de una division.
// para definir una operacion de comparacion se usan los siguientes comandos: ==, !=, <, >, <=, >=.
// tambien se usan ++ que le suma +1 a la variable
// t tambien se usa -- que le resta -1 a la variable
const int ano = 2023;
Console.WriteLine("cual es tu edad|");
int edad = int.Parse(Console.ReadLine());
Console.WriteLine("tu naciste en el ano " + (ano - edad));
