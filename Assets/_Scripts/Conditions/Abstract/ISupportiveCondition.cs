using Assets._Scripts.Characters.Abstract.Interfaces;

namespace Assets._Scripts.Conditions.Abstract
{
    interface ISupportiveCondition : ICondition
    {
        float HealingPerTick { get; }           // const value

        float DamageReductionValue { get; }     // in percents

        float AttackEvasionValue { get; }       // in percents
    }
}
