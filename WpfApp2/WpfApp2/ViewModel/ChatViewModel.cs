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

namespace WpfApp2.ViewModel
{
     class ChatViewModel : INotifyPropertyChanged
    {
        private User _sender;

        private string _currentMessage;
        private string _currentSender;


        private CommandTemplate _sendMessageCommand;

        private ObservableCollection<User> _cashMessages;

        public ObservableCollection<User> CashMessages;


        public string CurrentMessage
        {
            get => _currentMessage;
            set
            {
                _currentMessage = value;
                OnPropertyChanged(nameof(CurrentMessage));
            }

        }

        public string CurrentSender
        {
            get => _currentSender;
            set
            {
                _currentSender=value;
                OnPropertyChanged(nameof(CurrentSender));
            }
        }


        public ChatViewModel(User user)
        {
            _sender = user;
        }

        #region Commands

        public CommandTemplate SendMessageCommand
        {
            get
            {
                if (_sendMessageCommand == null)
                {
                    _sendMessageCommand = new CommandTemplate(Send);
                }
                return _sendMessageCommand;
            }
        }
        #endregion

        public void Send(object obj)
        {
            User users =new User {Message=CurrentMessage, Sender=CurrentSender };
            SendingMessage?.Invoke(users);
        }

        public void OnTakingMessage(ObservableCollection<User> messages)
        {
            //_cashMessage = new ObservableCollection<User>(messages);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event Action<User> SendingMessage;
        public event Func<ObservableCollection<User>> GettingMessage;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
