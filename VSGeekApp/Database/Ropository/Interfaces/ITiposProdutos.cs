using VSGeekApp.Database.Models;

namespace VSGeekApp.Database.Ropository.Interfaces;

public interface ITiposProdutos
{
    public TiposProdutos BuscarPorIdTiposProdutos(int id);
    public List<TiposProdutos> BuscarTodosTiposProdutos();
    public TiposProdutos InserirTiposProduto(TiposProdutos tiposProduto);
    public TiposProdutos AlterarTiposProduto(TiposProdutos tiposProduto);
    public TiposProdutos ExcluirTiposProduto(int id);
}