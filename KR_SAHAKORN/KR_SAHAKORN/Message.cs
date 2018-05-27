using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR_SAHAKORN
{
    public class Message
    {
        public string title;
        public string description;
        public MessageBoxIcon severity;

        public Message(string title, string description, MessageBoxIcon severity)
        {
            this.title = title;
            this.description = description;
            this.severity = severity;
        }
    }
}
