using Assets._Scripts.Abilities;
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions;
using UnityEngine;

namespace Assets._Scripts.Player
{
    internal static class PlayerStatisticManager
    {
        public delegate void PlayerStatisticChange();

        public static event PlayerStatisticChange OnHealthValueChange;
        public static event PlayerStatisticChange OnManaValueChange;
        public static event PlayerStatisticChange OnStaminaValueChange;

        public static event PlayerStatisticChange OnPlayerDeath;

        #region Health methods

        public static void TakeDamage(this ICharacterClass characterClass, float damage)
        {
            if (characterClass.CheckIfDead() == false)
            {
                if (characterClass.CheckIfContainsCondition<DamageReduction>())
                {
                    Debug.Log("Hitting player on Damage reduction");
                }

                characterClass.SetCurrentHealth(characterClass.GetCurrentHealth() - damage);
                OnHealthValueChange.Invoke();

                if (characterClass.CheckIfDead())
                {
                    OnPlayerDeath.Invoke();
                }
            }
        }

        public static bool CheckIfDead(this ICharacterClass characterClass)
        {
            return characterClass.GetCurrentHealth() <= default(float);
        }

        public static void TakeHealing(this ICharacterClass characterClass, float healingTaken)
        {
            if (characterClass.CheckIfDead() == false)
            {
                float maximumHealth = characterClass.GetMaximumHealth();
                float currentHealth = characterClass.GetCurrentHealth();

                bool healingOverflow = currentHealth + healingTaken > maximumHealth;

                float validatedHealthValue = healingOverflow ? maximumHealth
                                                             : currentHealth + healingTaken;

                characterClass.SetCurrentHealth(validatedHealthValue);
                OnHealthValueChange.Invoke();
            }

        }

        public static void HealthRegeneration(this ICharacterClass characterClass)
        {
            TakeHealing(characterClass, characterClass.GetHealthRegeneration());
        }

        #endregion

        #region Mana methods

        public static void AddMana(this ICharacterClass characterClass, float manaPointsToAdd)
        {
            float currentMana = characterClass.GetCurrentMana();
            float maximumMana = characterClass.GetMaximumMana();

            bool manaOverflow = currentMana + manaPointsToAdd > maximumMana;

            float validatedMana = manaOverflow ? maximumMana
                                               : currentMana + manaPointsToAdd;

            characterClass.SetCurrentMana(validatedMana);
            OnManaValueChange.Invoke();
        }

        public static bool CheckIfEnoughMana(this ICharacterClass characterClass, IAbility ability)
        {
            return characterClass.GetCurrentMana() < ability.ManaCost;
        }

        public static void SubstractMana(this ICharacterClass characterClass, float manaPointsToSubstract)
        {
            float currentMana = characterClass.GetCurrentMana();
            bool manaLimitReached = currentMana < currentMana - manaPointsToSubstract;

            float validatedMana = manaLimitReached ? default(float)
                                                   : currentMana - manaPointsToSubstract;

            characterClass.SetCurrentMana(validatedMana);
            OnManaValueChange.Invoke();
        }

        public static void ManaRegeneration(this ICharacterClass characterClass)
        {
            AddMana(characterClass, characterClass.GetManaRegeneration());
        }

        #endregion

        #region Stamina methods

        public static void AddStamina(this ICharacterClass characterClass, float staminaPointsToAdd)
        {
            float currentStamina = characterClass.GetCurrentStamina();
            float maximumStamina = characterClass.GetMaximumStamina();

            bool staminaOverflow = currentStamina + staminaPointsToAdd > maximumStamina;

            float validatedStamina = staminaOverflow ? maximumStamina
                                                     : currentStamina + staminaPointsToAdd;

            characterClass.SetCurrentStamina(validatedStamina);
            OnStaminaValueChange.Invoke();
        }

        public static bool CheckIfEnoughStamina(this ICharacterClass characterClass, IAbility ability)
        {
            return characterClass.GetCurrentStamina() < ability.StaminaCost;
        }

        public static void SubstractStamina(this ICharacterClass characterClass, float staminaPointsToSubstract)
        {
            float currentStamina = characterClass.GetCurrentStamina();

            bool staminaLimitReached = currentStamina < currentStamina - staminaPointsToSubstract;

            float validatedStamina = staminaLimitReached ? default(float)
                                                         : currentStamina - staminaPointsToSubstract;

            characterClass.SetCurrentStamina(validatedStamina);
            OnStaminaValueChange.Invoke();
        }

        public static void StaminaRegeneration(this ICharacterClass characterClass)
        {
            AddStamina(characterClass, characterClass.GetStaminaRegeneration());
        }

        #endregion
    }
}