using SampleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
   public  class PrintContacts
    {

        private Contact contact;
        public PrintContacts(Contact contact)
        {
            this.contact = contact;
        }

        public string name()
        {
            return contact.Name;
        }
    }
}
