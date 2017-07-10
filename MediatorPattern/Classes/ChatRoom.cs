using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Classes
{
    public class ChatRoom
    {
        public static void ShowMessage(User user, string message)
        {
            Console.WriteLine("{0} [{1}] : {2}", DateTime.Now.ToShortTimeString(), user.GetName(), message);
        }
    }
}
