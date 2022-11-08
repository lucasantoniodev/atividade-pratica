namespace atividade_pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Questões ==========");
            Console.WriteLine("1 - Calcular raízes de uma equação utilizando fórmula de Bhaskara, tendo como entrada os três primeiros dígitos do RU");
            Console.WriteLine("2 - Exibir dados de um produto em estoque");
            Console.WriteLine("3 - Imprimir números primos existentes de 0 até N, onde N é os dois últimos dígidos do RU");
            Console.WriteLine("\nEscolha uma questão: ");
            var questao = Console.ReadLine();
            while (true)
            {
                switch (questao)
                {
                    case "1":
                        // Raízes de uma equação utilizando fórmula de Bhaskara
                         Console.WriteLine("========== Questão 1 ==========");
                         Console.WriteLine("Calcular raízes de uma equação utilizando fórmula de Bhaskara, tendo como entrada os três primeiros dígitos do RU");
                         Questao1 q1 = new();
                        // 3,7,8
                        q1.Execute();
                        Console.WriteLine("===============================");
                        break;
                    case "2":
                        // Exibir dados de um produto em estoque
                        Console.WriteLine("========== Questão 2 ==========");
                        Console.WriteLine("Exibir dados de um produto em estoque");
                        Questao2 q2 = new();
                        q2.Execute();
                        Console.WriteLine("===============================");
                        break;
                    case "3":
                        // Imprimir números primos existentes de 0 até N, onde N é os dois últimos dígidos do RU
                        Console.WriteLine("========== Questão 3 ==========");
                        Console.WriteLine("Imprimir números primos existentes de 0 até N, onde N é os dois últimos dígidos do RU");
                        Questao3 q3 = new();
                        q3.Execute();
                        Console.WriteLine("===============================");
                        break;
                    default:
                        Console.WriteLine("Nenhuma questão escolhida, fechando programa...");
                        break;
                }

                break;
            }         
        }
    }
}
