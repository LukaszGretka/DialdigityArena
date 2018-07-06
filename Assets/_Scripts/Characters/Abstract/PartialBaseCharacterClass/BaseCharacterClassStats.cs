
using Assets._Scripts.OutputMessages;
using UnityEngine;

namespace Assets._Scripts.Characters.Abstract.PartialBaseCharacterClass
{
    /// <summary>+
    /// Inspector values and Get/Set statistic methods
    /// </summary>
    abstract partial class BaseCharacterClass
    {
        //Those variable was made to allow a user set basic statistics from the level of Unity inspector
        [SerializeField] protected int inspectorHealth; // TODO change it float type
        [SerializeField] protected int inspectorMana; // TODO change it float type
        [SerializeField] protected int inspectorStamina;  // TODO change it float type
        [SerializeField] protected int inspectorAttackRange;
        [SerializeField] protected int inspectorMovementSpeed;
        [SerializeField] protected float inspectorHealthRegeneration;
        [SerializeField] protected float inspectorManaRegeneration;

        protected void SetBasicStatistics()
        {
            SetStartingHealth();
            SetStartingMana();
            SetStartingStamina();
        }

        protected void SetCurrentHealth(float changedHealth)
        {
            CurrentHealth = changedHealth;
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

        protected void SetHealthRegeneration(float healthRegeneration)
        {
            if (healthRegeneration >= default(float))
            {
                HealthRegeneration = healthRegeneration;
            }
            else
            {
                Debug.LogError(ErrorMessages.CannotSetHealthRegenerationValue);
            }
        }

        protected void SetManaRegeneration(float manaRegeneration)
        {
            if (manaRegeneration >= default(float))
            {
                ManaRegeneration = manaRegeneration;
            }
            else
            {
                Debug.LogError(ErrorMessages.CannotSetManaRegenerationValue);
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

        protected void SetBaseMovementSpeed(float baseSpeed)
        {
            if (baseSpeed >= default(float))
            {
                BasicMovementSpeed = baseSpeed;
                CurrentMovementSpeed = BasicMovementSpeed;
            }
            else
            {
                Debug.LogError(ErrorMessages.InvalidSpeedValue);
            }
        }

        protected void SetCurrentMovementSpeed(float currentSpeed)
        {
            if (currentSpeed >= default(float))
            {
                CurrentMovementSpeed = currentSpeed;
            }
            else
            {
                Debug.LogError(ErrorMessages.InvalidSpeedValue);
            }
        }
        internal void SetStartingHealth()
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
            if (MaximumMana != default(int))
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
            if (MaximumStamina != default(int))
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
