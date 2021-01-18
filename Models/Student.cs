using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tthk_contacts.Models
{
    /// <summary>
    /// Class for student record.
    /// </summary>
    class Student : Contact
    {
        public string PicturePath { get; set; }
        public int GroupId { get; set; }
        public bool Scholarship { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
