namespace LinqExercises.Core;

public class User
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string FullName => $"{FirstName} {LastName}";
    public DateTime DateOfBirth { get; set; }
    public DateTime LastLogin { get; set; }
    public string Country { get; set; } = "";
    public int DataStored { get; set; }
    public string Email { get; set; } = "";
}