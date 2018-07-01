using Assets._Scripts.Characters.Abstract.Interfaces;

namespace Assets._Scripts.Conditions.Abstract
{
    interface IHarmfulCondition : ICondition
    {
        float DamagePerTick { get; }

        float SlowStrength { get; }
    }
}
