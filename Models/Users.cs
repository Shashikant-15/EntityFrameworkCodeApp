using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCodeApp.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string address { get; set; }

    }
}
