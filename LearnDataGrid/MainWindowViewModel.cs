using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace LearnDataGrid;

public partial class MainWindowViewModel : ObservableObject
{
    public List<string> UserTypes { get; } = new List<string>
    {
        "Admin",
        "Standart"
    };
    public ObservableCollection<User> Users { get; } = new();

    public MainWindowViewModel()
    {
        //generate 10 random users
        var random = new Random();
        Users.Add(item: new User { Name = "Joe", Age = 3 });
        for (int i = 0; i < 10; i++)
        {
            Users.Add(item: new User { Name = $"User {i}", Age = random.Next(1, 100) });
        }
    }
    [RelayCommand]
    private void NewUser()
    {
        Users.Add(new User
        {
            Name = $"User {Users.Count}",
            Age = 3
        });
    }
    [RelayCommand]
    private void DeleteUser(User user)
    {
        Users.Remove(user);
    }

}
