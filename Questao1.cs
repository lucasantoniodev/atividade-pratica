namespace atividade_pratica
{
    internal class Questao1
    {
        // Método capaz de ler 3 valores de entrada (A,B,C) e imprimir as raízes XI e XII
        public void Execute()
        {
            try
            {
                Console.WriteLine("Digite o valor A:");
                var a = double.Parse(Console.ReadLine()!);
                Console.WriteLine("Digite o valor B:");
                var b = double.Parse(Console.ReadLine()!);
                Console.WriteLine("Digite o valor C:");
                var c = double.Parse(Console.ReadLine()!);

                // Calculando valor de delta
                double delta = CalcDelta(a, b, c);

                if (delta < 0)
                {
                    Console.WriteLine("Impossível calcular");
                }
                else
                {

                    // Calculando valor da raíz XI
                    double raizX1 = (-b + Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine($"XI: {raizX1}");

                    // Calculando valor da raíz XII
                    double raizX2 = (-b - Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine($"XII: {raizX2}");
                }
            }
            catch
            {
                Console.WriteLine("Valor de entrada não reconhecido");
                Console.WriteLine("Encerrando programa...");
            }
        }

        // Calcular o valor de delta
        public static double CalcDelta(double a, double b, double c)
        {
            var result = Math.Pow(b, 2) - 4 * a * c;
            return result;
        }

    }
}