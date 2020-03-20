using System;

namespace WpfApp.Models
{
    public class User_Model
    {
        public uint Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime TimestampCreated { get; set; }
        public DateTime TimestampLastLogin { get; set; }
    }
}
