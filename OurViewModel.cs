using System.Collections.ObjectModel;

namespace AvaloniaControls;

public class OurViewModel
{
    public ObservableCollection<TemplateViewModel> TemplatedViewModels { get; set; } =
        new ObservableCollection<TemplateViewModel>();
    public OurViewModel()
    {
        TemplatedViewModels.Add(new TemplateViewModel
        {
            Name = "Scene",
            Content = "Some scene settings",
            CheckboxVisible = false,
        });
        TemplatedViewModels.Add(new TemplateViewModel
        {
            Name = "Units",
            Content = "Fancy physical units",
            CheckboxVisible = false,
        });
        TemplatedViewModels.Add(new TemplateViewModel
        {
            Name = "Gravity",
            Content = "Are you falling down?",
            CheckboxVisible = true,
        });
    }
}