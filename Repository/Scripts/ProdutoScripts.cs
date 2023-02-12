namespace AutoGlass.Repository.Scripts
{
    internal class ProdutoScripts
    {
        internal static string Select =>
            @" SELECT * FROM PRODUTO";

        internal static string SelectById =>
            @" SELECT * FROM PRODUTO 
            WHERE COD_PRODUTO =  @COD_PRODUTO";

        internal static string Insert =>
            @" INSERT INTO PRODUTO 
            VALUES 
            (@COD_PRODUTO, 
            @DESC_PRODUTO,
            @SITUACAO_PRODUTO,
            @DH_FABRICACAO,
            @DH_VALIDADE,
            @COD_FORNECEDOR,
            @DESC_FORNECEDOR, 
            @CNPJ)";

        internal static string UpdateById =>
            @" UPDATE PRODUTO SET
            COD_PRODUTO  = @COD_PRODUTO	
            DESC_PRODUTO = @DESC_PRODUTO	
            SITUACAO_PRODUTO = @SITUACAO_PRODUTO
            DH_FABRICACAO = @DH_FABRICACAO
            DH_VALIDADE = @DH_VALIDADE
            COD_FORNECEDOR = @COD_FORNECEDOR
            DESC_FORNECEDOR = @DESC_FORNECEDOR
            CNPJ = @CNPJ
            WHERE COD_PRODUTO = @COD_PRODUTO";

        internal static string DeleteById =>
            @" UPDATE PRODUTO SET 
            SITUACAO_PRODUTO = 0 
            WHERE COD_PRODUTO  = @COD_PRODUTO";
    }
}
