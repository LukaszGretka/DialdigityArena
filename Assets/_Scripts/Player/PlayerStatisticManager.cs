using Assets._Scripts.Abilities;
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions;
using UnityEngine;

namespace Assets._Scripts.Player
{
    internal static class PlayerStatisticManager
    {
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

                if (characterClass.CheckIfDead())
                {
                    //TODO implementation!
                }

                characterClass.GetStatusBarManager().PerformValueChangeTextEffectWithColor(damage, StateValueChangeAction.TakingDamage);
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
                characterClass.GetStatusBarManager().PerformValueChangeTextEffectWithColor(healingTaken, StateValueChangeAction.TakingHealing);
            }

        }

        public static void HealthRegeneration(this ICharacterClass characterClass)
        {
            TakeHealing(characterClass, characterClass.GetHealthRegeneration());
            characterClass.GetStatusBarManager().PerformValueChangeTextEffectWithColor(characterClass.GetHealthRegeneration(), StateValueChangeAction.TakingHealing);
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
            characterClass.GetStatusBarManager().PerformValueChangeTextEffectWithColor(manaPointsToAdd, StateValueChangeAction.ChangeMana);
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
            characterClass.GetStatusBarManager().PerformValueChangeTextEffectWithColor(manaPointsToSubstract, StateValueChangeAction.ChangeMana);
        }

        public static void ManaRegeneration(this ICharacterClass characterClass)
        {
            AddMana(characterClass, characterClass.GetManaRegeneration());
            characterClass.GetStatusBarManager().PerformValueChangeTextEffectWithColor(characterClass.GetManaRegeneration(), StateValueChangeAction.ChangeMana);
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
            characterClass.GetStatusBarManager().PerformValueChangeTextEffectWithColor(staminaPointsToAdd, StateValueChangeAction.ChangeStamina);
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
            characterClass.GetStatusBarManager().PerformValueChangeTextEffectWithColor(staminaPointsToSubstract, StateValueChangeAction.ChangeStamina);
        }

        public static void StaminaRegeneration(this ICharacterClass characterClass)
        {
            AddStamina(characterClass, characterClass.GetStaminaRegeneration());
            characterClass.GetStatusBarManager().PerformValueChangeTextEffectWithColor(characterClass.GetStaminaRegeneration(), StateValueChangeAction.ChangeStamina);
        }

        #endregion
    }
}