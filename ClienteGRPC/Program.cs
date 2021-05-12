using Grpc.Net.Client;
using System;
using Protos;
using System.Threading.Tasks;

namespace ClienteGRPC
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);


            var continuar = true;
            while (continuar)
            {
                var opcoes = $@"
                            --------------------------------------------------
                            Selecione a operação desejada
                            1 - Criar Livro
                            2 - Consultar Livro
                            3 - Consultar por ano e número da edição
                            4 - Remover Livro
                            5 - Alterar Livro
                            0 - Sair
                            ---------------------------------------------------
                            Digite a opção:";

                Console.WriteLine(opcoes);

                var opcaoEscolhida = (eOpcaoEscolhida)Convert.ToInt32(Console.ReadLine());

                switch (opcaoEscolhida)
                {
                    case eOpcaoEscolhida.CriarLivro:
                        CriarLivro(client);
                        break;
                    case eOpcaoEscolhida.ConsultarLivro:
                        ConsultarLivroPorAutor(client);
                        break;
                    case eOpcaoEscolhida.ConsultarPorAnoNumeroEdicao:
                        ConsultarLivroPorAnoNumeroEdicao(client);
                        break;
                    case eOpcaoEscolhida.RemoverLivro:
                        RemoverLivroPorNome(client);
                        break;
                    case eOpcaoEscolhida.AlterarLivro:
                        AlterarLivro(client);
                        break;
                    case eOpcaoEscolhida.Sair:
                        continuar = false;
                        break;
                }

            }

            Console.WriteLine("Digite qualquer tecla para sair!");
            Console.ReadKey();
        }

        public static void CriarLivro(Greeter.GreeterClient client)
        {
            Console.WriteLine("Digite o Titulo:");
            var titulo = Console.ReadLine();
            Console.WriteLine("Digite o Autor:");
            var autor = Console.ReadLine();
            Console.WriteLine("Digite o Número:");
            var numero = Console.ReadLine();
            Console.WriteLine("Digite o Ano:");
            var ano = Convert.ToInt32(Console.ReadLine());

            var reply = client.CriarLivro(
                              new CriarLivroRequest { Titulo = titulo, Autor = autor, NumeroEdicao = numero, AnoEdicao = ano });

            Console.WriteLine("Resultado:");
            Console.WriteLine(reply);
        }

        public static void ConsultarLivroPorAutor(Greeter.GreeterClient client)
        {
            Console.WriteLine("Digite a consulta:");

            var reply = client.ConsultarLivroPorTitulo(
                              new ConsultarLivroPorTituloRequest { Titulo = Console.ReadLine() });

            Console.WriteLine("Resultado:");
            Console.WriteLine(reply);
        }

        public static void ConsultarLivroPorAnoNumeroEdicao(Greeter.GreeterClient client)
        {
            Console.WriteLine("Digite o ano:");
            var ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o número da edição");
            var numero = Console.ReadLine();
            var reply = client.ConsultarPorAnoENumero(
                              new ConsultarPorAnoENumeroRequest { Ano = ano, Numero = numero });

            Console.WriteLine("Resultado:");
            Console.WriteLine(reply);
        }

        public static void RemoverLivroPorNome(Greeter.GreeterClient client)
        {
            Console.WriteLine("Digite o titulo:");
            var titulo = Console.ReadLine();
            var reply = client.RemoverLivro(
                              new RemoverLivroRequest { Titulo = titulo});

            Console.WriteLine("Resultado:");
            Console.WriteLine(reply);
        }
        public static void AlterarLivro(Greeter.GreeterClient client)
        {
            Console.WriteLine("Digite o código do livro:");
            var codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o novo titulo do livro");
            var titulo = Console.ReadLine();
            Console.WriteLine("Digite o novo número da edição do livro");
            var edicao = Console.ReadLine();
            Console.WriteLine("Digite o novo ano do livro");
            var ano = Convert.ToInt32(Console.ReadLine());

            var reply = client.AtualizarLivro(
                              new AtualizarLivroRequest {Codigo = codigo, Titulo = titulo, AnoEdicao = ano, NumeroEdicao = edicao});

            Console.WriteLine("Resultado:");
            Console.WriteLine(reply);
        }


            
    }
}
