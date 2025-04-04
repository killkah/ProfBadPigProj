using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TipController : MonoBehaviour
{
    [SerializeField] private Text tipText;

    private string tip;

    public void ChangeTip(string value)
    {
        tip = value;
        StartCoroutine("Timer");
    }
    public void Cancel()
    {
        tipText.text = "";
        StopCoroutine("Timer");
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2);
        tipText.text = tip;
    }
}
