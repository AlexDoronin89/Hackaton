using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
    internal class Server
    {
        private List<User> _users;

        public ObservableCollection<User> Messages { get; set; }

        public event Action TakingMessage;

        public Server()
        {
            _users = new List<User>();
            Messages = new ObservableCollection<User>();
        }

        public void TakeMessage(User user)
        {
            Messages.Add(user);
            TakingMessage?.Invoke();
        }

        public bool CheckUserName(string name)
        {
            return _users.Any<User>(item => item.Sender == name) ;
        }

      
        public void AddUser(User user)
        {
            _users.Add(user);
        }
    }
}
