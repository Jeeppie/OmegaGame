using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats playerStats;

    public GameObject player;
    public TextMeshProUGUI HPtext;
    public Slider HPslider;

    public float HP;
    public float maxHP;

    public int coins;
    public TextMeshProUGUI coinsValue;

    private void Awake()
    {
        if (playerStats != null)
        {
            Destroy(playerStats);
        }
        else
        {
            playerStats = this;
        }
       
        DontDestroyOnLoad(this);
    }

    void Start()
    {
        HP = maxHP;
        SetHealUI();
    }

    public void DealDamage(float damage)
    {
        HP -= damage;
        CheckDeath();
        SetHealUI();
    }

    public void HealCharacter(float heal)
    {
        HP += heal;
        CheckOverHeal();
        SetHealUI();
    }

    private void SetHealUI()
    {
        HPslider.value = CalculateHPpercentage();
        HPtext.text = Mathf.Ceil(HP).ToString() + "/" + Mathf.Ceil(maxHP).ToString();

    }

    private void CheckOverHeal()
    {
        if (HP > maxHP)
        {
            HP = maxHP;
        }
    }
    private void CheckDeath()
    {
        if (HP <= 0)
        {
            Destroy(player);
        }
    }
    float CalculateHPpercentage()
    {
        return HP / maxHP;
    }
    public void AddCurrency(CurrenctPickup currency)
    {
        if (currency.currentObject == CurrenctPickup.PickupObject.COIN) 
        {
            coins += currency.pickupQuantity;
            coinsValue.text = "Gold: " + coins.ToString();
        }
    }
}
