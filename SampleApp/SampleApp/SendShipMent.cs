
namespace SampleApp
{
    public class SendShipMent
    {

        public string  send(IContact contact)
        {
                return shipit(contact);
        }

        private string shipit(IContact contact)
        {
            return $"shipped to {contact.Address}";
           
        }
    }
}
