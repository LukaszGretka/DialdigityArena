using System;

namespace Assets._Scripts.Abilities.Abstract
{
    public interface IAbilityImplementation
    {
        Action FirstDefaultAbilityImplementation();
        Action SecondDefaultAbilityImplementation();

        Action FirstSpecialAbilityImplementation();
        Action SecondSpecialAbilityImplementation();
        Action ThirdSpecialAbilityImplementation();
    }
}
