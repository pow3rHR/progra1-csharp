//parámetros por defecto son aquellos cuyo valor es definido en la definición misma de la función.

int restar(int a, int b = 5) {
    return a * b;
}

Console.WriteLine(restar(4));

// es posible utilizar dicho valor a conveniencia