


//Console.WriteLine("Por favor, ingresa tu nombre");
//string nombre = Console.ReadLine();
//Console.WriteLine("Por favor, ingresa tu apellido");
//string apellido = Console.ReadLine();
//Console.WriteLine("Por favor, ingresa tu eadd");
//string edad = Console.ReadLine();
//Console.WriteLine("¡sabes programar?");
//string sabeProgramar = Console.ReadLine();

//Console.WriteLine($"Hola {nombre} {apellido}, tienes {edad} y {sabeProgramar} sabes programar");

//Vehiculo moto = new Vehiculo();
//moto.acelerar(65);

//Vehiculo.saludar();

//Coords misCoordenadas = new Coords(1,5,6);
//Console.WriteLine(misCoordenadas);




//public class Vehiculo
//{
//    public int Ruedas { get; set; }
//    public string Marca { get; set;}
//    public string Modelo { get; set;}
//    public int Velocidad { get; set; } = 15;
//    public int VelocidadMax { get; set;}

//    public void acelerar(int acelerar)
//    {
//        this.Velocidad += acelerar;
//        Console.WriteLine($"velocidad max: {this.Velocidad}");
//    }

//    public static void saludar()
//    {
//        Console.WriteLine("Hola Mundo");
//    }
//}


//public struct Coords
//{
//    public double X { get; }
//    public double Y { get; }
//    public double Z { get; }

//    public Coords(double x, double y, double z) 
//    {
//        X = x;
//        Y = y;
//        Z = z;
//    }

//    public override string ToString()
//    {
//        return $" X: {X} Y: {Y} Z: {Z}";
//    }
//}

//for (int i = 0; i < 10; i++)
//{
//    for(int j =0; j< 10; j++)
//    {
//        Console.WriteLine("------------");
//        Console.WriteLine("I es: " + i);
//        Console.WriteLine("y");
//        Console.WriteLine("J es : " +j);
//        Console.WriteLine("------------");
//    }  

//}

//int i =0;

//while ( i < 10 )
//{
//    Console.Write( i );
//    i++;
//}


//var numeros = new List<int> { 1,2,3,4,5,6,7,8,9 };

//var numerosPrimos = from num in numeros where num%2 == 1 select num;

//Console.WriteLine(numerosPrimos.GetType());

//foreach (var numero in numerosPrimos)
//{
//    Console.WriteLine(numero);
//}

//Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola. 


//Console.WriteLine("ingrese un numero");
//var numero = int.Parse(Console.ReadLine());
//int i = 1;
//while ( i < 11)
//{
//    Console.WriteLine($"{numero} x {i} = {numero*i}");
//    i++;
//}


//DO WHILE

//Escribe un programa que realice estos pasos:

//Reciba al menos un número por consola

//Determine si el número es positivo o negativo

//Presente un contador para cada tipo (positivo y negativo).

//Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo. 
//Tienes completa libertad para elegir el formato de la salida.


//FOR

Console.WriteLine("ingrese el ancho");
var ancho = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese el alto");
var alto = int.Parse(Console.ReadLine());
Console.WriteLine("esta relleno? s o n");
var relleno = Console.ReadLine();

for (int i = 0; i < ancho; i++)
{
    Console.Write("*");
}

Console.WriteLine();

for (int i = 0; i < alto - 2; i++)
{
    Console.Write("*");

    for (int j = 0; j < ancho - 2; j++)
    {
        if (relleno == "s")
        {
            Console.Write("*");
        }
        else if (relleno == "n")
        {
            Console.Write(" ");
        }

    }

    Console.Write("*");
    Console.WriteLine();
}



for (int i = 0; i < ancho; i++)
{
    Console.Write("*");
}








