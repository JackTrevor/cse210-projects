using System;
using System.Collections.Generic;
using System.IO;
// Simple goal that can be marked complete
class SimpleGoal : Goal
    {
        public SimpleGoal(string name, int points) : base(name, points)
        {
        }

        public override string GetGoalType()
        {
            return "Simple";
        }
    }

