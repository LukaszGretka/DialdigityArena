using Assets._Scripts.Abilities.Performance;
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.OutputMessages;
using UnityEngine;
using UnityEngine.Networking;

namespace Assets._Scripts.Player
{
    [RequireComponent(typeof(ICharacterClass))]
    class PlayerClassManager : NetworkBehaviour
    {
        private ICharacterClass characterClass;

        private void Awake()
        {
            characterClass = GetComponent<ICharacterClass>();
            AttachRequiredPlayerScripts();
        }

        private void Start()
        {
           // PlayerStatisticManager.OnPlayerDeath += PlayerStatisticManager_OnPlayerDeath;
            CheckCharacterClassValidation();
        }

        private void PlayerStatisticManager_OnPlayerDeath()
        {
            DetachRequiredPlayerSCripts();
        }

        private void CheckCharacterClassValidation()
        {
            if (characterClass == null)
            {
                Debug.LogError(ErrorMessages.ClassNotImlementingICharacterClassInterface);
            }
        }

        private void AttachRequiredPlayerScripts()
        {
            gameObject.AddComponent<PlayerMovement>();
            gameObject.AddComponent<PlayerCameraController>();
            gameObject.AddComponent<PlayerAbilitiesController>();
            gameObject.AddComponent<AbilitiesPerformanceManager>();
        }

        private void DetachRequiredPlayerSCripts()
        {
            Destroy(GetComponent<PlayerMovement>());
            Destroy(GetComponent<PlayerCameraController>());
            Destroy(GetComponent<PlayerAbilitiesController>());
            Destroy(GetComponent<AbilitiesPerformanceManager>());
        }
    }
}