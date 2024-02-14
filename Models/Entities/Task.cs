namespace TaskApp.Web.Models.Entities
{
    public class Task
    {
        public Guid Id { set; get; }
        public string Name { set; get; }
        public int? CreatedBy { set; get; }
        public int? AssignedTo { set; get; }
        public bool Completed { set; get; }
        public DateTime DueDate { set; get; }
    }
}
