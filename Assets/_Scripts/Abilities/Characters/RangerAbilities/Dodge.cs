
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions.Harmful;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Scripts.Abilities.Characters.RangerAbilities
{
    class Dodge : IAbility
    {
        public string Name { get; private set; } = "Dodge";

        public float BaseDamage { get; private set; } = 0f;

        public int ManaCost { get; private set; } = 0;

        public int StaminaCost { get; private set; } = 1;

        public float CooldownTime { get; private set; } = 0f;

        public float Range { get; private set; } = 0f;

        public bool IsRanged { get; private set; } = false;

        public float CastingTime { get; private set; } = 0f;

        public float HitAngle { get; private set; } = default(float);

        public bool OnCooldown { get; private set; } = default(bool);

        public List<ICondition> Conditions { get; private set; } = new List<ICondition>
        {
            new Evasion(durationTime: 10f, evasionValue: 70f)
        };

        public GameObject AbilityGameModel { get; private set; } = null;

        public ParticleSystem AttachedParticle { get; private set; } = null;
    }
}
