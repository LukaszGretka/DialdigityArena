
using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Scripts.Abilities.Characters.RangerAbilities
{
    internal class Shoot : IAbilityWithGameEffect
    {
        public string Name { get; private set; } = "Shoot";

        public float BaseDamage { get; private set; } = 6f;

        public int ManaCost { get; private set; } = 2;

        public int StaminaCost { get; private set; } = 0;

        public float CooldownTime { get; private set; } = 1f;

        public float Range { get; private set; } = 10f;

        public bool IsRanged { get; private set; } = true;

        public float CastingTime { get; private set; } = 0f;

        public float HitAngle { get; } = default(float);

        public bool OnCooldown { get; } = default(bool);

        public List<ICondition> Conditions { get; } = new List<ICondition>();

        public GameObject AbilityGameModel { get; private set; } = Resources.Load("Abilities/Ranger/Arrow", typeof(GameObject)) as GameObject;

        public ParticleSystem AttachedParticle { get; private set; } = null;
    }
}
