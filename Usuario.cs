using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_produtos
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public Usuario()
        {
            Cadastrar();
        }
        
        public void Cadastrar()
        {
            Console.WriteLine($"Primeiro vamos vamos cadastrar o usuario:\n");
            
            Console.WriteLine($"Digite seu nome de usuario:");
            Nome = Console.ReadLine();

            Console.WriteLine($"Digite seu email:");
            Email = Console.ReadLine();
            
            Console.WriteLine($"Digite a senha");
            Senha = Console.ReadLine();
            Console.WriteLine($"\nCadastro efetuado com sucesso\n");
        }
        public string Deletar(Usuario _usuario)
        {
            return "";
        }   
    }
}