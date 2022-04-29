using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour
{
       // android: your_id
       // apple: your_id
       //string gameId = "your_id";
      // bool testMode = true;


       private string gameId = "4687121";
   

       void Start()
       {

           // Initialize the Ads service:
           Advertisement.Initialize(gameId);
           //Advertisement.Initialize(gameId, testMode);
       }

       public void ShowInterstitialAd()
       {
           // Check if UnityAds ready before calling Show method:
           if (Advertisement.IsReady())
           {
               Advertisement.Show("GoHome");
           }
           else
           {
               Debug.Log("Interstitial ad not ready at the moment! Please try again later!");
           }
           //Time.timeScale = 0f;
       }
   
}
