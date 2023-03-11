
using System;
using System.Collections.Generic;
using System.IO;


// Checklist goal that must be accomplished a certain number of times to be complete
    class ChecklistGoal : Goal
    {
        private int targetCount;
        private int count;

        public ChecklistGoal(string name, int points, int targetCount) : base(name, points)
        {
            this.targetCount = targetCount;
            this.count = 0;
        }

        public override string GetGoalType()
        {
            return "Checklist";
        }

        public override string GetProgress()
        {
            return $"Completed {count}/{targetCount} times";
        }

        public override void RecordEvent()
        {
            if (count < targetCount)
            {
                Console.WriteLine($"You have recorded progress on the goal: {GetName()} (+{GetPoints()} points)");
                count++;

                if (count == targetCount)
                {
                    Console.WriteLine($"Congratulations! You have completed the goal: {GetName()} (+{GetPoints()} bonus points)");
                    MarkAsCompleted();
                }
            }
            else
            {
                Console.WriteLine($"You have already completed the goal: {GetName()}");
            }
        }
    }

    