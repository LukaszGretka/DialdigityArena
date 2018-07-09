using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Characters.Conditions;
using Assets._Scripts.Conditions;
using Assets._Scripts.Conditions.Harmful;
using Assets._Scripts.Player;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

	void Update ()
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
            else
            {

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

    public void BleedingButton_OnClick()
    {
        int durationTime = Int32.Parse(bleedingDamageValue.text);

        ConditionManager conditionManager = gameObject.AddComponent<ConditionManager>();
        Bleeding bleeding = new Bleeding(5f,durationTime,1,1);
        List <ICondition> conditions = new List<ICondition>();
        conditions.Add(bleeding);
        conditionManager.AddConditionsToTarget(selectedCharacterClass, conditions);
    }

    public void PoisonButton_OnClick()
    {    
        int durationTime = Int32.Parse(poisonDamageValue.text);
        ConditionManager conditionManager = gameObject.AddComponent<ConditionManager>();
        Poison poison = new Poison(5f, durationTime, 1, 1);
        List<ICondition> conditions = new List<ICondition>();
        conditions.Add(poison);
        conditionManager.AddConditionsToTarget(selectedCharacterClass, conditions);
    }

    public void SlowButton_OnClick()
    {
        int durationTime = Int32.Parse(movementSlowValue.text);

        ConditionManager conditionManager = gameObject.AddComponent<ConditionManager>();
        Slow slow = new Slow(durationTime,20);
        List<ICondition> conditions = new List<ICondition>();
        conditions.Add(slow);
        conditionManager.AddConditionsToTarget(selectedCharacterClass, conditions);
        Debug.LogError("Something wrong with logic");
        //TODO FIX LOGIC
    }


    public void StunButton_OnClick()
    {
        int durationTime = Int32.Parse(movementSlowValue.text);
        throw new NotImplementedException();
        //TODO Methods for stun condition are not implemented.
    }

    #endregion
}
