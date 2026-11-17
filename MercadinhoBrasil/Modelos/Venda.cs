namespace MercadinhoBrasil.Modelos;

public class Venda
{
    public int Id { get; set; }
    public DateTime DataVenda { get; set; }
    public string FormaPagamento { get; set; }

    public decimal ValorTotal { get; private set; }
    public List<ItemVenda> Itens { get; private set; }

    public Venda()
    {
        Itens = new List<ItemVenda>();
        ValorTotal = 0;
    }

    public Venda(int id, DateTime dataVenda, string formaPagamento, decimal valorTotal)
    {
        Id = id;
        DataVenda = dataVenda;
        FormaPagamento = formaPagamento;
        ValorTotal = valorTotal;
        Itens = new List<ItemVenda>();
    }

    public void AdicionarItem(Produto produto, int quantidade)
    {
        ItemVenda itemQueJaExiste = null;

        foreach (ItemVenda item in Itens)
        {
            if (item.ProdutoId == produto.Id)
            {
                itemQueJaExiste = item;
            }
        }

        if (quantidade > produto.Quantidade)
        {
            throw new EstoqueInsuficienteException(
                "Estoque insuficiente de " + produto.Nome + ". Em estoque: " + produto.Quantidade);
        }

        if (itemQueJaExiste != null)
        {
            itemQueJaExiste.AumentarQuantidade(quantidade);
        }
        else
        {
            ItemVenda novoItem = new ItemVenda(produto.Id, produto.Nome, quantidade, produto.Preco);
            Itens.Add(novoItem);
        }

        AtualizarTotal();
    }

    public void RemoverItem(int posicao)
    {
        Itens.RemoveAt(posicao);
        AtualizarTotal();
    }

    private void AtualizarTotal()
    {
        decimal total = 0;

        foreach (ItemVenda item in Itens)
        {
            total += item.Subtotal;
        }

        ValorTotal = total;
    }
}
