using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.OutputMessages;
using UnityEngine;
using UnityEngine.Networking;

namespace Assets._Scripts.Player
{
    [RequireComponent(typeof(ICharacterClass))]
    class PlayerClassManager : NetworkBehaviour
    {
        //holds main characterClass object attached to the game object prefab
        public ICharacterClass characterClass;

        private void Awake()
        {
            characterClass = GetComponent<ICharacterClass>();
        }

        private void Start()
        {
            CheckCharacterClassValidation();
        }

        private void CheckCharacterClassValidation()
        {
            if (characterClass == null)
            {
                Debug.LogError(ErrorMessages.ClassNotImlementingICharacterClassInterface);
            }
        }
    }
}
