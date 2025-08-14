using System;

namespace TaskManagementApp.Backend.Models
{
    public class TaskItem
    {
        public int Id { get; set; } // Auto-increment primary key
        public string Title { get; set; } = string.Empty; // Task title
        public string Description { get; set; } = string.Empty; // Task details
        public bool IsCompleted { get; set; } // Completion status
        public DateTime CreatedAt { get; set; } = DateTime.Now; // Auto set on create
    }
}
