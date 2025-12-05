using UnityEngine;
using UnityEngine.UI;

public class Shop_End : MonoBehaviour
{
    public GameObject shop_endpanel;
    public Customer_SpawnPoint CSP;
    public Button End_yes;
    public Button End_no;
    public Shop_Interact SI;
    public Shop_EndingShow SHS;

    private void Start()
    {
        End_yes.onClick.AddListener(End_Shop);
        End_no.onClick.AddListener(Close_Shop_EndPanel);
    }

    public void Open_Shop_EndPanel()
    {
        shop_endpanel.SetActive(true);
    }

    public void Close_Shop_EndPanel()
    {
        shop_endpanel.SetActive(false);
    }

    public void End_Shop()
    {
        shop_endpanel.SetActive(false);
        SHS.ShowEnding();
    }
}
