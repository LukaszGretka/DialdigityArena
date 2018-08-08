using Assets._Scripts.Characters.Abstract.Interfaces;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public enum StateValueChangeAction
{
    TakingDamage,
    TakingHealing,
    ChangeMana,
    ChangeStamina
}

public class StatusBarManager : MonoBehaviour
{
    [SerializeField] private Image healthBarFillImage;
    [SerializeField] private Image manaBarFillImage;
    [SerializeField] private Image staminaBarFillImage;
    [SerializeField] private Text valueChangeText;

    private Transform playerTransform;
    private Animator changeValueTextAnimator;
    private ICharacterClass characterClass;

    private void Awake()
    {
        playerTransform = GetComponentInParent<Transform>();
        characterClass = GetComponentInParent<ICharacterClass>();
        changeValueTextAnimator = GetComponentInChildren<Animator>();
    }

    private void Start()
    {
        SetStartingBarValues();
    }

    private void LateUpdate()
    {
        transform.rotation = Quaternion.Euler(new Vector3(90f, Mathf.Abs(playerTransform.rotation.y), 0f));
    }

    private void RefreshPlayerStatusBar()
    {
        staminaBarFillImage.fillAmount = characterClass.GetCurrentStamina() / characterClass.GetMaximumStamina();
        manaBarFillImage.fillAmount = characterClass.GetCurrentMana() / characterClass.GetMaximumMana();
        healthBarFillImage.fillAmount = characterClass.GetCurrentHealth() / characterClass.GetMaximumHealth();
    }

    public void PerformValueChangeTextEffect(float changedValue)
    {
        valueChangeText.text = changedValue.ToString();
        RefreshPlayerStatusBar();
    }

    public void PerformValueChangeTextEffectWithColor(float changedValue, StateValueChangeAction state)
    {
        switch (state)
        {
            case StateValueChangeAction.TakingDamage:
                valueChangeText.color = Color.red;
                break;

            case StateValueChangeAction.TakingHealing:
                valueChangeText.color = Color.green;
                break;

            case StateValueChangeAction.ChangeMana:
                valueChangeText.color = Color.blue;
                break;

            case StateValueChangeAction.ChangeStamina:
                valueChangeText.color = Color.yellow;
                break;
        }

        valueChangeText.text = changedValue.ToString();
        RefreshPlayerStatusBar();
        changeValueTextAnimator.SetTrigger("ValueChangeTrigger");
    }

    public void SetDeathBarValues()
    {
        healthBarFillImage.fillAmount = default(float);
        manaBarFillImage.fillAmount = default(float);
        staminaBarFillImage.fillAmount = default(float);
    }

    private void SetStartingBarValues()
    {
        // "1" is the maximum value for image slider
        float fullFillAmount = 1f;

        healthBarFillImage.fillAmount = fullFillAmount;
        manaBarFillImage.fillAmount = fullFillAmount;
        staminaBarFillImage.fillAmount = fullFillAmount;
    }

}