using UnityEngine;
using UnityEngine.UI;

public class Shop_Start : MonoBehaviour
{
    public GameObject shop_startpanel;
    public Customer_SpawnPoint CSP;
    public Button shop_yes;
    public Button shop_no;
    public Shop_Interact SI;

    private void Start()
    {
        shop_yes.onClick.AddListener(Start_Shop);
        shop_no.onClick.AddListener(Close_Shop_StartPanel);
    }

    public void Open_Shop_StartPanel()
    {
       
        shop_startpanel.SetActive(true);
    }

    public void Close_Shop_StartPanel()
    {
        SI.shop_start = false;
        shop_startpanel.SetActive(false);
    }
    
    public void Start_Shop()
    {
        SI.shop_start = true;
        CSP.SpawnCustomers();
        shop_startpanel.SetActive(false);
    }
}