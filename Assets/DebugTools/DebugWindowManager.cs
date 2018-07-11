using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Characters.Conditions;
using Assets._Scripts.Conditions;
using Assets._Scripts.Conditions.Harmful;
using Assets._Scripts.Player;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DebugWindowManager : MonoBehaviour
{ 
    private ICharacterClass selectedCharacterClass;

    [SerializeField] private Text selectedTargetText;
    public GameObject ConditionPanelObject;
    public InputField bleedingDamageValue;
    public InputField poisonDamageValue;
    public InputField movementSlowValue;
    public InputField stunValue;

	private void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SelectTargetFromScreen();
        }
    }

    private void SelectTargetFromScreen()
    {
        Ray rayFromCam = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit rayHit;

        if (Physics.Raycast(rayFromCam, out rayHit, Camera.main.farClipPlane))
        {
            if (rayHit.collider.tag == "Target" || rayHit.collider.tag == "Player")
            {
                selectedTargetText.text = rayHit.collider.name;
                selectedCharacterClass = rayHit.collider.GetComponent<ICharacterClass>();
            }
        }
    }

    public void HealthButton_OnClick()
    {
        selectedCharacterClass.TakeHealing(selectedCharacterClass.GetMaximumHealth());
    }

    public void ManaButton_OnClick()
    {
        selectedCharacterClass.AddMana(selectedCharacterClass.GetMaximumMana());
    }

    public void StaminaButton_OnClick()
    {
        selectedCharacterClass.AddStamina(selectedCharacterClass.GetMaximumStamina());
    }

    public void KillButton_OnClick()
    {
        selectedCharacterClass.TakeDamage(selectedCharacterClass.GetMaximumHealth());
    }

    public void ConditionButton_OnClick()
    {
        if (ConditionPanelObject.activeInHierarchy)
        {

            ConditionPanelObject.SetActive(false);
        }
        else ConditionPanelObject.SetActive(true);
    }
    #region Condition Buttons

    private void AddConditionToPlayerByDebuger(ICondition condition)
    {
        gameObject.AddComponent<ConditionManager>().AddConditionsToTarget(selectedCharacterClass, new List<ICondition>() { condition });
    }

    public void BleedingButton_OnClick()
    {
        AddConditionToPlayerByDebuger(new Bleeding(5f, Int32.Parse(bleedingDamageValue.text), 1, 1));
    }

    public void PoisonButton_OnClick()
    {
        AddConditionToPlayerByDebuger(new Poison(5f, Int32.Parse(poisonDamageValue.text), 1, 1));
    }

    public void SlowButton_OnClick()
    {
        AddConditionToPlayerByDebuger(new Slow(Int32.Parse(movementSlowValue.text), 20));
    }

    public void StunButton_OnClick()
    {
        AddConditionToPlayerByDebuger(new Stun(Int32.Parse(stunValue.text)));
    }

    #endregion
}
