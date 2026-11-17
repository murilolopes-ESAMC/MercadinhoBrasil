namespace MercadinhoBrasil.Modelos;

public class Produto
{
    private string nome;
    private string categoria;

    public int Id { get; set; }

    public string Nome
    {
        get
        {
            return nome;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O nome do produto é obrigatório.");
            }

            nome = value.Trim();
        }
    }

    public string Categoria
    {
        get
        {
            return categoria;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A categoria do produto é obrigatória.");
            }

            categoria = value.Trim();
        }
    }

    public decimal Preco { get; set; }

    public int Quantidade { get; private set; }

    public bool EstoqueBaixo
    {
        get
        {
            return Quantidade <= 5;
        }
    }

    public decimal ValorEmEstoque
    {
        get
        {
            return Preco * Quantidade;
        }
    }

    public Produto(string nome, string categoria, decimal preco, int quantidade)
    {
        Nome = nome;
        Categoria = categoria;
        Preco = preco;
        Quantidade = quantidade;
    }

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade <= 0)
        {
            throw new ArgumentException("A quantidade deve ser maior que zero.");
        }

        Quantidade += quantidade;
    }

    public void RemoverEstoque(int quantidade)
    {
        if (quantidade <= 0)
        {
            throw new ArgumentException("A quantidade deve ser maior que zero.");
        }

        if (quantidade > Quantidade)
        {
            throw new EstoqueInsuficienteException(
                "Estoque insuficiente de " + Nome + ". Só existem " + Quantidade + " unidades.");
        }

        Quantidade -= quantidade;
    }

    public override string ToString()
    {
        return Nome;
    }
}
