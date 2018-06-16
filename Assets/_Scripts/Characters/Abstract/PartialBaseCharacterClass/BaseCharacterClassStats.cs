using Assets._Scripts.Abilities;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets._Scripts.Characters.Abstract.PartialBaseCharacterClass
{
    abstract partial class BaseCharacterClass
    {
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
                //TODO : remove magic strings in this method and others
                Debug.LogError("Invalid Health value");
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
                Debug.LogError("Invalid Mana value");
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
                Debug.LogError("Invalid Stamina value");
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
                Debug.LogError("Invalid Attack Range value");
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
                Debug.LogError("Can't set starting health - maximum health was not set");
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
                Debug.LogError("Can't set starting mana - maximum mana was not set");
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
                Debug.LogError("Can't set starting stamina - maximum stamina was not set");
            }
        }
    }
}
