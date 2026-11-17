using Npgsql;

namespace MercadinhoBrasil.Dados;

public static class Conexao
{
    private const string Servidor = "localhost";
    private const string Porta = "5432";
    private const string Banco = "mercadinho_brasil";
    private const string Usuario = "mercadinho";
    private const string Senha = "mercadinho123";

    private static string MontarTextoDeConexao()
    {
        string texto = "Host=" + Servidor + ";"
                     + "Port=" + Porta + ";"
                     + "Database=" + Banco + ";"
                     + "Username=" + Usuario + ";"
                     + "Password=" + Senha + ";";

        return texto;
    }

    public static NpgsqlConnection AbrirConexao()
    {
        NpgsqlConnection conexao = new NpgsqlConnection(MontarTextoDeConexao());
        conexao.Open();
        return conexao;
    }

    public static string TestarConexao()
    {
        try
        {
            using (NpgsqlConnection conexao = AbrirConexao())
            {
                return "";
            }
        }
        catch (Exception erro)
        {
            return erro.Message;
        }
    }
}
