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
        private ICharacterClass characterClass;

        private void Awake()
        {
            characterClass = GetComponent<ICharacterClass>();
            abilitiesManager = new AbilitiesPerformanceManager(characterClass);
        }

        private void Update()
        {
            KeyboardInputHandler();
            GetMouseButtonClick();
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
                Debug.Log("Pressed Q");
            }

            else if (Input.GetKeyDown(KeyCode.E))
            {
                abilitiesManager.CastSecondSpecialAbility();
                Debug.Log("Pressed E");
            }

            else if (Input.GetKeyDown(KeyCode.R))
            {
                abilitiesManager.CastSecondSpecialAbility();
                Debug.Log("Pressed R");
            }
        }
    }
}
