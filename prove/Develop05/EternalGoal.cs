using System;

namespace prove
{
    public class EternalGoal : Goal
    {

        public EternalGoal(string name, string description, string points)
            : base(name, description, points)
        {
           
        }

        public override int RecordEvent()
        {
            return int.Parse(_points);
        }

        public override string Serialize()
        {
            return $"{base.Serialize()},{_points}";
        }
    }

}    
