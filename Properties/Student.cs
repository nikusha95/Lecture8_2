namespace Properties;

public class Student
{
    private string _name;
    private string _lastName;
    private const int MaxSubject = 10;
    private int _current = 0;
    private Subject[] _subjects = new Subject[10];
    private DateTime? _birthDate;

    public Student(string name, string lastName, DateTime? birthDate)
    {
        _name = name;
        _lastName = lastName;
        _birthDate = birthDate;
    }

    public void AddSubject(Subject subject)
    {
        if (!_subjects.Contains(subject) && _current + 1 != _subjects.Length - 1)
        {
            _subjects[_current++] = subject;
        }
    }

    public string? GetSubject(string subject)
    {
        foreach (var s in _subjects)
        {
            //TODO: should add logic
        }

        return null;
    }
}