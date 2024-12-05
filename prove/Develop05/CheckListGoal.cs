using System;

namespace prove
{
    public class CheckListGoal : Goal
    {

        public int _target { get; private set; }
        public int _bonus { get; private set; }
        public int _amountCompleted { get; private set; }

        public CheckListGoal(string name, string description, string points, int target, int bonus, int amountCompleted)
            : base(name, description, points)
        {
    
            _target = target;
            _bonus = bonus;
            _amountCompleted = amountCompleted;
        }

        public override int RecordEvent()
        {
            _amountCompleted++;
            if (_amountCompleted >= _target)
            {
                return int.Parse(_points) + _bonus;
            }

            return int.Parse(_points);
        }

        public override string Serialize()
        {
            return $"{base.Serialize()},{_points},{_target},{_bonus},{_amountCompleted}";
        }
    }
}
