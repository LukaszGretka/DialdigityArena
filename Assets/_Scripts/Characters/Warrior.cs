using Assets._Scripts.Abilities;
using Assets._Scripts.Abilities.WarriorAbilities;
using Assets._Scripts.Abilities.WarriorAbilities.Special;
using Assets._Scripts.Characters.Abstract;
using Assets._Scripts.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets._Scripts.Characters
{
    [RequireComponent(typeof(PlayerAbilitiesController))]
    internal class Warrior : MeleeCharacterClass, ICharacterAbilities, ICharacterClass
    {
        //Those variable was made to allow user set stats from the unity inspector
        [SerializeField] private int Health;
        [SerializeField] private int Mana;
        [SerializeField] private int Stamina;
        [SerializeField] private int AttackRange;

        private void Awake()
        {
            base.SetMaximumHealth(Health);
            base.SetMaximumMana(Mana);
            base.SetMaximumStamina(Stamina);
            base.SetAttackRange(AttackRange);

            base.SetBasicStatistics();

            SetFirstDefaultAbility(new Swipe());
            SetSecondDefaultAbility(new Block());
            SetFirstSpecialAbility(new BrutalStrike());
            SetSecondSpecialAbility(new Leap());
            SetThirdSpecialAbility(new Bash());
        }

        public List<IAbility> GetCharacterAbilitiesList()
        {
            var list = new List<IAbility>()
            {
                FirstDefaultAbility,
                SecondDefaultAbility,
                FirstSpecialAbility,
                SecondSpecialAbility,
                ThirdSpecialAbility
            };

            if (list.Any(x => x.Equals(null)))
            {
                Debug.LogError("Not all abilities has been set");
            }

            return list;

        }

        public void SetFirstDefaultAbility(IAbility ability)
        {
            FirstDefaultAbility = ability;
        }

        public void SetSecondDefaultAbility(IAbility ability)
        {
            SecondDefaultAbility = ability;
        }

        public void SetFirstSpecialAbility(IAbility ability)
        {
            FirstSpecialAbility = ability;
        }

        public void SetSecondSpecialAbility(IAbility ability)
        {
            SecondSpecialAbility = ability;
        }

        public void SetThirdSpecialAbility(IAbility ability)
        {
            ThirdSpecialAbility = ability;
        }
    }
}
