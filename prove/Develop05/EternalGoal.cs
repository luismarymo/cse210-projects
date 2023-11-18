public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int value) : base(name, description, value)
    {
        //no attributes to be set
    }

    public override int RecordEvent()
    {
        return _value;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string SaveGoal()
    {
        return $"EternalGoal|{_name}|{_description}|{_value}";
    }
}