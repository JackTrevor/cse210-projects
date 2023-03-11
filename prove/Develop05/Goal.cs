// Base class for all goals
    abstract class Goal
    {
        private string name;
        private int points;
        public bool isCompleted;

        public Goal(string name, int points)
        {
            this.name = name;
            this.points = points;
            this.isCompleted = false;
        }

        public string GetName()
        {
            return name;
        }

        public int GetPoints()
        {
            return points;
        }

        public bool IsCompleted()
        {
            return isCompleted;
        }

        public void MarkAsCompleted()
        {
            isCompleted = true;
        }
         // Abstract method to be implemented by derived classes
        public abstract string GetGoalType();

        // Virtual method that can be overridden by derived classes
        public virtual string GetProgress()
        {
            return isCompleted ? "[X]" : "[ ]";
        }

        // Virtual method that can be overridden by derived classes
        public virtual void RecordEvent()
        {
            if (!isCompleted)
            {
                Console.WriteLine($"You have completed the goal: {name} (+{points} points)");
                isCompleted = true;
            }
            else
            {
                Console.WriteLine($"You have already completed the goal: {name}");
            }
        }

        public override string ToString()
        {
            return $" {GetProgress()} -- {name} -- ({GetGoalType()})";
        }
    }

    
    