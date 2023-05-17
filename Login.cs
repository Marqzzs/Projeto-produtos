using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_produtos
{
    public class Login
    {
        public bool Logado { get; set; }
        ConsoleKeyInfo opcao;

        public Login()
        {
            Usuario user = new Usuario();

            Logar(user);

            if (Logado == true)
            {
                GerarMenu();
            }
        }
        public void Logar(Usuario _usuario)
        {
            Console.WriteLine($"Agora só fazer o login\n");
            Console.WriteLine($"Digite seu email:");
            string email = Console.ReadLine();

            Console.WriteLine($"Digite a senha:");
            string senha = Console.ReadLine();
            Console.WriteLine($"");
            if (email == _usuario.Email && senha == _usuario.Senha)
            {
                this.Logado = true;
                Console.WriteLine($"Login efetuado");

            }
            else
            {
                this.Logado = false;
                Console.WriteLine($"Falha ao logar");
            }
        }
        public void Deslogar(Usuario _usuario)
        {

        }

        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            do
            {
                Console.WriteLine(@$"
            [1] - Cadastrar produto
            [2] - Listar produto
            [3] - Excluir produto
            -------------------------
            [4] - Cadastrar marca
            [5] - Listar marca
            [6] - Excluir marca
            
            [0] - Sair
            ");

                opcao = Console.ReadKey(true);

                switch (opcao.Key)
                {
                    case ConsoleKey.D1:
                        produto.Cadastrar();
                        break;

                    case ConsoleKey.D2:
                        produto.Listar();
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine($"Digite o codigo do produto a ser deletado:");
                        int codigoProduto = int.Parse(Console.ReadLine());
                        produto.Deletar(codigoProduto);
                        break;

                    case ConsoleKey.D4:
                        marca.Cadastrar();
                        break;

                    case ConsoleKey.D5:
                        marca.Listar();
                        break;

                    case ConsoleKey.D6:
                        Console.WriteLine($"Digite o codigo da marca a ser deletada:");
                        int codigoMarca = int.Parse(Console.ReadLine());
                        produto.Deletar(codigoMarca);
                        break;

                    case ConsoleKey.D0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine($"Opção invalida");
                        break;
                }
            } while (true);

        }
    }
}