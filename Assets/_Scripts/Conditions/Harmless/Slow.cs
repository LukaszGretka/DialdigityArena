using Assets._Scripts.Characters.Abstract.Interfaces;

namespace Assets._Scripts.Conditions
{
    internal class Slow : IConditions
    {
        public string Name { get; private set; } = "Slow";

        public float DamagePerTick { get; private set; } = 0f;

        public float DurationTime { get; set; }

        public float SlowStrength { get; set; }

        public float DamageReductionValue { get; private set; }

        public float AttackEvasionValue { get; private set; }
    }
}
