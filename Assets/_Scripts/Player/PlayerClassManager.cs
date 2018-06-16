using Assets._Scripts.Abilities;
using Assets._Scripts.Characters;
using Assets._Scripts.Characters.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

namespace Assets._Scripts.Player
{
    class PlayerClassManager : NetworkBehaviour
    {
        [SerializeField] private ICharacterClass characterClass;

        private void Awake()
        {
            characterClass = GetComponent<ICharacterClass>();
        }

        private void Start()
        {
            characterClass.GetCharacterAbilitiesList().ForEach(x => Debug.Log(x.Name));
        }

    }
}
