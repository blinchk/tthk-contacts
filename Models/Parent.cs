using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tthk_contacts.Models
{
    /// <summary>
    /// Class for parent record.
    /// </summary>
    class Parent : Contact
    {
        public int ChildrenId { get; set; }
    }
}
