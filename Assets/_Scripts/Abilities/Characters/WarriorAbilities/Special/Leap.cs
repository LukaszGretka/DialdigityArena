
using Assets._Scripts.Characters.Abstract.Interfaces;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Scripts.Abilities.Characters.WarriorAbilities.Special
{
    internal class Leap : IAbility
    {
        public string Name { get; private set; } = "Leap";

        public float BaseDamage { get; private set; } = 5f;

        public int ManaCost { get; private set; } = 0;

        public int StaminaCost { get; private set; } = 1;

        public int OrderInSpellbar { get; private set; } = 4;

        public float CooldownTime { get; private set; } = 15f;

        public float Range { get; private set; } = 5f;

        public bool IsRanged { get; private set; } = true;

        public float CastingTime { get; private set; } = 0f;

        public float HitAngle { get; private set; } = default(float);

        public bool OnCooldown { get; set; } = default(bool);

        public List<ICondition> Conditions { get; private set; } = new List<ICondition>();
    }
}
