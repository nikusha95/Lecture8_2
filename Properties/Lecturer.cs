namespace Properties;

public class Lecturer
{
    private readonly string _name;
    private Subject[] _subjects;

    public Lecturer(string name, Subject[] subjects)
    {
        _name = name;
        _subjects = subjects;
    }
}