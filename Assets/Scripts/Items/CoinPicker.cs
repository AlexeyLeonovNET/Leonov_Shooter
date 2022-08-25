using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{
    private float coins = 0;
    public TMP_Text coinsText;
    private void OnTriggerEnter(Collider collision)
    {
      if(collision.gameObject.tag == "Coin")
        {
            coins++;
            coinsText.text = coins.ToString();
            Destroy(collision.gameObject);
        }  
    }
}
