using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace projeto_produtos
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string nomeMarca { get; set; }
        public static DateTime DataCadastro { get; set; }
        public string NomeMarca { get; internal set; }

        static List<Marca> ListaDeMarca = new List<Marca>();

        public Marca Cadastrar()
        {
            Marca novaMarca = new Marca();

            Console.WriteLine($"Digite o codigo da marca:");
            novaMarca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o nome da marca:");
            novaMarca.nomeMarca = Console.ReadLine();

            ListaDeMarca.Add(novaMarca);

            Console.WriteLine($"Marca adicionada com sucesso");

            return novaMarca;
        }

        public static void Listar()
        {
            DataCadastro = DateTime.Now;
            
            if (ListaDeMarca.Count() == 0)
            {
                Console.WriteLine($"Lista vazia..");
            }
            foreach (Marca item in ListaDeMarca)
            {
                Console.WriteLine(@$"
==================================
Codigo: {item.Codigo}
Nome: {item.nomeMarca}
Hora do cadastro: {DataCadastro} 
===================================
                ");
            }
        }

        public void Deletar(int _codigo)
        {
            Marca marcaAchado = new Marca();
            marcaAchado = ListaDeMarca.Find(x => x.Codigo == _codigo);

            ListaDeMarca.Remove(marcaAchado);
            Console.WriteLine($"Marca deletada!");
        }
    }
}