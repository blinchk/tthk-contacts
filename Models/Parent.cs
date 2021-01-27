namespace tthk_contacts.Models
{
    /// <summary>
    ///     Class for parent record.
    /// </summary>
    public class Parent : Contact
    {
        public int ChildrenId { get; set; }
    }
}