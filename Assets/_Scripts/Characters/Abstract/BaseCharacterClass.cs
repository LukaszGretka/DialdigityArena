using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

namespace Assets._Scripts.Characters.Abstract
{
    abstract class BaseCharacterClass : MonoBehaviour
    {
        protected int MaximumHealth { get; set; }
        protected int CurrentHealth { get; set; }

        protected int MaximumMana { get; set; }
        protected int CurrentMana { get; set; }

        protected int MaximumStamina { get; set; }
        protected int CurrentStamina { get; set; }

        protected float DefaultAttackRange { get; set; }

        protected void SetBasicStatistics()
        {
            SetStartingHealth();
            SetStartingMana();
            SetStartingStamina();
        }


        protected void SetMaximumHealth(int health)
        {
            if (health != default(int))
            {
                MaximumHealth = health;
            }
            else
            {
                //TODO : remove magic strings in this method and others
                Debug.LogError("Please fill Health value");
            }
        }

        protected void SetMaximumMana(int mana)
        {
            if (mana != default(int))
            {
                MaximumMana = mana;
            }
            else
            {
                Debug.LogError("Please fill Mana value");
            }
        }

        protected void SetMaximumStamina(int stamina)
        {
            if (stamina != default(int))
            {
                MaximumStamina = stamina;
            }
            else
            {
                Debug.LogError("Please fill Stamina value");
            }
        }

        protected void SetAttackRange(int range)
        {
            if (range != default(float))
            {
                DefaultAttackRange = range;
            }
            else
            {
                Debug.LogError("Please fill Range value");
            }
        }

        #region Starting statistics setters

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

        #endregion
    }
}
