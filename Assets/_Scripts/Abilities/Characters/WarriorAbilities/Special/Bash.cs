
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions;
using System.Collections.Generic;

namespace Assets._Scripts.Abilities.Characters.WarriorAbilities.Special
{
    internal class Bash : IAbility
    {
        public string Name { get; private set; } = "Bash";

        public float BaseDamage { get; private set; } = 10f;

        public int ManaCost { get; private set; } = 0;

        public int StaminaCost { get; private set; } = 1;

        public float CooldownTime { get; private set; } = 15f;

        public float Range { get; private set; } = 1f;

        public bool IsRanged { get; private set; } = false;

        public float CastingTime { get; private set; } = 0f;

        public float HitAngle { get; private set; } = 120f;

        public bool OnCooldown { get; } = default(bool);

        public List<ICondition> Conditions { get; } = new List<ICondition>() { new Stun() { DurationTime = 1f } };
    }
}
