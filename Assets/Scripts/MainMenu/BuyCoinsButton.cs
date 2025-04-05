using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyCoinsButton : SimpleButton
{
    private BuyCoins buyCoinsController;
    [SerializeField] private int cost;

    public override void OnClick()
    {
        base.OnClick();
        buyCoinsController.Buy(cost);
    }
    private void Start()
    {
        buyCoinsController = GameObject.FindGameObjectWithTag("BuyCoins").GetComponent<BuyCoins>();
        AddButtonListener();
    }
}