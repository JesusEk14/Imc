using Imc.Models;

Console.WriteLine("Calculadora de Índice de Masa Corporal.");
Console.WriteLine();


decimal peso = ReadDecimal("Proporcione el peso de la persona en kilogramos: ");
decimal estatura = ReadDecimal("Proporcione la estatura de la persona en metro: ");

// Realizar los cálculos 
var imc = CalculadoraImc.IndiceDeMasaCorporal(peso, estatura);
Console.WriteLine($"El índice de masa corporal de la persona es {imc:F4}");
var situacionNutricional = CalculadoraImc.SituacionNutricional(imc);
Console.WriteLine($"El estado nutricional de la persona es {situacionNutricional}");
return 0;

static decimal ReadDecimal(string indicacion)
{
    bool valorEsValido = false;
    decimal valor;
    do
    {
        Console.Write($"{indicacion}");
        var entrada = Console.ReadLine();
        valorEsValido = decimal.TryParse(entrada, out valor);

        if (!valorEsValido)
        {
            Console.WriteLine("el dato propocionado debe ser numerico.");
        }
    } while (!valorEsValido);
    return valor;
}