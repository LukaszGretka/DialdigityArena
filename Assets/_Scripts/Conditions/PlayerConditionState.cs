using Assets._Scripts.Characters.Abstract.Interfaces;

namespace Assets._Scripts.Conditions
{
    internal class PlayerConditionState
    {
        public ICondition ActiveCondition { get; set; }

        public float ConditionTimeLeft { get; set; }
    }
}
