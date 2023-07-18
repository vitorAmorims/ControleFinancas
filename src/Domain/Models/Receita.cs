using System;
using Domain.Enum;

namespace Domain.Models
{
    public class Receita
    {
        public Receita(decimal valor, CategoriaReceita categoria, string descricao)
        {
            this.Id = Guid.NewGuid();
            this.Valor = valor;
            this.Data = DateTime.Now;
            this.Categoria = categoria;
            this.Descricao = descricao;
        }

        public Guid Id {get;}
        public decimal Valor { get; private set; }
        public string Descricao { get; private set; } = string.Empty;
        public DateTime Data { get; private set; }
        public CategoriaReceita Categoria { get; private set; }
    }
}