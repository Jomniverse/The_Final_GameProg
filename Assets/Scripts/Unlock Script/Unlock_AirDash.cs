using System;
using UnityEngine;

public class Unlock_AirDash : MonoBehaviour
{
    public bool playerInside = false;
    public bool isUnlock = false;
    public Unlock_Panel UP;

    public UI_Interact UII;
    [SerializeField] private Player_Unlockable PU;
    public Item_Create boots;

    private void Update()
    {
        InteractInput();

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !isUnlock)
        {
            playerInside = true;
            Debug.Log("Press E to collect loot");
            UII.EnterInteract();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !isUnlock)
        {
            playerInside = false;
            UII.ExitInteract();
        }
    }
    void InteractInput()
    {
        if (playerInside && Input.GetKeyDown(KeyCode.E) && !isUnlock)
        {
            boots.item_quantity += 1;
            boots.item_isDiscovered = true;
            UII.ExitInteract();
            UP.Open_unlock();
            PU.unlockAirDash = true;
            isUnlock = true;
        }
    }
}
