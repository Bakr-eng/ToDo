namespace ToDo.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string? Responsible { get; set; }
        public bool Done { get; set; }
    }
}
