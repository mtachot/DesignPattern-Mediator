using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Classes
{
    public class User
    {
        private string Name;

        public string GetName()
        {
            return this.Name;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public User(string name)
        {
            this.Name = name;
        }

        public void SendMessage(string message)
        {
            ChatRoom.ShowMessage(this, message);
        }
    }
}
