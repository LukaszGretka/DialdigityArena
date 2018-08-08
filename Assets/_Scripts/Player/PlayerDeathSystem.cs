using Assets._Scripts.Abilities.Performance;
using Assets._Scripts.Characters.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace Assets._Scripts.Player
{
    internal class PlayerDeathSystem : MonoBehaviour
    {
        [SerializeField] private float gameObjectDestroyTime = 1f;

        private void Start()
        {
            PlayerStatisticManager.OnPlayerDeath += PlayerStatisticManager_OnPlayerDeath;
        }

        private void PlayerStatisticManager_OnPlayerDeath(ICharacterClass characterClass)
        {
            HandlePlayerDeath(characterClass);
        }

        public void HandlePlayerDeath(ICharacterClass characterClass)
        {
            CancelAllPerformingCoroutines(characterClass);
            DisablePlayerPhysic(characterClass);
            characterClass.PlayerClassManager.GetComponentInChildren<StatusBarManager>().SetDeathBarValues();

            Destroy(characterClass.PlayerClassManager.gameObject, gameObjectDestroyTime);
        }

        private void DisablePlayerPhysic(ICharacterClass characterClass)
        {
            characterClass.PlayerClassManager.GetComponent<Rigidbody>().detectCollisions = false;
        }

        private void CancelAllPerformingCoroutines(ICharacterClass characterClass)
        {
            characterClass.PlayerClassManager.GetComponent<PlayerMovement>().StopAllCoroutines();
            characterClass.PlayerClassManager.GetComponent<PlayerCameraController>().StopAllCoroutines();
            characterClass.PlayerClassManager.GetComponent<PlayerAbilitiesController>().StopAllCoroutines();
            characterClass.PlayerClassManager.GetComponent<AbilitiesPerformanceManager>().StopAllCoroutines();
        }
    }
}