using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets._Scripts.Abilities.Abstract
{
    interface IAbilityPerformance
    {
        void CastFirstDefaultAbility();

        void CastSecondDefaultAbility();

        void CastFirstSpecialAbility();

        void CastSecondSpecialAbility();

        void CastThirdSpecialAbility();
    }
}
