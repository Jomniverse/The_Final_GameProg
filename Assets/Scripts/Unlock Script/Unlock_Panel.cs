using UnityEngine;
using UnityEngine.UI;

public class Unlock_Panel : MonoBehaviour
{
    public GameObject unlock_panel;
    public GameObject player_panel;
    public Button panel;

    private void Start()
    {
        panel.onClick.AddListener(Close_unlock);
    }

    public void Open_unlock()
    {
        unlock_panel.SetActive(true);
        player_panel.SetActive(false);
    }

    public void Close_unlock()
    {
        unlock_panel.SetActive(false);
        player_panel.SetActive(true);
    }

}
