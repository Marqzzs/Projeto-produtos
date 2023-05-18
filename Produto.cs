using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_produtos;

namespace projeto_produtos
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public string CadastradoPor;
        Usuario user = new Usuario();
        List<Produto> ListaDeProduto = new List<Produto>();
        public void Cadastrar()
        {
            Produto produto = new Produto();

            Console.WriteLine($"Digite o Codigo do produto:");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o nome do produto:");
            produto.NomeProduto = Console.ReadLine();

            Console.WriteLine($"Digite o preço do produto:");
            produto.Preco = float.Parse(Console.ReadLine());

            produto.Marca = Marca.Cadastrar();   

            ListaDeProduto.Add(produto);
        }
        public void Listar()
        {
            CadastradoPor = user.Nome;
            DataCadastro = DateTime.Now;

            foreach (Produto p in ListaDeProduto)
            {
                Console.WriteLine(@$"
===============================
Codigo: {p.Codigo}
Nome: {p.NomeProduto}
Preco: {p.Preco}
Marca: 
Cadastro realizado por: {p.CadastradoPor}
===============================
                ");
            }

            if (ListaDeProduto.Count() == 0)
            {
                Console.WriteLine($"Lista vazia..");
            }
        }
        public void Deletar(int _codigo)
        {
            Produto produtoAchado = new Produto();
            produtoAchado = ListaDeProduto.Find(x => x.Codigo == _codigo);

            ListaDeProduto.Remove(produtoAchado);
            Console.WriteLine($"Produto deletado!");
            
        }
    }
}