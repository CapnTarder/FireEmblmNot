using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{

    public int maxHealth;
    public int currentHealth;
    public int damage;

    public HPBar HPBar;

    public HPBar HPbad;

    public bool range;
    // public TurnManager tm;
    public GameManager GM;
    public GameObject Enemy;
    

    // Start is called before the first frame update
    void Start()
    {
        
        //  GM = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        range = false;
        currentHealth = maxHealth;
        HPBar = gameObject.transform.parent.parent.GetChild(0).GetChild(0).GetComponent<HPBar>();
        HPBar.SetMaxHealth(maxHealth);
    }

    public int TakeDamage(int damage)
    {
        //Debug.Log(Enemy.name);
        HPbad = Enemy.transform.GetChild(0).GetChild(0).GetComponent<HPBar>();
       // Debug.Log(HPbad.gameObject.transform.parent.parent.name);
        HPbad.currentHealth -= damage;
        HPbad.SetHealth(currentHealth);
        return HPbad.currentHealth;
    }

    public void Attack()
    {

        //Debug.Log("this is the attack script");
        //  TurnManager.EndTurn();
        /*  if (range == true)
          {
              return TakeDamage(dmg);
              TurnManager.EndTurn();

          }
          else
          {
              return TakeDamage(0);
              TurnManager.EndTurn();

          }*/
        TakeDamage(damage);
    }

    public void Check()
    {
        // range = false;
        // OnTriggerEnter();

    }




    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered");

        //Debug.Log("triggered" + other.gameObject.name);
        // Enemy = other.gameObject;
        //Debug.Log(HPBar.gameObject.transform.parent.parent.tag);
       if(other.tag != HPBar.gameObject.transform.parent.parent.tag)
       //if (other.tag == "NPC")
        {
            if (other.tag != "Untagged")
            {
                Enemy = other.gameObject;
                range = true;
                //Debug.Log("tag " + other.tag);
                //TakeDamage(damage);
            }
            else
            {
                range = false;
                Enemy = null;
            }
        }


        // Debug.Log("triggered");
    }

   // public void OncolliderExit(Collider other)
    //{

       // Debug.Log("left trigger");
       // Enemy = null;
       // range = false;
    //}
}