using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Animations;

namespace Assets._Scripts.Abilities.Abstract
{
    public interface IAbilityGameEffect
    {
        GameObject AbilityGameModel { get; }
        ParticleSystem AttachedParticle { get; }
    }
}
