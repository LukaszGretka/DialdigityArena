﻿
namespace Assets._Scripts.Abilities.Characters.MageAbilities
{
    internal class MagicMissile : IAbility
    {
        public string Name { get; private set; } = "Magic Missile";

        public float BaseDamage { get; private set; } = 5f;

        public int ManaCost { get; private set; } = 2;

        public int StaminaCost { get; private set; } = 0;

        public float Cooldown { get; private set; } = 1f;

        public float Range { get; private set; } = 6f;

        public bool IsRanged { get; private set; } = true;

        public float CastingTime { get; private set; } = 0f;
    }
}
