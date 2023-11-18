public class ChecklistGoal : Goal
{
    private int _checks; //how many times it has to be completed
    private int _checked; //how many times it has been completed
    private int _totalValue; //extra bonus for full completion

    public ChecklistGoal(string name, string description, int value, int checks, int checkedd, int totalValue) : base(name, description, value)
    {
        //for when its loaded from file
        _checks = checks;
        _checked = checkedd; //use of checkedd (with double d) because 'checked' is a keyword
        _totalValue = totalValue;
    }

    public ChecklistGoal(string name, string description, int value, int checks, int totalValue) : base(name, description, value)
    {
        //for when its created by user. by default, it has been completed 0 times
        _checks = checks;
        _checked = 0;
        _totalValue = totalValue;
    }

    public override int RecordEvent()
    {
        //add 1 to the amount of times completed
        _checked++;

        //if complete, return the value and bonus. otherwise just the value
        if (IsComplete())
        {
            return _value + _totalValue;
        }
        else
        {   
            return _value;
        }
    }

    public override bool IsComplete()
    {
        //check if its been fully completed by verifying that its been checked as many times as its required
        if (_checked == _checks)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetGoal()
    {
        //only type of goal that overrides GetGoal because it is the only one that requires showing the amount of times checked
        if (IsComplete())
        {
            return $"[X] {_name} ({_description}) -- Currently completed {_checked}/{_checks}";
        }
        else
        {
            return $"[ ] {_name} ({_description}) -- Currently completed {_checked}/{_checks}";
        }
    }

    public override string SaveGoal()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_value}|{_checks}|{_checked}|{_totalValue}";
    }
}