using CommunityToolkit.Mvvm.ComponentModel;

namespace LearnDataGrid;

public partial class User : ObservableObject
{
    public Guid Id { get; } = Guid.NewGuid();

    [ObservableProperty]
    private string? _name;
    [ObservableProperty]
    private int? _age;

   
}
