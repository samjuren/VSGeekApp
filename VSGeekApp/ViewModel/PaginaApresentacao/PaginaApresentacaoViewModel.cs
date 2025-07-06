using System.Collections.ObjectModel;
using VSGeekApp.Database.Models;
using VSGeekApp.Model.Response;
using VSGeekApp.ViewModel.Base;

namespace VSGeekApp.ViewModel.PaginaApresentacao;

public class PaginaApresentacaoViewModel : ViewModelBase
{
    private ObservableCollection<TiposProdutosResponse> _tiposProdutosList { get; set; } = new();

    public ObservableCollection<TiposProdutosResponse> TiposProdutosList
    {
        get => _tiposProdutosList;
        set
        {
            if (_tiposProdutosList != value)
            {
                _tiposProdutosList = value;
                OnPropertyChanged();
            }
        }
    }

    public PaginaApresentacaoViewModel()
    {
        CarregaTiposProdutos();
    }
    private ObservableCollection<TiposProdutosResponse> CarregaTiposProdutos()
    {
        ObservableCollection<TiposProdutosResponse> listaTiposProdutos = new();

        listaTiposProdutos.Add(new TiposProdutosResponse
        {
            IdProduto = 0,
            NomeProduto = "Todos",
            DataAlteracao = DateTime.Now,
            DataCadastro = DateTime.Now,
            IsSelected = true,
            ColorBorder = Color.FromArgb("#e11d48"),
            ColorText = Colors.White,
            ColorStrokeBorder = Color.FromArgb("#e11d48")
        });

        listaTiposProdutos.Add(new TiposProdutosResponse
        {
            IdProduto = 1,
            NomeProduto = "Marvel",
            DataAlteracao = DateTime.Now,
            DataCadastro = DateTime.Now,
            IsSelected = false,
            ColorBorder = Color.FromArgb("#333"),
            ColorText = Colors.White,
            ColorStrokeBorder = Color.FromArgb("#e11d48")
        });

        listaTiposProdutos.Add(new TiposProdutosResponse
        {
            IdProduto = 2,
            NomeProduto = "DC",
            DataAlteracao = DateTime.Now,
            DataCadastro = DateTime.Now,
            IsSelected = false,
            ColorBorder = Color.FromArgb("#333"),
            ColorText = Colors.White,
            ColorStrokeBorder = Color.FromArgb("#e11d48")
        });

        listaTiposProdutos.Add(new TiposProdutosResponse
        {
            IdProduto = 3,
            NomeProduto = "Animes",
            DataAlteracao = DateTime.Now,
            DataCadastro = DateTime.Now,
            IsSelected = false,
            ColorBorder = Color.FromArgb("#333"),
            ColorText = Colors.White,
            ColorStrokeBorder = Color.FromArgb("#e11d48")
        });

        listaTiposProdutos.Add(new TiposProdutosResponse
        {
            IdProduto = 4,
            NomeProduto = "Séries",
            DataAlteracao = DateTime.Now,
            DataCadastro = DateTime.Now,
            IsSelected = false,
            ColorBorder = Color.FromArgb("#333"),
            ColorText = Colors.White,
            ColorStrokeBorder = Color.FromArgb("#e11d48")
        });

        listaTiposProdutos.Add(new TiposProdutosResponse
        {
            IdProduto = 5,
            NomeProduto = "Dorama",
            DataAlteracao = DateTime.Now,
            DataCadastro = DateTime.Now,
            IsSelected = false,
            ColorBorder = Color.FromArgb("#333"),
            ColorText = Colors.White,
            ColorStrokeBorder = Color.FromArgb("#e11d48")
        });

        TiposProdutosList = listaTiposProdutos;

        return listaTiposProdutos;
    }
    public void CliqueListaTiposProdutos(TiposProdutosResponse model)
    {
        foreach (var item in TiposProdutosList)
        {
            item.IsSelected = false;
            item.ColorBorder = Color.FromArgb("#333");
        }
        
        model.IsSelected = true;
        model.ColorBorder = Color.FromArgb("#e11d48");
    }
}