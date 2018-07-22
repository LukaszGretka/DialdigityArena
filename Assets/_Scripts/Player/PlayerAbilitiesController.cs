using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Abilities.Performance;
using Assets._Scripts.Characters.Abstract.Interfaces;
using UnityEngine;
using UnityEngine.Networking;

namespace Assets._Scripts.Player
{
    [RequireComponent(typeof(PlayerClassManager))]
    [RequireComponent(typeof(ICharacterClass))]
    internal class PlayerAbilitiesController : NetworkBehaviour
    {
        private IAbilityPerformance abilitiesManager;
        private bool disablePlayerControl = false;
        private ICharacterClass characterClass;

        private void Awake()
        {
            characterClass = GetComponent<ICharacterClass>();
            abilitiesManager = GetComponent<AbilitiesPerformanceManager>();
        }

        private void Start()
        {
            PlayerStatisticManager.OnPlayerDeath += PlayerStatisticManager_OnPlayerDeath;
        }

        private void PlayerStatisticManager_OnPlayerDeath()
        {
            disablePlayerControl = true;
        }

        private void Update()
        {
            if (isLocalPlayer)
            {
                if (disablePlayerControl == false)
                {
                    KeyboardInputHandler();
                    GetMouseButtonClick();
                }
            }
        }

        private void GetMouseButtonClick()
        {
            //check incoming input for left mouse button
            if (Input.GetMouseButtonDown(0)) 
            {
                abilitiesManager.CastFirstDefaultAbility();
            }

            //check incoming input for right mouse button
            if (Input.GetMouseButtonDown(1)) 
            {
                abilitiesManager.CastSecondDefaultAbility();
            }
        }

        private void KeyboardInputHandler()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                abilitiesManager.CastFirstSpecialAbility();
            }

            else if (Input.GetKeyDown(KeyCode.E))
            {
                abilitiesManager.CastSecondSpecialAbility();
            }

            else if (Input.GetKeyDown(KeyCode.Space))
            {
                abilitiesManager.CastThirdSpecialAbility();
            }
        }
    }
}