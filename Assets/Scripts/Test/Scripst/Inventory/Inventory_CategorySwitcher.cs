using UnityEngine;
using UnityEngine.UI;

public class Inventory_CategorySwitcher : MonoBehaviour
{
    [Header("Inventory Slots")]
    public Inventory_Slot[] allSlots;


    [Header("Category Buttons")]
    public Button buttonAll;
    public Button buttonWeapons;
    public Button buttonMaterials;
    public Button buttonRelic;

    void Awake()
    {
        allSlots = GetComponentsInChildren<Inventory_Slot>(true);
    }

    void Start()
    {
        if (buttonAll) buttonAll.onClick.AddListener(() => ShowAll());
        if (buttonWeapons) buttonWeapons.onClick.AddListener(() => ShowCategory(Item_Category.Weapons));
        if (buttonMaterials) buttonMaterials.onClick.AddListener(() => ShowCategory(Item_Category.Materials));
        if (buttonRelic) buttonRelic.onClick.AddListener(() => ShowCategory(Item_Category.Relic));

        ShowAll();  
    }


    public void ShowAll()
    {
        foreach (var slot in allSlots)
            slot.gameObject.SetActive(true);
    }

    public void ShowCategory(Item_Category category)
    {
        foreach (var slot in allSlots)
        {
            if (slot == null || slot.ITEM == null)
            {
                slot.gameObject.SetActive(false);
                continue;
            }

            bool match = slot.ITEM.item_category == category;
            slot.gameObject.SetActive(match);
        }
    }
}

