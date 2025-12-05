using UnityEngine;
using UnityEngine.UI;

public class UI_Tab : MonoBehaviour
{
    [Header("Panels")]
    public GameObject tab_menu;
    public GameObject panel_setting;
    public GameObject panel_inventory;

    [Header("Buttons")]
    public Button button_inventory;
    public Button button_exit;


    [Header("Reference")]
    public Player_Tab PT;
    public Inventory_Manager IM;
    public Inventory_CategorySwitcher ICS;

    void Start()
    {
        // Always show records first on start
        OpenInventory();

        // Hook up buttons
        ButtonInput();
    }

    private void ButtonInput()
    {
        button_exit.onClick.AddListener(ExitTab);
        button_inventory.onClick.AddListener(OpenInventory);
    }

    private void ExitTab()
    { 
        PT.CloseTab();
    }

    public void OpenInventory()
    {
        panel_setting.SetActive(false);
        panel_inventory.SetActive(true);
        IM.RefreshInventory();
        ICS.ShowAll();
    }

}