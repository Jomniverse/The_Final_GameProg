using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Coin_Manager : MonoBehaviour
{
    public int coin_count;
    public int coin_goal;
    public TMP_Text coin_text_owned;
    public TMP_Text coin_text_goal;
    public Image coin_image;
   

    void Update()
    {
        SetMoney();
    }

    public void SetMoney()
    {
        coin_text_owned.text = ": " + coin_count.ToString();
        coin_text_goal.text = "Goal: " + coin_goal.ToString();
    }
}
