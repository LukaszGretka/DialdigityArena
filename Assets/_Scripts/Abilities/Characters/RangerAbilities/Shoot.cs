﻿
namespace Assets._Scripts.Abilities.Characters.RangerAbilities
{
    internal class Shoot : IAbility
    {
        public string Name { get; private set; } = "Shoot";

        public float BaseDamage { get; private set; } = 6f;

        public int ManaCost { get; private set; } = 2;

        public int StaminaCost { get; private set; } = 0;

        public float Cooldown { get; private set; } = 1f;

        public float Range { get; private set; } = 10f;

        public bool IsRanged { get; private set; } = true;

        public float CastingTime { get; private set; } = 0f;


    }
}
