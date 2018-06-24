using Assets._Scripts.Abilities.Logic;
using System;
using System.Collections.Generic;

namespace Assets._Scripts.Abilities.Abstract
{
    public interface IAbilityImplementation
    {
        List<AbilityLogicResult> FirstDefaultAbilityImplementation();
        Action SecondDefaultAbilityImplementation();

        Action FirstSpecialAbilityImplementation();
        Action SecondSpecialAbilityImplementation();
        Action ThirdSpecialAbilityImplementation();
    }
}
