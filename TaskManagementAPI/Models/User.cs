namespace TaskManagementAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Uername { get; set; }= string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public DateTime createdAt { get; set; } = DateTime.UtcNow;

        //Navigation Property
        public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();

    }
}
