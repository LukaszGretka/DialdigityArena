
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions;
using System.Collections.Generic;

namespace Assets._Scripts.Abilities.Characters.MageAbilities
{
    internal class IceArmor : IAbility
    {
        public string Name { get; private set; } = "Ice Armor";

        public float BaseDamage { get; private set; } = 0f;

        public int ManaCost { get; private set; } = 4;

        public int StaminaCost { get; private set; } = 0;

        public float CooldownTime { get; private set; } = 30f;

        public float Range { get; private set; } = 0f;

        public bool IsRanged { get; private set; } = false;

        public float CastingTime { get; private set; } = 0f;

        public float HitAngle { get; private set; } = 0f;

        public bool OnCooldown { get; private set; } = default(bool);

        public List<IConditions> Conditions { get; private set; } = new List<IConditions>();

    }
}
