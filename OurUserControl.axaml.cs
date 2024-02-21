using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaControls;

public partial class OurUserControl : UserControl
{
    public OurUserControl()
    {
        DataContext = new OurViewModel();
        InitializeComponent();
    }
}