using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger_TEB_MAUI.Models
{
    public class Message
    {
        public string Sender { get; set; }
        public string Text { get; set; }
        public bool IsSentByUser { get; set; }
    }
}
