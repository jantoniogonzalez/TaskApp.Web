namespace TaskApp.Web.Models.Entities
{
    public class Person
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public int? RoleId { get; set; }
    }
}
