using Assets._Scripts.Characters.Abstract.Interfaces;
using UnityEngine;
using Assets._Scripts.OutputMessages;
using System.Collections;
using Assets._Scripts.Abilities;
using Assets._Scripts.Conditions;

namespace Assets._Scripts.Player
{
    public static class PlayerHealthManager
    {

        public static void TakeDamage(this ICharacterClass characterClass, float damage)
        {
            characterClass.SetCurrentHealth(characterClass.GetCurrentHealth() - damage);
            //TODO death system - trigger on player dead
        }

        public static void TakeDamageWithCondition(this ICharacterClass characterClass, IAbility ability)
        {
            TakeDamage(characterClass, ability.BaseDamage);
            characterClass.ApplyCondition(ability.Conditions);
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
                    return characterClass.GetMaximumHealth();
                }
                else
                {
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

        public static IEnumerator HealthRegeneration(this ICharacterClass characterClass)
        {
            TakeHealing(characterClass, characterClass.GetHealthRegeneration());
            yield return new  WaitForSeconds(1f);
        }
    }
}