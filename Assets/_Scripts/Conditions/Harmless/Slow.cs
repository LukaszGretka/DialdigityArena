using Assets._Scripts.Characters.Abstract.Interfaces;

namespace Assets._Scripts.Conditions
{
    internal class Slow : IConditions
    {
        public string Name { get; private set; } = "Slow";

        public float DamagePerTick { get; private set; } = 0f;

        public float DurationTime { get; set; }

        public float SlowStrength { get; set; }

        public void AddConditionToTarget(ICharacterClass characterClass, float DurationTime)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveConditionFromTarget(ICharacterClass characterClass)
        {
            throw new System.NotImplementedException();
        }
    }
}
