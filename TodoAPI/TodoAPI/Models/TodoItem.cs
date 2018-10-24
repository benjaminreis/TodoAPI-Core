namespace TodoAPI.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }

        public TodoItem(int Id, string Name, bool IsComplete)
        {
            this.Id = Id;
            this.Name = Name;
            this.IsComplete = IsComplete;
        }
    }


}
