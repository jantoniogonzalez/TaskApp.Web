using TaskApp.Web.Models.Entities;

namespace TaskApp.Web.Models
{
    public class AddPersonViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public Role? Role { get; set; }
    }
}
