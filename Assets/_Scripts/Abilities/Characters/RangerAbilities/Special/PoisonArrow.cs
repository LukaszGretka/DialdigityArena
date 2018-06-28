
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions.Harmful;
using System.Collections.Generic;

namespace Assets._Scripts.Abilities.Characters.RangerAbilities.Special
{
    internal class PoisonArrow : IAbility
    {
        public string Name { get; private set; } = "Poison Arrow";

        public float BaseDamage { get; private set; } = 4f;

        public int ManaCost { get; private set; } = 2;

        public int StaminaCost { get; private set; } = 0;

        public float CooldownTime { get; private set; } = 10f;

        public float Range { get; private set; } = 6f;

        public bool IsRanged { get; private set; } = true;

        public float CastingTime { get; private set; } = 0f;

        public float HitAngle { get; } = 120f;

        public bool OnCooldown { get; } = default(bool);

        public List<KeyValuePair<IConditions, float>> Conditions { get; } = new List<KeyValuePair<IConditions, float>>()
                                                        {
                                                            new KeyValuePair<IConditions, float>(new Poison(), 10f)
                                                        };

        //TODO If enemy is shooted by poision arrow he gets poison condition. Make Enum to storage conditions
    }
}
