
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions.Harmful;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Scripts.Abilities.Characters.RangerAbilities.Special
{
    internal class PoisonArrow : IAbility
    {
        public string Name { get; private set; } = "Poison Arrow";

        public float BaseDamage { get; private set; } = 4f;

        public int ManaCost { get; private set; } = 2;

        public int StaminaCost { get; private set; } = 0;

        public float CooldownTime { get; private set; } = 10f;

        public float Range { get; private set; } = 6f;

        public bool IsRanged { get; private set; } = true;

        public float CastingTime { get; private set; } = 0f;

        public float HitAngle { get; private set; } = 120f;

        public bool OnCooldown { get; } = default(bool);

        public List<ICondition> Conditions { get; } = new List<ICondition>()
        {
            new Poison(damagePerTick: 3f, conditionIterations: 5, conditionIntervalTime: 1f)
        };

        public GameObject AbilityGameModel { get; private set; } = null;

        public ParticleSystem AttachedParticle { get; private set; } = null;
    }
}
