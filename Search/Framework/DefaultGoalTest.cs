namespace AIMA.Core.Search.Framework
{
    using System;
    using System.Collections.Generic;
    /**
     * Checks whether a given state equals an explicitly specified goal state.
     * 
     * @author Ruediger Lunde
     */
    public class DefaultGoalTest : GoalTest
    {
        private Object goalState;

        public DefaultGoalTest(Object goalState)
        {
            this.goalState = goalState;
        }

        public bool isGoalState(Object state)
        {
            return goalState.Equals(state);
        }
    }
}