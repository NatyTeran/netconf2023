namespace NetConf2023.Shared.Dtos;
public class AttendeeDto
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public Profile Profile { get; set; }
    public string Institute { get; set; }
    public bool WantsReceiveNotifications { get; set; }
}
