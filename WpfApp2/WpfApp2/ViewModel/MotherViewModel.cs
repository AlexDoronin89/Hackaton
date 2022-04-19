using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Model;
using WpfApp2.Model.Tools;
using WpfApp2.View;

namespace WpfApp2.ViewModel
{
    internal class MotherViewModel : INotifyPropertyChanged
    {
        private CommandTemplate _createChat;
        private string _userName;
        private Server _server;

        public MotherViewModel()
        {
            _server = new Server();
        //    _messages = new ObservableCollection<User>;
        }

       

        public string UserName
        {
            get { return _userName; }
            set 
            {
                _userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        public void AddChat(object obj)
        {
            if (string.IsNullOrWhiteSpace(UserName)  || _server.CheckUserName(UserName) == false)
            {
                return;
            }

            User sender = new User { Sender = UserName };
            _server.AddUser(sender);
            
            MainWindow chat = new MainWindow();
            ChatViewModel chatViewModel = new ChatViewModel(sender);
            
            chat.DataContext = chatViewModel;
            chatViewModel.SendingMessage += OnSendingMessage;
            //_server.TakingMessage += chatViewModel.OnTakingMessage;
            chat.Show();
            
        }
       

        public void OnSendingMessage(User user)
        {
            _server.TakeMessage(user);
        }

        public void OnTakingMessage()
        {

        }

        #region Commands
        public CommandTemplate CreateChat
        {
            get
            {
                if (_createChat == null)
                {
                    _createChat = new CommandTemplate(AddChat);
                }
                return _createChat;
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
