using Assets._Scripts.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets._Scripts.Characters.Abstract
{
    public interface ICharacterAbilities
    {
        IAbility FirstDefaultAbility { get; }

        IAbility SecondDefaultAbility { get; }

        IAbility FirstSpecialAbility { get; }

        IAbility SecondSpecialAbility { get; }

        IAbility ThirdSpecialAbility { get; }
    }
}
