using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaControls;

public partial class TemplateViewModel : ObservableObject
{
    [ObservableProperty] private string _name = String.Empty;
    [ObservableProperty] private bool _isChecked;
    [ObservableProperty] private bool _checkboxVisible; 
    [ObservableProperty] private string _content = String.Empty;
}