public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _value;

    public Goal(string name, string description, int value)
    {
        _name = name;
        _description = description;
        _value = value;
    }

    public string GetName()
    {
        return _name;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetGoal()
    {
        //if its complete, add a checkmark when displaying
        if (IsComplete())
        {
            return $"[X] {_name} ({_description})";
        }
        else
        {
            return $"[ ] {_name} ({_description})";
        }
    }

    public abstract string SaveGoal();
}