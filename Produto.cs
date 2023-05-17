using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_produtos
{
    public class Produto
    {
        
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public Usuario CadastradoPor { get; set; }
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
            
            Console.WriteLine($"{DataCadastro}");
            
            ListaDeProduto.Add(produto);
        }
        public void Listar()
        {
            DataCadastro = DateTime.Now;
            foreach (Produto item in ListaDeProduto)
            {
                Console.WriteLine($"Codigo: {item.Codigo}\nNome: {item.NomeProduto}\nPreço: {item.Preco}\nCadastrado por: \nCadastrado no horario: {DataCadastro}\n\n ");
            }
            
        }
        public void Deletar(int _codigo)
        {
            Produto produtoAchado = new Produto();
            produtoAchado = ListaDeProduto.Find(x => x.Codigo == _codigo);

            ListaDeProduto.Remove(produtoAchado);
        }
    }
}