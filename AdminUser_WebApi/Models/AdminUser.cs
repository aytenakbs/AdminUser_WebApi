namespace AdminUser_WebApi.Models;

public class AdminUser
{
    public int Id { get; set; }
    public DateTime AddDate { get; set; } = DateTime.Now;
    public bool IsDeleted { get; set; } = false;
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}
