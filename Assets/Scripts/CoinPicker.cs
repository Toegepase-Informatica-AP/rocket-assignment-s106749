using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPicker : MonoBehaviour
{
    private int coin;
    public TextMeshProUGUI textCoins;
    public TextMeshProUGUI textScore;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Coin"))
        {
            coin++;
            textCoins.text = coin.ToString();
            textScore.text = coin.ToString();
            Destroy(other.gameObject);
        }
    }
}
