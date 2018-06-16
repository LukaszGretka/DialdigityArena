using Assets._Scripts.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets._Scripts.Characters.Abstract
{
    public interface ICharacterAbilities
    {
        void SetFirstDefaultAbility(IAbility ability);

        void SetSecondDefaultAbility(IAbility ability);

        void SetFirstSpecialAbility(IAbility ability);

        void SetSecondSpecialAbility(IAbility ability);

        void SetThirdSpecialAbility(IAbility ability);
    }
}
