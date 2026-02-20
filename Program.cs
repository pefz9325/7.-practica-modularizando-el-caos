Console.WriteLine("=== Calculadora Modular ===");

Console.Write("Ingrese el primer número: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el segundo número: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Suma: {Sumar(num1, num2)}");
Console.WriteLine($"Resta: {Restar(num1, num2)}");
Console.WriteLine($"Multiplicación: {Multiplicar(num1, num2)}");
Console.WriteLine($"División: {Dividir(num1, num2)}");

int Sumar(int a, int b)
{
    return a + b;
}

int Restar(int a, int b)
{
    return a - b;
}

int Multiplicar(int a, int b)
{
    return a * b;
}

double Dividir(int a, int b)
{
    if (b == 0)
    {
        Console.WriteLine("No se puede dividir entre cero");
        return 0;
    }
    return (double)a / b;
}

Console.WriteLine("\n=== Validador de Acceso ===");

Console.Write("Ingrese su edad: ");
int edad = Convert.ToInt32(Console.ReadLine());

ValidarEdad(edad);

void ValidarEdad(int edad)
{
    if (edad < 18)
    {
        Console.WriteLine("Acceso Denegado");
    }
    else
    {
        Console.WriteLine("Bienvenido");
    }
}

Console.WriteLine("\n=== Crear Perfil ===");

CrearPerfil("Pedro", "Programar");
CrearPerfil("Juan");

void CrearPerfil(string nombre, string hobby = "Dormir")
{
    Console.WriteLine($"Nombre: {nombre}");
    Console.WriteLine($"Hobby: {hobby}");
    Console.WriteLine("-------------------");
}