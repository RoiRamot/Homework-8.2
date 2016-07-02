using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSystem
{

        class MailArrivedEventArgs : EventArgs
        {
            public string Title { get; private set; }
            public string Body { get; private set; }

            public MailArrivedEventArgs(string title, string body)
            {
                Title = title;
                Body = body;
            }

            public void SetTitle(string title)
            {
                Title = string.IsNullOrEmpty(title) ? "There is no title" : title;
            }

            public void SetBody(string body)
            {
                Body = string.IsNullOrEmpty(body) ? "There is no Body" : body;
            }
        }
    
}
