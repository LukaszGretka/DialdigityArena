using Assets._Scripts.Characters.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets._Scripts.Abilities.Logic.Results
{
    public class TargetDetectionResult
    {
        public ICharacterClass TargetHitOnCast { get; private set; }
        public float DealedDamage { get; private set; }
        public IAbility HitWithAbility { get; private set; }
        public float HitDistance { get; private set; }
        public float HitOnAngle { get; private set; }

        internal static TargetDetectionResult BuildAbilityLogicResult( ICharacterClass target, IAbility usedAbility, 
                                                                    float damage, float hitDistance = default(float), float hitAngle = default(float))
        {
            return new TargetDetectionResult()
            {
                TargetHitOnCast = target,
                DealedDamage = damage,
                HitWithAbility = usedAbility,
                HitDistance = hitDistance,
                HitOnAngle = hitAngle
            };
        }
    }
}
