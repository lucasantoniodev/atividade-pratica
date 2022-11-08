namespace atividade_pratica
{
    internal class Questao3
    {
        public void Execute()
        {
            try
            {
                Console.WriteLine("Digite um número maior que 1: ");
                var resposta = Console.ReadLine();

                // Converte a resposta do usuário em um número inteiro
                var inputNumber = int.Parse(resposta!);

                if (inputNumber <= 1)
                {
                    Console.WriteLine("Digite um número maior que zero");
                    while (inputNumber <= 1)
                    {
                        Console.WriteLine("Digite um número maior que 1: ");
                        resposta = Console.ReadLine();
                        inputNumber = int.Parse(resposta!);
                    }
                }

                // Definindo o número de Threads a ser criadas em um intervalo de 10 valores
                var numberOfThreads = 1;
                if (inputNumber % 10 == 0)
                {
                    numberOfThreads = inputNumber / 10;
                }
                else
                {
                    numberOfThreads = (inputNumber / 10) + 1;
                }

                // Criando uma lista para armazenar os números primos
                List<int> listOfNumbers = new List<int>();

                // Criar uma lista para armazenar as Threads
                List<Thread> listOfThreads = new List<Thread>(numberOfThreads);

                // Popular lista de Threads
                for (int i = 1; i <= numberOfThreads; i++)
                {
                    var thread = new Thread(() =>
                    {
                        // Verificando se o número é primo, caso sim, ele imprime no console o valor
                        for (int i = 1; i <= 10; i++)
                        {
                            if (isPrime(inputNumber))
                            {
                                listOfNumbers.Add(inputNumber);
                            }

                            inputNumber--;
                        }
                    });

                    listOfThreads.Add(thread);
                }

                // Iniciando as threads e esperando a execução delas
                var count = 0;
                foreach (var thread in listOfThreads)
                {
                    thread.Start();
                    thread.Join();
                    count++;
                }
                Console.WriteLine(count);
                // Revertendo a ordem da lista
                listOfNumbers.Reverse();
                // Imprimindo os números primos
                foreach (var num in listOfNumbers)
                {
                    Console.WriteLine($"Número {num} é primo");
                }
            }
            catch
            {
                Console.WriteLine("Valor de entrada não reconhecido");
                Console.WriteLine("Encerrando programa...");
            }

        }

        // Verificar se o número é primo
        public bool isPrime(int num)
        {
            var divisores = 1;

            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    divisores++;
                }
            }

            if (divisores == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}