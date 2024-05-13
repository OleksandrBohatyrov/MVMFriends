namespace MVMFriends.Views;
using MVMFriends.ViewModels;
public partial class FriendListPage : ContentPage
{
	public FriendListPage()
	{
        InitializeComponent();
        BindingContext = new FriendListViewModel() { Navigation = this.Navigation };
    }
}