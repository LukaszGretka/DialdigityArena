
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Characters.Conditions;
using System.Collections.Generic;

namespace Assets._Scripts.Abilities.Characters.MageAbilities.Special
{
    internal class LightingLeap : IAbility
    {
        public string Name { get; private set; } = "Lighting Leap";

        public float BaseDamage { get; private set; } = 3f;

        public int ManaCost { get; private set; } = 10;

        public int StaminaCost { get; private set; } = 0;

        public float CooldownTime { get; private set; } = 12f;

        public float Range { get; private set; } = 0f;

        public bool IsRanged { get; private set; } = false;

        public float CastingTime { get; private set; } = 0f;

        public float HitAngle { get; private set; } = default(float);

        public bool OnCooldown { get;  set; } = default(bool);

        public List<IConditions> Conditions { get; } = new List<IConditions>(){};
    }
}
