using System.ComponentModel;
using System.Runtime.CompilerServices;
using VSGeekApp.Database.Models;
using VSGeekApp.ViewModel.Base;

namespace VSGeekApp.Model.Response;

public class TiposProdutosResponse : TiposProdutos, INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string name = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
    
    private bool _isSelected { get; set; }
    public bool IsSelected
    {
        get => _isSelected;
        set
        {
            if (_isSelected != value)
            {
                _isSelected = value;
                OnPropertyChanged();
            }
        }
    }
    
    private Color _colorBorder { get; set; }
    public Color ColorBorder
    {
        get => _colorBorder;
        set
        {
            if (_colorBorder != value)
            {
                _colorBorder = value;
                OnPropertyChanged();
            }
        }
    }
    
    private Color _colorStrokeBorder { get; set; }
    public Color ColorStrokeBorder
    {
        get => _colorStrokeBorder;
        set
        {
            if (_colorStrokeBorder != value)
            {
                _colorStrokeBorder = value;
                OnPropertyChanged();
            }
        }
    }
    
    private Color _colorText { get; set; }
    public Color ColorText
    {
        get => _colorText;
        set
        {
            if (_colorText != value)
            {
                _colorText = value;
                OnPropertyChanged();
            }
        }
    }
}