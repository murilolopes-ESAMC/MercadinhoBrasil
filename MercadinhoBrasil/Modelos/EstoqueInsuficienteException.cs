namespace MercadinhoBrasil.Modelos;

public class EstoqueInsuficienteException : Exception
{
    public EstoqueInsuficienteException(string mensagem) : base(mensagem)
    {
    }
}
