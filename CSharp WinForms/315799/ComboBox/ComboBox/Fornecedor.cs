using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBox
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Observacao { get; set; }

        public static List<Fornecedor> GetAll()
        {
            return new List<Fornecedor>
            {
                new Fornecedor { Id = 1, Nome = "Joaquim Pedro Soares", Observacao = "Início em fevereiro" },
                new Fornecedor { Id = 2, Nome = "Marcos Borba da Silva", Observacao = "Sem descrição" },
                new Fornecedor { Id = 3, Nome = "Martina dos Anjos", Observacao = "Lorem observação" },
                new Fornecedor { Id = 4, Nome = "Mário Roberto do Amaral", Observacao = "Fornecedor de bolachas" },
                new Fornecedor { Id = 5, Nome = "Jonathan da Silva Sauro", Observacao = "Nada a declarar" },
                new Fornecedor { Id = 6, Nome = "Maria Francisca Parker", Observacao = "Pagar adiantado" },
                new Fornecedor { Id = 7, Nome = "Roberta de Leão Moraes", Observacao = "Sem observação" }
            };
        }
    }
}
