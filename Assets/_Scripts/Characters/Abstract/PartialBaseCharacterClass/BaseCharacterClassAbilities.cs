using Assets._Scripts.Abilities;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets._Scripts.Characters.Abstract.PartialBaseCharacterClass
{
    abstract partial class BaseCharacterClass
    {
        protected void SetFirstDefaultAbility(IAbility ability)
        {
            FirstDefaultAbility = ability;
        }

        protected void SetSecondDefaultAbility(IAbility ability)
        {
            SecondDefaultAbility = ability;
        }

        protected void SetFirstSpecialAbility(IAbility ability)
        {
            FirstSpecialAbility = ability;
        }

        protected void SetSecondSpecialAbility(IAbility ability)
        {
            SecondSpecialAbility = ability;
        }

        protected void SetThirdSpecialAbility(IAbility ability)
        {
            ThirdSpecialAbility = ability;
        }

        protected List<IAbility> GetCharacterAbilitiesList()
        {
            var abilitiesList = new List<IAbility>()
            {
                FirstDefaultAbility,
                SecondDefaultAbility,
                FirstSpecialAbility,
                SecondSpecialAbility,
                ThirdSpecialAbility
            };

            if (abilitiesList.Any(x => x != null))
            {
                Debug.LogError(ErrorMessages.NotAllAbilitiesSetDebug);
            }

            return abilitiesList;
        }

        protected IAbility GetFirstDefaultAbility()
        {
            if (FirstDefaultAbility == null)
            {
                Debug.LogError(ErrorMessages.FirstDefaultAbilityNotSet);
                FirstDefaultAbility = new DefaultAbility();
            }

            return FirstDefaultAbility;
        }
        protected IAbility GetSecondDefaultAbility()
        {
            if (SecondDefaultAbility == null)
            {
                Debug.LogError(ErrorMessages.SecondDefaultAbilityNotSet);
                SecondDefaultAbility = new DefaultAbility();
            }

            return SecondDefaultAbility;
        }

        protected IAbility GetFirstSpecialAbility()
        {
            if (FirstSpecialAbility == null)
            {
                Debug.LogError(ErrorMessages.FirstSpecialAbilityNotSet);
                FirstSpecialAbility = new DefaultAbility();
            }

            return FirstSpecialAbility;
        }

        protected IAbility GetSecondSpecialAbility()
        {
            if (SecondSpecialAbility == null)
            {
                Debug.LogError(ErrorMessages.SecondSpecialAbilityNotSet);
                SecondSpecialAbility = new DefaultAbility();
            }

            return SecondSpecialAbility;
        }

        protected IAbility GetThirdSpecialAbility()
        {
            if (ThirdSpecialAbility == null)
            {
                Debug.LogError(ErrorMessages.ThirdSpecialAbilityNotSet);
                ThirdSpecialAbility = new DefaultAbility();
            }

            return ThirdSpecialAbility;
        }
    }
}
