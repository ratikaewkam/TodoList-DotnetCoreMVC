using System.ComponentModel.DataAnnotations;

namespace TodoList_DotnetCoreMVC.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Task Name")]
        public string TaskName { get; set; }

        [Display(Name = "Task Data")]
        public string TaskData { get; set; }

        [Display(Name = "Task Status")]
        public string TaskStatus { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
