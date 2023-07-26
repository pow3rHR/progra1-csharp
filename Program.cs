// Ejercicio #3

bool a = true, b = false, c = (true && false), d = (false || false);

a = a || c;
b = d;

int x = 5;

Console.WriteLine(--x < x || (a || b));