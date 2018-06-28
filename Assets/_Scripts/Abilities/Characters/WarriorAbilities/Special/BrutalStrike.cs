
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Characters.Conditions;
using System.Collections.Generic;

namespace Assets._Scripts.Abilities.Characters.WarriorAbilities.Special
{
    internal class BrutalStrike : IAbility
    {
        public string Name { get; private set; } = "Brutal Strike";

        public float BaseDamage { get; private set; } = 20f;

        public int ManaCost { get; private set; } = 0;

        public int StaminaCost { get; private set; } = 1;

        public float CooldownTime { get; private set; } = 5f;

        public float Range { get; private set; } = 2f;

        public bool IsRanged { get; private set; } = false;

        public float CastingTime { get; private set; } = 0f;

        public float HitAngle { get; } = 90f;

        public bool OnCooldown { get; } = default(bool);

        public List<KeyValuePair<IConditions, float>> Conditions { get; } = new List<KeyValuePair<IConditions,float>>()
                                                        {
                                                            new KeyValuePair<IConditions, float>(new Bleeding(), 5f)
                                                        };
    }
}
