
using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Characters.Abstract.Interfaces;
using System.Collections.Generic;

namespace Assets._Scripts.Abilities
{
    public interface IAbility : IAbilityGameEffect
    {
        string Name { get; }

        float BaseDamage { get; }

        int ManaCost { get; }

        int StaminaCost { get; }

        float CooldownTime { get; }

        bool OnCooldown { get; }

        float Range { get; }

        bool IsRanged { get; }

        float CastingTime { get; }

        float HitAngle { get; }

        List<ICondition> Conditions {get;}
    }
}