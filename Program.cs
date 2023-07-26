// Ejercicio #6

// decimal a binario
Console.Write("Por favor ingrese un número decimal para ser convertido a binario: ");

string n = Console.ReadLine();

Console.WriteLine(Convert.ToString(Convert.ToInt32(n), 2));

// binario a decimal
Console.Write("Por favor ingrese un número binario para ser convertido a decimal: ");

string b = Console.ReadLine();

Console.WriteLine(Convert.ToInt32(b, 2));