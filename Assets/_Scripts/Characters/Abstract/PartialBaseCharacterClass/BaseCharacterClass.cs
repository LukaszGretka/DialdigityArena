using Assets._Scripts.Abilities;
using UnityEngine;

namespace Assets._Scripts.Characters.Abstract.PartialBaseCharacterClass
{
    abstract partial class BaseCharacterClass : MonoBehaviour
    {
        protected int MaximumHealth { get; set; }
        protected int CurrentHealth { get; set; }

        protected int MaximumMana { get; set; }
        protected int CurrentMana { get; set; }

        protected int MaximumStamina { get; set; }
        protected int CurrentStamina { get; set; }

        protected float HealthRegeneration { get; set; }
        protected float ManaRegeneration { get; set; }
        //protected float StaminaRegeneration { get; set; }

        protected float DefaultAttackRange { get; set; }

        protected IAbility FirstDefaultAbility { get; private set; }
        protected IAbility SecondDefaultAbility { get; private set; }
        protected IAbility FirstSpecialAbility { get; private set; }
        protected IAbility SecondSpecialAbility { get; private set; }
        protected IAbility ThirdSpecialAbility { get; private set; }
    }
}
