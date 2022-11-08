namespace atividade_pratica
{
    internal class Questao2
    {
        // Método capaz de atualizar os dados (adicionar e remover) de um determinado produto
        public void Execute()
        {
            Produto produto1 = new Produto("TV", 900.00, 10);

            Console.WriteLine($"<------ Dados do produto ------>");
            Console.WriteLine($"Nome: {produto1.Nome}");
            Console.WriteLine($"Preço (und): ${produto1.Preco}");
            Console.WriteLine($"Quantidade em estoque: {produto1.Quantidade}");
            Console.WriteLine($"Preço total em estoque: ${produto1.ValorTotalEmEstoque()}");

            Console.WriteLine();


            // Abrindo menu de opções (Adicionar e remover estoque) para o usuário 
            while (true)
            {
                Console.WriteLine("<------ Menu de opções ------>");
                Console.WriteLine("1 - Adicionar produtos");
                Console.WriteLine("2 - Remover produtos");
                Console.WriteLine("3 - Encerrar programa");

                var opcao = Console.ReadLine();
                Console.WriteLine();

                if (opcao == "1")
                {
                    try
                    {
                        Console.WriteLine("Insira a quantidade de elementos a ser adicionados:");
                        var value = Console.ReadLine();
                        Console.WriteLine();
                        var quantidade = int.Parse(value!);
                        produto1.AdicionarProduto(quantidade);
                    }
                    catch
                    {
                        Console.WriteLine("Valor inválido, tente novamente!");
                        Console.WriteLine("Encerrando programa....");
                        break;
                    }

                }
                else if (opcao == "2")
                {
                    try
                    {
                        Console.WriteLine("Insira a quantidade de elementos a ser removidos:");
                        var value = Console.ReadLine();
                        Console.WriteLine();
                        var quantidade = int.Parse(value!);
                        produto1.RemoverProdutos(quantidade);
                    }
                    catch
                    {
                        Console.WriteLine("Valor inválido, tente novamente!");
                        Console.WriteLine("Encerrando programa....");
                        break;
                    }
                }
                else if (opcao == "3")
                {
                    Console.WriteLine("Encerrando programa...");
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida, tente novamente");
                }
            }
        }

        class Produto
        {
            public string Nome { set; get; }
            public double Preco { set; get; }
            public int Quantidade { set; get; }

            public Produto(string nome, double preco, int quantidade)
            {
                Nome = nome;
                Preco = preco;
                Quantidade = quantidade;
            }

            public double ValorTotalEmEstoque()
            {
                return Preco * Quantidade;
            }

            public void AdicionarProduto(int quantidade)
            {
                if (quantidade <= 0)
                {
                    Console.WriteLine("Quantidade a ser adicionada inválida, digite um valor maior que 0");
                    Console.WriteLine();
                    return;
                }

                Quantidade += quantidade;

                Console.WriteLine("Dados atualizado: ");
                Console.WriteLine($"Nome: {Nome}");
                Console.WriteLine($"Preço (und): ${Preco}");
                Console.WriteLine($"Quantidade em estoque: {Quantidade}");
                Console.WriteLine($"Preço total em estoque: ${ValorTotalEmEstoque()}");
                Console.WriteLine();
            }

            public void RemoverProdutos(int quantidade)
            {
                if (quantidade <= 0)
                {
                    Console.WriteLine("Quantidade a ser removido inválida, digite um valor maior que 0");
                    Console.WriteLine();
                    return;
                }

                Quantidade -= quantidade;

                Console.WriteLine("Dados atualizado: ");
                Console.WriteLine($"Nome: {Nome}");
                Console.WriteLine($"Preço (und): ${Preco}");
                Console.WriteLine($"Quantidade em estoque: {Quantidade}");
                Console.WriteLine($"Preço total em estoque: ${ValorTotalEmEstoque()}");
                Console.WriteLine();
            }
        }
    }
}
