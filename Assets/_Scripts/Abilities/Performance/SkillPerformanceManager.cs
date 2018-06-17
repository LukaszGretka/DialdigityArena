using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Characters.Abstract.Interfaces;
using System;
using UnityEngine.Networking;

namespace Assets._Scripts.Abilities.Performance
{
    internal class SkillPerformanceManager : NetworkBehaviour, IAbilityPerformance
    {
        public void CastFirstDefaultAbility()
        {
            throw new NotImplementedException();
        }

        public void CastFirstSpecialAbility()
        {
            throw new NotImplementedException();
        }

        public void CastSecondDefaultAbility()
        {
            throw new NotImplementedException();
        }

        public void CastSecondSpecialAbility()
        {
            throw new NotImplementedException();
        }

        public void CastThirdSpecialAbility()
        {
            throw new NotImplementedException();
        }
    }
}
