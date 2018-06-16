using Assets._Scripts.Characters.Abstract.Interfaces;
using UnityEngine;
using UnityEngine.Networking;

namespace Assets._Scripts.Player
{
    class PlayerClassManager : NetworkBehaviour
    {
        private ICharacterClass characterClass; //holds main characterClass object attached to the game object prefab

        private void Awake()
        {
            characterClass = GetComponent<ICharacterClass>();
        }

        private void Start()
        {
            Debug.Log(characterClass.GetFirstSpecialAbility().Name);
            Debug.Log(characterClass.GetCurrentHealth());
        }
    }
}
