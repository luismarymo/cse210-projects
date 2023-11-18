using System.Diagnostics.Contracts;

public class SimpleGoal : Goal
{
    private bool _isComplete; //wether its been completed or not

    public SimpleGoal(string name, string description, int value, bool isComplete) : base(name, description, value)
    {
        //for when its is loaded from file
        _isComplete = isComplete;
    }
    
    public SimpleGoal(string name, string description, int value) : base(name, description, value)
    {
        //for when it is created by user. by default, it would not be complete
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        //change _isComplete to true and return the amount of points associated with goal
        _isComplete = true;
        return _value;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string SaveGoal()
    {
        return $"SimpleGoal|{_name}|{_description}|{_value}|{_isComplete}|";
    }
}