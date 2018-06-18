
namespace Assets._Scripts.Abilities
{
    /// <summary>
    /// This class has been made to represent default ability (for example to allow return some object in IAbility methods returns)
    /// </summary>
    internal class DefaultAbility : IAbility
    {
        public string Name { get; private set; } = "Default";

        public float BaseDamage { get; private set; } = 0f;

        public int ManaCost { get; private set; } = 0;

        public int StaminaCost { get; private set; } = 0;

        public float Cooldown { get; private set; } = 0f;

        public float Range { get; private set; } = 0f;

        public bool IsRanged { get; private set; } = false;

        public float CastingTime { get; private set; } = 0f;
    }
}
