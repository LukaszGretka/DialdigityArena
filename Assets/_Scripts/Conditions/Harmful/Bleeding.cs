using Assets._Scripts.Characters.Abstract.Interfaces;

namespace Assets._Scripts.Characters.Conditions
{
    internal class Bleeding : IConditions
    {
        public string Name { get; private set; } = "Bleeding";

        public float DamagePerTick { get; private set; } = 5f;

        public float DurationTime { get; set; } 
        
        public float SlowStrength {  get; private set; }

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
