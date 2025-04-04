using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyCoins : MonoBehaviour
{
    [SerializeField] private GameObject purchaseMenu;

    [SerializeField] private int coins;

    [SerializeField] private CoinsData coinsData;

    [SerializeField] private PlayerCoins playerCoins;

    public void Buy(int price)
    {
        coins = price;
        StartCoroutine("Timer");
    }

    IEnumerator Timer()
    {
        purchaseMenu.SetActive(true);
        yield return new WaitForSeconds(3);
        purchaseMenu.SetActive(false);
        coinsData.coins += coins;
        playerCoins.LoadCoins();
    }
}
