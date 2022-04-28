using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public AdManager Ad;
    TurnManager tm;
    public void LoadLevel()
    {
        SceneManager.LoadScene("Test");

    }
    public void LoadMenu()
    {


        Ad.ShowInterstitialAd();



        SceneManager.LoadScene("MainMenu");
    }


    // Start is called before the first frame update
    void Start()
    {
        Ad = GameObject.FindGameObjectWithTag("AdTime").GetComponent<AdManager>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
