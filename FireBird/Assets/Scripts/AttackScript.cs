using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{

    public int maxHealth;
    public int currentHealth;
    public int damage;
    public HPBar HPBar;



    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        HPBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }

    public void Attack()
    {

    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
