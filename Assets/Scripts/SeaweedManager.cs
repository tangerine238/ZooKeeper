using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SeaweedManager : MonoBehaviour
{
    public bool offlineProgressCheck;
    float money;
    public TextMeshProUGUI MoneyText;

    void Start()
    {
        money = 0;
    }


    void Update()
    {
        money += Time.deltaTime;
        MoneyText.text = "$" + money.ToString("F");
    }
}
