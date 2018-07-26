using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Characters.Conditions;
using Assets._Scripts.Conditions;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Scripts.Abilities.Characters.WarriorAbilities.Special
{
    internal class BrutalStrike : IAbility
    {
        public string Name { get; private set; } = "Brutal Strike";

        public float BaseDamage { get; private set; } = 20f;

        public int ManaCost { get; private set; } = 0;

        public int StaminaCost { get; private set; } = 1;

        public int OrderInSpellbar { get; private set; } = 3;

        public float CooldownTime { get; private set; } = 5f;

        public float Range { get; private set; } = 2f;

        public bool IsRanged { get; private set; } = false;

        public float CastingTime { get; private set; } = 0f;

        public float HitAngle { get; private set; } = 90f;

        public bool OnCooldown { get; set; } = default(bool);

        public List<ICondition> Conditions { get; } = new List<ICondition>()
        {
            new Slow(durationTime: 5, slowStrength: 15f),
            new Bleeding(damagePerTick: 10f, conditionIterations: 3, conditionIntervalTime: 1f),
        };
    }
}
