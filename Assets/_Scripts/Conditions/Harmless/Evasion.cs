using Assets._Scripts.Characters.Abstract.Interfaces;

namespace Assets._Scripts.Conditions.Harmful
{
    internal class Evasion : IConditions
    {
        public string Name { get; private set; } = "Evasion";

        public float DamagePerTick { get; private set; } = 0f;

        public float DurationTime { get; set; }

        public float SlowStrength { get; private set; } = default(float);

        public float DamageReductionValue { get; private set; } = default(float);

        public float AttackEvasionValue { get; set; }
    }
}
