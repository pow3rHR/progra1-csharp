void es_ideal(double imc) {

    if (imc >= 25.0 || imc <= 29.9)
    {
        Console.WriteLine("Sobre peso");
    }
    else if (imc >= 18.5 || imc <= 24.9)
    {
        Console.WriteLine("Peso ideal");
    }
    else if (imc < 18.5)
    {
        Console.WriteLine("Peso insuficiente");
    }
}

double calcular_imc(double peso, double altura) {
    return lb_kg(peso) / (cm_mt(altura) * cm_mt(altura));
}

double lb_kg(double peso) {
    return peso * 0.45359237;
}

double cm_mt(double altura) {
    return altura / 100;
}

Console.WriteLine(calcular_imc(150, 165));
es_ideal(calcular_imc(150, 165));