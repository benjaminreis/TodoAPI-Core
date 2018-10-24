using System.Data;


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

        public TodoItem(DataRow dr)
        {
            this.Id = int.Parse((dr["id"] != null ? dr["id"].ToString() : ""));
            this.Name = dr["Name"] != null ? dr["Name"].ToString() : "";
            this.IsComplete = bool.Parse((dr["IsComplete"] != null ? dr["IsComplete"].ToString() : "1"));


        }
    }


}
