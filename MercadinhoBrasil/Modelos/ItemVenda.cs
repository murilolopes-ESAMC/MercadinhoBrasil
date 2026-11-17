namespace MercadinhoBrasil.Modelos;

public class ItemVenda
{
    public int ProdutoId { get; private set; }
    public string NomeProduto { get; private set; }
    public int Quantidade { get; private set; }
    public decimal PrecoUnitario { get; private set; }

    public decimal Subtotal
    {
        get
        {
            return Quantidade * PrecoUnitario;
        }
    }

    public ItemVenda(int produtoId, string nomeProduto, int quantidade, decimal precoUnitario)
    {
        if (quantidade <= 0)
        {
            throw new ArgumentException("A quantidade deve ser maior que zero.");
        }

        ProdutoId = produtoId;
        NomeProduto = nomeProduto;
        Quantidade = quantidade;
        PrecoUnitario = precoUnitario;
    }

    public void AumentarQuantidade(int quantidade)
    {
        if (quantidade <= 0)
        {
            throw new ArgumentException("A quantidade deve ser maior que zero.");
        }

        Quantidade += quantidade;
    }
}
