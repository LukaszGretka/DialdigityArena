
namespace Assets._Scripts.Characters.Abstract.Interfaces
{
    public interface IConditions
    {
        string Name { get; }

        float DamagePerTick { get; }

        float DurationTime { get; }

        float SlowStrength { get; }

        void AddConditionToTarget(ICharacterClass characterClass, float DurationTime);

        void RemoveConditionFromTarget(ICharacterClass characterClass);

    }
}
