namespace Properties;

public class User
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? IdNumber { get; set; }

    public override string ToString()
    {
        return $"id {Id}\nFirstName {FirstName}\nLastName {LastName}";
    }
}