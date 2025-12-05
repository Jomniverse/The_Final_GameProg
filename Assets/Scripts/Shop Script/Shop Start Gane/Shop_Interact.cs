using UnityEngine;
using UnityEngine.UI;

public class Shop_Interact : MonoBehaviour
{
    private bool playerInside = false;
    public UI_Interact UII;
    public bool shop_start = false;
    public Shop_Start SS;
    public Shop_End SE;

    private void Update()
    {
        InteractInput();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInside = true;
            Debug.Log("Press E to start shop");
            UII.EnterInteract();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInside = false;
            UII.ExitInteract();
        }
    }

    void InteractInput()
    {
        if (playerInside && Input.GetKeyDown(KeyCode.E) && !shop_start)
        {
           
            UII.ExitInteract();
            SS.Open_Shop_StartPanel();
            Debug.Log("shop");
            playerInside = false;
        }

        else if (playerInside && Input.GetKeyDown(KeyCode.E) && shop_start)
        {

            UII.ExitInteract();
            SE.Open_Shop_EndPanel();
            Debug.Log("shop");
            playerInside = false;
        }

    }
}
