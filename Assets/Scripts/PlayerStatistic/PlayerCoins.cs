using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCoins : MonoBehaviour
{
    [SerializeField] private CoinsData coinsData;

    [SerializeField] private Text mainMenuCoins;
    [SerializeField] private Text shopCoins;
    [SerializeField] private Text backgroundShopCoins;

    private void Start()
    {
        LoadCoins();
    }
    public void LoadCoins()
    {
        if(coinsData.coins >= 1000)
        {
            float coins = coinsData.coins / 1000.0f;
            mainMenuCoins.text = $"{coins}k";
            shopCoins.text = $"{coins}k";
            backgroundShopCoins.text = $"{coins}k";
        }
        else
        {
            mainMenuCoins.text = $"{coinsData.coins}";
            shopCoins.text = $"{coinsData.coins}";
            backgroundShopCoins.text = $"{coinsData.coins}";
        }
    }
}
