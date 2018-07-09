using UnityEngine;

namespace Assets._Scripts.Abilities.Abstract
{
    public interface IAbilityWithGameEffect : IAbility
    {
        GameObject AbilityGameModel { get; }
        ParticleSystem AttachedParticle { get; }
    }
}