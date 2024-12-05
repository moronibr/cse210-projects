using System;

namespace prove
{


    public class SimpleGoal : Goal
    {
 
        public bool _isComplete { get; private set; }

        public SimpleGoal(string name, string description, string points, bool isComplete)
            : base(name, description, points)
        {
           
            _isComplete = isComplete;

        }

        public override int RecordEvent()
        {
            if (!_isComplete)
            {
                _isComplete = true;
                return int.Parse(_points);
            }
            return 0;
        }

        public override string Serialize()
        {
            return $"{base.Serialize()},{_points},{_isComplete}";
        }
    }

}
