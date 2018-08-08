using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRegeneration : MonoBehaviour
{
    private ICharacterClass characterClass;

    private void Awake()
    {
        characterClass = GetComponent<ICharacterClass>();
    }

    private void Start()
    {
        InvokeRepeating("StartPlayerHealthRegeneration", 0f, 1f);
        InvokeRepeating("StartPlayerManaRegeneration", 0f, 1f);
        InvokeRepeating("StartPlayerStaminaRegeneration", 0f, 1f);
    }

    private void OnDestroy()
    {
        CancelInvoke("StartPlayerHealthRegeneration");
        CancelInvoke("StartPlayerManaRegeneration");
        CancelInvoke("StartPlayerStaminaRegeneration");
    }

    private void StartPlayerHealthRegeneration()
    {
        PlayerStatisticManager.HealthRegeneration(characterClass);
    }

    private void StartPlayerManaRegeneration()
    {
        PlayerStatisticManager.ManaRegeneration(characterClass);
    }

    private void StartPlayerStaminaRegeneration()
    {
        PlayerStatisticManager.StaminaRegeneration(characterClass);
    }
}