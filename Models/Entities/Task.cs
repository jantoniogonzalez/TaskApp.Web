namespace TaskApp.Web.Models.Entities
{
    public class Task
    {
        public Guid Id { set; get; }
        public string Name { set; get; }
        public Person? CreatedBy { set; get; }
        public Person? AssignedTo { set; get; }
        public bool Completed { set; get; }
        public DateTime DueDate { set; get; }
    }
}
