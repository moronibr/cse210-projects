using System;



namespace prove
{
    public abstract class Goal
    {
        public string _name { get; protected set; }
        public string _description { get; protected set; }

        public string _points { get; protected set; }

        public Goal(string name, string description, string points)
        {
            _name = name;
            _description = description;
            _points = points;
        }   

        public abstract int RecordEvent();

        public virtual string Serialize()
        {
            return $"{GetType()}:{_name},{_description}";
        }

        public static Goal Deserialize(string serializedData)
        {
            string[] parts = serializedData.Split(':');
            if (parts.Length >= 2)
            {
                string[] data = parts[1].Split(',');
                if (parts[0] == "SimpleGoal" && data.Length == 2)
                {
                    return new SimpleGoal(data[0], data[1], data[2], false);
                }
                else if (parts[0] == "EternalGoal" && data.Length == 2)
                {
                    return new EternalGoal(data[0], data[1], data[2]);
                }
                else if (parts[0] == "CheckListGoal" && data.Length == 5)
                {
                    return new CheckListGoal(data[0], data[1], data[2], int.Parse(data[3]), int.Parse(data[4]), 0);
                }
            }
            return null;
        }
    }

}    
