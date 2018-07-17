using Assets._Scripts.Abilities.Logic;
using System;
using System.Collections;

namespace Assets._Scripts.Abilities.Abstract
{
    public interface IAbilityImplementation
    {
        IEnumerator FirstDefaultAbilityImplementation();
        IEnumerator SecondDefaultAbilityImplementation();

        IEnumerator FirstSpecialAbilityImplementation();
        IEnumerator SecondSpecialAbilityImplementation();
        IEnumerator ThirdSpecialAbilityImplementation();
    }
}