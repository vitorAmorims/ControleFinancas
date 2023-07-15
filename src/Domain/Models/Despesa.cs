using System;
using Domain.Enum;

namespace Domain.Models
{
  public class Despesa
  {
    public Despesa(decimal valor, DateTime data, CategoriaDespesa categoria)
    {
      this.Valor = valor;
      this.Data = data;
      this.Categoria = categoria;

    }
    public decimal Valor { get; private set; }
    public string Descricao { get; private set; }
    public DateTime Data { get; private set; }
    public CategoriaDespesa Categoria { get; private set; }
  }
}