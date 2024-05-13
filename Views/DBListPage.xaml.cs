using MVMFriends.Models;
using MVMFriends.ViewModels;
using System;
namespace MVMFriends.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]

public partial class DbListPage : ContentPage
{
    public DbListPage()
    {
        InitializeComponent();
    }
    protected override void OnAppearing()
    {
        friendsList.ItemsSource = App.Database.GetItems();
        base.OnAppearing();
    }
    private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Friend selectedFriend = (Friend)e.SelectedItem;
        DBFriendPage friendPage = new DBFriendPage();
        friendPage.BindingContext = selectedFriend;
        await Navigation.PushAsync(friendPage);
    }
    private async void CreateFriend(object sender, EventArgs e)
    {
        Friend friend = new Friend();
        DBFriendPage friendPage = new DBFriendPage();
        friendPage.BindingContext = friend;
        await Navigation.PushAsync(friendPage);
    }
}