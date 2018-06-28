using Assets._Scripts.Abilities;
using UnityEngine;

namespace Assets._Scripts.Characters.Abstract.PartialBaseCharacterClass
{
    abstract partial class BaseCharacterClass : MonoBehaviour
    {
        protected float MaximumHealth { get; private set; }
        protected float CurrentHealth { get; private set; }

        protected float MaximumMana { get; private set; }
        protected float CurrentMana { get; private set; }

        protected float MaximumStamina { get; private set; }
        protected float CurrentStamina { get; private set; }

        protected float HealthRegeneration { get; private set; }
        protected float ManaRegeneration { get; private set; }
        protected float StaminaRegeneration {get; private set; }

        protected float DefaultAttackRange { get; set; }
        protected float DefaultMovementSpeed { get; set; }

        protected IAbility FirstDefaultAbility { get; private set; }
        protected IAbility SecondDefaultAbility { get; private set; }
        protected IAbility FirstSpecialAbility { get; private set; }
        protected IAbility SecondSpecialAbility { get; private set; }
        protected IAbility ThirdSpecialAbility { get; private set; }
    }
}
