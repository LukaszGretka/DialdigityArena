using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets._Scripts.Characters
{
    abstract class BaseClass
    {
        protected int MaximumHealth { get; set; }
        protected int CurrentHealth { get; set; }

        protected int MaximumMana { get; set; }
        protected int CurrentMana { get; set; }

        protected int MaximumStamina { get; set; }
        protected int CurrentStamina { get; set; }

        protected float DefaultAttackRange { get; set; }

        protected int DefaultDamage { get; set; }

        protected virtual void SetStartingHealth()
        {
            CurrentHealth = MaximumHealth;
        }
    }
}
