using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets._Scripts.Characters.Abstract
{
    public interface ICharacterAbilities
    {
        void DefaultAttack();

        void CastFirstAbility();

        void CastSecondAbility();

        void CastThirdAbility();

        void CastFourthAbility();
    }
}
