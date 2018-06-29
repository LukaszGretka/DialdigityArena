using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Player;
using System.Collections;
using UnityEngine;

namespace Assets._Scripts.Characters.Conditions
{
    //TODO MonoBehaviour to base class
    internal class Bleeding : MonoBehaviour, IConditions
    {
        public string Name { get; private set; } = "Bleeding";

        public float DamagePerTick { get; private set; } = 5f;

        public float DurationTime { get; set; } 
        
        public float SlowStrength {  get; private set; }
    }
}
