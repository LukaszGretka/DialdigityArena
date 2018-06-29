
namespace Assets._Scripts.Characters.Abstract.Interfaces
{
    public interface IConditions
    {
        string Name { get; }

        float DamagePerTick { get; }

        float DurationTime { get; }

        float SlowStrength { get; }
    }
}
