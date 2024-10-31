using Microsoft.EntityFrameworkCore.Migrations;

namespace todolist.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}

//Run if model is changed
//Add-Migration {Comment}
//Update-Database


