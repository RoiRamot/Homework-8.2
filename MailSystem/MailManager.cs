using System;
using System.Globalization;

namespace MailSystem
{
    class MailManager
    {
        //public EventHandler<MailArrivedEventArgs> MailArrived;
        public event EventHandler<MailArrivedEventArgs> MailArrived;

        private int _id;
        protected virtual void OnMailArrived(MailArrivedEventArgs e)
        {
            EventHandler<MailArrivedEventArgs> handler = MailArrived;

            if (handler!=null)
            {
                handler(this, e);
            }
            Console.WriteLine();
            Console.WriteLine("mail arrived at: {0}" ,DateTime.Now.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("Title: {0}", e.Title);
            Console.WriteLine("Body: {0}", e.Body);
 
        }
        public void SimulateMailArrival()
        {
            string[] title = { "Hi", "Bye", "123","", null };
            string[] body = { "Hello world", "Body", "9988765451234", "", null };
            if (string.IsNullOrEmpty(title[_id]))
            {
                title[_id] = "title is unavailable";
            }
            if (string.IsNullOrEmpty(body[_id]))
            {
                body[_id] = "body is unavailable";
            }
            OnMailArrived(new MailArrivedEventArgs(title[_id],body[_id]));
            _id++;
            if (_id ==5)
            {
                _id = 0;
            }
        }
    }
}
