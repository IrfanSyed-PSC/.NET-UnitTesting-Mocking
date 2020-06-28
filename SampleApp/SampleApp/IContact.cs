using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    // Interface for Contact
  public  interface IContact
    {
        string Name {  get; }
        string Address { get; }

        long phoneno{ get; }
    }
}
