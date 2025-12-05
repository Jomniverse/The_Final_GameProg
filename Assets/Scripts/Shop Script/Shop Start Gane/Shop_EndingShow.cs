using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Shop_EndingShow : MonoBehaviour
{
    [Header("Panel")]
    public GameObject good_panel;
    public GameObject bad_panel;

    public GameObject player_panel;


    [Header("Text")]
    public TMP_Text good_quota;
    public TMP_Text bad_quota;

    [Header("Button")]
    public Button good_button;
    public Button bad_button;

    [Header("Reference")]
    public Coin_Manager CM;

    private void Start()
    {
        good_panel.SetActive(false);
        bad_panel.SetActive(false);

        good_button.onClick.AddListener(ExitGame);
        bad_button.onClick.AddListener(ExitGame);
    }

    public void ShowEnding()
    {
        player_panel.SetActive(false);


        bool reachedGoal = CM.coin_count >= CM.coin_goal;

        if (good_panel != null) good_panel.SetActive(reachedGoal);
        if (bad_panel != null) bad_panel.SetActive(!reachedGoal);

        string quotaText = ": " + CM.coin_count + "/ " + CM.coin_goal;

        if (good_quota != null) good_quota.text = quotaText;
        if (bad_quota != null) bad_quota.text = quotaText;


    }

    private void ExitGame()
    {
        Application.Quit();

        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}