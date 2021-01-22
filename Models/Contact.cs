using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tthk_contacts.Models
{
    /// <summary>
    /// Base class for whole contacts.
    /// </summary>
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set;  }
        public bool Active { get; set; }
    }   
}
