using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApp;


namespace SampleApp

/**
 *  Simple class that prints Contact details
 */
{
    public class Contact: IContact
    {

        private string v_Name;
        private string v_address;
        private long v_phoneno;

       public Contact(string v_name, string v_address, long v_phoneno )
        {
            this.v_Name = v_name;
            this.v_address = v_address;
            this.v_phoneno = v_phoneno;
        }

        public Contact(IContact contact)
        {
        }

        public Contact()
        {

        }

      public string[] givedefaults(Contact contact)
        {
            this.getname();
            int postcalcode = contact.getpostalcode();
            string[] defaults = new string[] { "DefaultName", "DefaultAddress", postcalcode.ToString ()};
            return defaults;
        }

        public string printname()
        {
           return  this.getname();
        }


        public virtual int getpostalcode()
        {

            throw new NotImplementedException();
        }       

        public virtual string getname()
        {

            throw new NotImplementedException();
        }


        public string Name
        {
            get { return v_Name; }
            
        }

        public string Address
        {
            get { return v_address;  }
        }

        public long phoneno
        {
            get { return v_phoneno;  }
        }
    }
}
