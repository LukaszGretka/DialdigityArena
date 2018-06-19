
using UnityEngine;

namespace Assets._Scripts.Characters.Abstract.PartialBaseCharacterClass
{
    abstract partial class BaseCharacterClass
    {
        //Those variable was made to allow a user set basic statistics from the level of Unity inspector
        [SerializeField] protected int inspectorHealth;
        [SerializeField] protected int inspectorMana;
        [SerializeField] protected int inspectorStamina;
        [SerializeField] protected int inspectorAttackRange;

        protected void SetBasicStatistics()
        {
            SetStartingHealth();
            SetStartingMana();
            SetStartingStamina();
        }

        protected int GetCurrentHealth()
        {
            return CurrentHealth;
        }

        protected int GetCurrentMana()
        {
            return CurrentMana;
        }

        protected int GetCurrentStamina()
        {
            return CurrentStamina;
        }

        protected void SetMaximumHealth(int health)
        {
            if (health > default(int))
            {
                MaximumHealth = health;
            }
            else
            {
                Debug.LogError(ErrorMessages.InvalidHealthValue);
            }
        }

        protected void SetMaximumMana(int mana)
        {
            if (mana >= default(int))
            {
                MaximumMana = mana;
            }
            else
            {
                Debug.LogError(ErrorMessages.InvalidManaValue);
            }
        }

        protected void SetMaximumStamina(int stamina)
        {
            if (stamina >= default(int))
            {
                MaximumStamina = stamina;
            }
            else
            {
                Debug.LogError(ErrorMessages.InvalidStaminaValue);
            }
        }

        protected void SetAttackRange(int range)
        {
            if (range >= default(float))
            {
                DefaultAttackRange = range;
            }
            else
            {
                Debug.LogError(ErrorMessages.InvalidRangeValue);
            }
        }


        private void SetStartingHealth()
        {
            if (MaximumHealth != default(int))
            {
                CurrentHealth = MaximumHealth;
            }
            else
            {
                Debug.LogError(ErrorMessages.CannotSetMaximumHealthValue);
            }
        }

        private void SetStartingMana()
        {
            if (MaximumHealth != default(int))
            {
                CurrentMana = MaximumMana;
            }
            else
            {
                Debug.LogError(ErrorMessages.CannotSetMaximumManaValue);
            }
        }

        private void SetStartingStamina()
        {
            if (MaximumHealth != default(int))
            {
                CurrentStamina = MaximumStamina;
            }
            else
            {
                Debug.LogError(ErrorMessages.CannotSetMaximumStaminaValue);
            }
        }
    }
}
