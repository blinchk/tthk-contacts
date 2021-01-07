﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tthk_contacts.Models
{
    class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set;  }
        public string PicturePath { get; set; }
        public int GroupId { get; set; }
        public bool Scholarship { get; set; }
    }
}
