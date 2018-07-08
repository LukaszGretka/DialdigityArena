
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Characters.Conditions;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Scripts.Abilities.Characters.RangerAbilities.Special
{
    internal class PenetratingShot : IAbility
    {
        public string Name { get; private set; } = "Penetrating Shot";

        public float BaseDamage { get; private set; } = 6f;

        public int ManaCost { get; private set; } = 2;

        public int StaminaCost { get; private set; } = 0;

        public float CooldownTime { get; private set; } = 1f;

        public float Range { get; private set; } = 10f;

        public bool IsRanged { get; private set; } = true;

        public float CastingTime { get; private set; } = 2.5f;

        public float HitAngle { get; private set; } = default(float);

        public bool OnCooldown { get; set; } = default(bool);

        public List<ICondition> Conditions { get; private set; } = new List<ICondition>()
        {
            new Bleeding(damagePerTick: 3f, conditionIterations: 5, conditionIntervalTime: 1f)
        };

        public GameObject AbilityGameModel { get; private set; } = null;

        public ParticleSystem AttachedParticle { get; private set; } = null;
    }
}
