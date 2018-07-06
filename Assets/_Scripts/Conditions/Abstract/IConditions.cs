using Assets._Scripts.Conditions.Abstract;
using Assets._Scripts.Conditions.Enum;

namespace Assets._Scripts.Characters.Abstract.Interfaces
{
    public interface ICondition
    {
        string Name { get; }

        ConditionEffectType EffectType { get; }

        IConditionImplementation ConditionImplementation { get;}
    }
}
