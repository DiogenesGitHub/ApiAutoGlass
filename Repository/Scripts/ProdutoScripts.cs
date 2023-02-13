namespace AutoGlass.Repository.Scripts
{
    internal class ProdutoScripts
    {
        internal static string Select =>
            @" SELECT
            ID_PRODUTO AS ID,
            COD_PRODUTO AS  CODIGOPRODUTO,			
            DESC_PRODUTO  AS  DESCRICAOPRODUTO,		
            SITUACAO_PRODUTO   AS  SITUACAOPRODUTO,	
            DH_FABRICACAO  AS  DATAFABRICACAO,			
            DH_VALIDADE  AS  DATAVALIDADE,			
            COD_FORNECEDOR AS  CODIGOFORNECEDOR,			
            DESC_FORNECEDOR  AS  DESCRICAOFORNECEDOR,		
            CNPJ  AS  CNPJ
            FROM AUTOGLASS..PRODUTO";

        internal static string SelectById =>
            @" SELECT 
            ID_PRODUTO AS ID,
            COD_PRODUTO AS  CODIGOPRODUTO,			
            DESC_PRODUTO  AS  DESCRICAOPRODUTO,		
            SITUACAO_PRODUTO   AS  SITUACAOPRODUTO,	
            DH_FABRICACAO  AS  DATAFABRICACAO,			
            DH_VALIDADE  AS  DATAVALIDADE,			
            COD_FORNECEDOR AS  CODIGOFORNECEDOR,			
            DESC_FORNECEDOR  AS  DESCRICAOFORNECEDOR,		
            CNPJ  AS  CNPJ
            FROM AUTOGLASS..PRODUTO 
            WHERE 1=1
            AND COD_PRODUTO =  @COD_PRODUTO";

        internal static string Insert =>
            @" INSERT INTO AUTOGLASS..PRODUTO 
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
            @" UPDATE AUTOGLASS..PRODUTO SET
            COD_PRODUTO  = @COD_PRODUTO	,
            DESC_PRODUTO = @DESC_PRODUTO ,	
            SITUACAO_PRODUTO = @SITUACAO_PRODUTO ,
            DH_FABRICACAO = @DH_FABRICACAO ,
            DH_VALIDADE = @DH_VALIDADE ,
            COD_FORNECEDOR = @COD_FORNECEDOR ,
            DESC_FORNECEDOR = @DESC_FORNECEDOR ,
            CNPJ = @CNPJ
            WHERE 1=1
            AND COD_PRODUTO = @COD_PRODUTO";

        internal static string DeleteById =>
            @" UPDATE AUTOGLASS..PRODUTO SET 
            SITUACAO_PRODUTO = 0 
            WHERE 1=1 
            AND COD_PRODUTO  = @COD_PRODUTO";
    }
}