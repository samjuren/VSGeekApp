using VSGeekApp.Database.Models;
using VSGeekApp.Database.Ropository.Interfaces;

namespace VSGeekApp.Database.Ropository;

public class TiposProdutosRepository : ITiposProdutos
{
    public TiposProdutosRepository()
    {
        
    }
    
    public TiposProdutos BuscarPorIdTiposProdutos(int id)
    {
        throw new NotImplementedException();
    }

    public List<TiposProdutos> BuscarTodosTiposProdutos()
    {
        throw new NotImplementedException();
    }

    public TiposProdutos InserirTiposProduto(TiposProdutos tiposProduto)
    {
        throw new NotImplementedException();
    }

    public TiposProdutos AlterarTiposProduto(TiposProdutos tiposProduto)
    {
        throw new NotImplementedException();
    }

    public TiposProdutos ExcluirTiposProduto(int id)
    {
        throw new NotImplementedException();
    }
}