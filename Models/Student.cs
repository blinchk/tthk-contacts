using System;

namespace tthk_contacts.Models
{
    /// <summary>
    ///     Class for student record.
    /// </summary>
    public class Student : Contact
    {
        public string PicturePath { get; set; }
        public int GroupId { get; set; }
        public bool Scholarship { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool DataPermission { get; set; }
    }
}