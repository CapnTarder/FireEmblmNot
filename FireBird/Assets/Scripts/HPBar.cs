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
    
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    void Start()
    {
       // currentHealth = maxHealth;
       // maxHealth = 20;
    }
    public void SetHealth(int health)
    {
        slider.value = health;
    }
    // Update is called once per frame
    void Update()
    {

    }

  
}
