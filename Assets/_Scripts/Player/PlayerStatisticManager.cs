using Assets._Scripts.Abilities;
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.OutputMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets._Scripts.Player
{
    internal static class PlayerStatisticManager
    {
        #region Health methods

        public static void TakeDamage(this ICharacterClass characterClass, float damage)
        {
            characterClass.SetCurrentHealth(characterClass.GetCurrentHealth() - damage);

            Debug.Log(characterClass.ToString() + "took " + damage + ". Has " + characterClass.GetCurrentHealth() + " hp left.");
            //TODO death system - trigger on player dead
        }

        public static bool CheckIfPlayerIsDead(this ICharacterClass characterClass)
        {
            return characterClass.GetCurrentHealth() <= default(float) ? true : false;
        }

        public static float TakeHealing(this ICharacterClass characterClass, float healingTaken)
        {
            if (CheckIfPlayerIsDead(characterClass) == false)
            {
                if (characterClass.GetCurrentHealth() + healingTaken > characterClass.GetMaximumHealth())
                {
                    Debug.Log(characterClass.ToString() + "healed for " + healingTaken + ". Has " + characterClass.GetCurrentHealth() + " hp left.");
                    return characterClass.GetMaximumHealth();
                }
                else
                {
                    Debug.Log(characterClass.ToString() + "healed for " + healingTaken + ". Has " + characterClass.GetCurrentHealth() + " hp left.");
                    return characterClass.GetCurrentHealth() + healingTaken;
                }
            }
            else
            {
                Debug.LogError(ErrorMessages.TargetIsDead);
                //TODO Remember to change return value
                return 0;
            }
        }

        public static void HealthRegeneration(this ICharacterClass characterClass)
        {
            TakeHealing(characterClass, characterClass.GetHealthRegeneration());
        }

        #endregion

        #region Mana methods

        public static float AddMana(this ICharacterClass characterClass, float manaPointsToAdd)
        {
            return characterClass.GetCurrentMana() + manaPointsToAdd > characterClass.GetMaximumMana() ?
                characterClass.GetMaximumMana() : characterClass.GetCurrentMana() + manaPointsToAdd;
        }

        public static bool CheckIfEnoughMana(this ICharacterClass characterClass)
        {
            return characterClass.GetCurrentMana() <= default(float) ? true : false;
        }

        public static float SubstractMana(this ICharacterClass characterClass, float manaPointsToSubstract)
        {
            return characterClass.GetCurrentMana() - manaPointsToSubstract;
        }

        public static void ManaRegeneration(this ICharacterClass characterClass)
        {
            AddMana(characterClass, characterClass.GetManaRegeneration());
        }

        #endregion

        #region Stamina methods

        public static float AddStamina(this ICharacterClass characterClass, float staminaPointsToAdd)
        {
            return characterClass.GetCurrentStamina() + staminaPointsToAdd > characterClass.GetMaximumStamina() ? 
                characterClass.GetMaximumStamina() : characterClass.GetCurrentStamina() + staminaPointsToAdd;
        }

        public static bool CheckIfEnoughStamina(this ICharacterClass characterClass, IAbility ability)
        {
            return characterClass.GetCurrentStamina() <= ability.StaminaCost ? true : false;
        }

        public static float SubstractStamina(this ICharacterClass characterClass, float staminaPointsToSubstract)
        {
            return characterClass.GetCurrentStamina() - staminaPointsToSubstract;
        }

        public static void StaminaRegeneration(this ICharacterClass characterClass)
        {
            AddStamina(characterClass, characterClass.GetStaminaRegeneration());
        }

        #endregion
    }
}