using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : MonoBehaviour { 

    public float HP;
    public float maxHP;

    public GameObject HPbar;
    public Slider HPbarSlider;

    public GameObject DeadDrop;

    void Start ()
    {
        HP = maxHP;
    }

    public void DealDamage (float damage) 
    {
        HPbar.SetActive (true);
        HPbarSlider.value = CalculateHPprecentage();
         HP -= damage;
        CheckDeath();

    }

    public void HealCharacter(float heal)
    {
        HP += heal;
        CheckOverHeal();
        HPbarSlider.value = CalculateHPprecentage();
    }

    private void CheckOverHeal ()
    {
         if (HP > maxHP)
        {
            HP = maxHP;
        }
    }
    private void CheckDeath () 
    {
    if(HP <= 0) 
        {
            Destroy(gameObject);
            Instantiate(DeadDrop, transform.position, Quaternion.identity);
        }
    }
    private float CalculateHPprecentage()
    {
        return (HP / maxHP);

    }
}
