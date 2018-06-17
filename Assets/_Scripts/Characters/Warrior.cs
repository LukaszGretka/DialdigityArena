using Assets._Scripts.Abilities;
using Assets._Scripts.Abilities.Characters.WarriorAbilities;
using Assets._Scripts.Abilities.Characters.WarriorAbilities.Special;
using Assets._Scripts.Characters.Abstract;
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Player;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Scripts.Characters
{
    [RequireComponent(typeof(PlayerAbilitiesController))]
    internal class Warrior : MeleeCharacterClass, ICharacterClass
    {
        private void Awake()
        {
            base.SetMaximumHealth(inspectorHealth);
            base.SetMaximumMana(inspectorMana);
            base.SetMaximumStamina(inspectorStamina);
            base.SetAttackRange(inspectorAttackRange);

            base.SetBasicStatistics();

            base.SetFirstDefaultAbility(new Swipe());
            base.SetSecondDefaultAbility(new Block());
            base.SetFirstSpecialAbility(new BrutalStrike());
            base.SetSecondSpecialAbility(new Leap());
            base.SetThirdSpecialAbility(new Bash());
        }

        public new List<IAbility> GetCharacterAbilitiesList()
        {
            return base.GetCharacterAbilitiesList();
        }

        public new IAbility GetFirstDefaultAbility()
        {
            return base.GetFirstDefaultAbility();
        }

        public new IAbility GetSecondDefaultAbility()
        {
            return base.GetSecondDefaultAbility();
        }

        public new IAbility GetFirstSpecialAbility()
        {
            return base.GetFirstSpecialAbility();
        }

        public new IAbility GetSecondSpecialAbility()
        {
            return base.GetSecondSpecialAbility();
        }

        public new IAbility GetThirdSpecialAbility()
        {
            return base.GetThirdSpecialAbility();
        }

        int ICharacterClass.GetCurrentHealth()
        {
            return CurrentHealth;
        }

        int ICharacterClass.GetCurrentMana()
        {
            return CurrentMana;
        }

        int ICharacterClass.GetCurrentStamina()
        {
            return CurrentStamina;
        }

        public float GetAttackRange()
        {
            return DefaultAttackRange;
        }

        public int GetMaximumHealth()
        {
            return MaximumHealth;
        }

        public int GetMaximumMana()
        {
            return MaximumMana;
        }

        public int GetMaximumStamina()
        {
            return MaximumStamina;
        }
    }
}