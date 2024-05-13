using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVMFriends.Models;

namespace MVMFriends.ViewModels
{
    public class FriendViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        FriendListViewModel lvm;
        public Friend Friend { get; private set; }

        public FriendViewModel()
        {
            Friend = new Friend();
        }
        public FriendListViewModel ListViewModel
        {
            get { return lvm; }
            set
            {
                if (lvm != value)
                {
                    lvm = value;
                    OnPropertyChanged("ListViewModel");
                }
            }
        }
        public string Name
        {
            get { return Friend.Name; }
            set
            {
                if (Friend.Name != value)
                {
                    Friend.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        //public string SecondName
        //{
        //    get { return Friend.SecondName; }
        //    set
        //    {
        //        if (Friend.SecondName != value)
        //        {
        //            Friend.SecondName = value;
        //            OnPropertyChanged("SecondName");
        //        }
        //    }
        //}
        public string Email
        {
            get { return Friend.Email; }
            set
            {
                if (Friend.Email != value)
                {
                    Friend.Email = value;
                    OnPropertyChanged("Email");
                }
            }
        }
        //public string Phone
        //{
        //    get { return friend.Phone; }
        //    set
        //    {
        //        if (friend.Phone != value)
        //        {
        //            friend.Phone = value;
        //            OnPropertyChanged("Phone");
        //        }
        //    }
        //}

        public bool IsValid
        {
            get
            {
                return ((!string.IsNullOrEmpty(Name.Trim())) ||

                 //(!string.IsNullOrEmpty(SecondName.Trim())) ||
                 //(!string.IsNullOrEmpty(Phone.Trim())) ||
                 (!string.IsNullOrEmpty(Email.Trim())));
            }
        }
        protected void OnPropertyChanged(string propNmae)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propNmae));
        }


    }
}
