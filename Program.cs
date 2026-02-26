using System;

// 1. Lectura de datos: Configurada para los Test Cases de GitHub
string? linea1 = Console.ReadLine();
if (string.IsNullOrEmpty(linea1)) return;

int n = int.Parse(linea1);
// Leemos la segunda línea y dividimos por espacios, eliminando vacíos
string[] entrada = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();

int[] numeros = new int[n];
for (int i = 0; i < n; i++)
{
    numeros[i] = int.Parse(entrada[i]);
}

// --- INICIO DE LÓGICA DEL ALUMNO ---
// Instrucción: El alumno debe encontrar el valor máximo del arreglo 'numeros'
class Program
{
    static void Main()
    {
        // No modificar las llamadas a Console.ReadLine() según la restricción.
        string? line = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(line))
            return;

        if (!int.TryParse(line.Trim(), out int n) || n <= 0)
            return;

        string? numbersLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(numbersLine))
            return;

        var parts = numbersLine.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        int max = int.MinValue;
        int seen = 0;
        foreach (var p in parts)
        {
            if (seen >= n) break;
            if (int.TryParse(p, out int v))
            {
                if (v > max) max = v;
                seen++;
            }
        }

        // Si por alguna razón no se encontraron números, no imprimir nada.
        if (seen > 0)
            Console.WriteLine(max);
    }
}


// --- FIN DE LÓGICA DEL ALUMNO ---

// 2. Salida: Lo que el Autograding comparará
Console.WriteLine(maximo);
