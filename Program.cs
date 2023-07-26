// Ejercicio #8

// valores que serán constantes a lo largo del programa.
const double afp = 0.0625, isss = 0.03;
const double cft1 = 0.00, cft2 = 17.67, cft3 = 60.00, cft4 = 288.57;
const double pt1 = 0.00, pt2 = 0.10, pt3 = 0.20, pt4 = 0.30;

// datos de cada tramo
string tramo = "";
double retencion = 0.00;

Console.WriteLine("Bienvenido/a a calculadora de renta.\n");

Console.Write("Por favor ingrese su nombre: ");
string nombre = Console.ReadLine();

Console.Write("Ingrese su salario bruto: ");
double salarioBruto = Convert.ToDouble(Console.ReadLine());

double salarioNeto = Math.Round(salarioBruto - (salarioBruto * afp + salarioBruto * isss), 2);

Console.WriteLine("Su salario neto es " + salarioNeto);

if (salarioNeto > 0.00 && salarioNeto <= 472.00)
{
    tramo = "I";
    retencion = Math.Round((salarioNeto - 0) * pt1 + cft1, 2);
    salarioNeto = salarioNeto - retencion;
}
else if (salarioNeto > 472.01 && salarioNeto <= 895.24)
{
    tramo = "II";
    retencion = Math.Round((salarioNeto - 472.00) * pt2 + cft2, 2);
    salarioNeto = salarioNeto - retencion;
}

else if (salarioNeto > 895.25 && salarioNeto <= 2038.10)
{
    tramo = "III";
    retencion = Math.Round((salarioNeto - 895.24) * pt3 + cft3, 2);
    salarioNeto = salarioNeto - retencion;
}

else if (salarioNeto > 2038.11)
{
    tramo = "IV";
    retencion = Math.Round((salarioNeto - 2038.10) * pt4 + cft4, 2);
    salarioNeto = salarioNeto - retencion;
}

Console.WriteLine("Usted pertenece al tramo " + tramo + " Se detallan sus impuestos en la siguiente tabla: ");
Console.WriteLine("NOMBRE\t\tTRAMO\tRETENCION\tSALARIO NETO DESPUES DE RENTA");
Console.WriteLine(nombre + "\t" + tramo + "\t" + retencion + "\t\t" + salarioNeto);