using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    // Start is called before the first frame update
    
    public int maxHealth = 20;
    public int currentHealth;
    public Slider slider;
   // public string ColTag;
    
    public void SetMaxHealth(int health)
    {
        slider.maxValue = maxHealth;
        slider.value = maxHealth;
    }

    void Start()
    {
        currentHealth = maxHealth;
        // maxHealth = 20;
       // ColTag = gameObject.tag + "Wep";
    }
    public void SetHealth(int health)
    {
        slider.value = currentHealth;
    }
    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        if(slider.value == 0)
        {
            Destroy(gameObject.transform.parent.parent.gameObject);
        }
    }


}
