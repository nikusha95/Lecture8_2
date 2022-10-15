using System.Globalization;

namespace Properties;

public class Subject
{
    private string _name;
    private int _credit;
    public int Level { get; set; }
    public string Name { get; set; } = null!;
    public int Credit
    {
        get { return _credit; }
        set
        {
            if (value <= 10)
            {
                _credit = value;
            }
        }
    }

    public Subject()
    {
        
    }
    public Subject(string name, int credit)
    {
        _name = name;
        _credit = credit;
    }

    public string GetName()
    {
        return _name;
    }

    public string SetName(string newName)
    {
        _name = newName;

        return _name;
    }
}