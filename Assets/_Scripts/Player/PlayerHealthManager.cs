using Assets._Scripts.Characters.Abstract.Interfaces;
using UnityEngine;
using Assets._Scripts.Characters.Abstract.PartialBaseCharacterClass;

namespace Assets._Scripts.Player
{
    public class PlayerHealthManager : MonoBehaviour
    {
        private PlayerClassManager playerClassManager;
        private BaseCharacterClass baseCharacterClass;
        private ICharacterClass characterClass;

        void Awake()
        {
            playerClassManager = GetComponent<PlayerClassManager>();
            baseCharacterClass = GetComponent<BaseCharacterClass>();
            characterClass = playerClassManager.characterClass;
        }

        public float TakeDamage(float damage)
        {
            return characterClass.GetCurrentHealth() - damage;
            //TODO death system - trigger on player dead
        }

        public bool CheckIfPlayerIsDead()
        {
            return characterClass.GetCurrentHealth() <= 0f ? true : false;
        }

        public float TakeHealing(float healingTaken)
        {
            if (CheckIfPlayerIsDead() == false)
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
    }
}