using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour
{
    private DataManager dataManager;
    private Text inGameTxt;

    List<string> inGameList = new List<string>();

    private void Awake()
    {
        inGameTxt = GetComponentInChildren<Text>();
        dataManager = DataManager.Instance;
    }

    private void OnEnable()
    {
        ListUpdate();
    }

    private void ListUpdate()
    {
        inGameList.Add(dataManager.userName);
        GameObject[] npcObjects = GameObject.FindGameObjectsWithTag("NPC");
        foreach (GameObject npcObject in npcObjects)
        {
            inGameList.Add(npcObject.GetComponentInChildren<Text>().text.ToString());
        }

        foreach (string player in inGameList)
        {
            inGameTxt.text += string.Format(player + "\n\n");
        }

    }

    private void OnDisable()
    {
        ResetTxt();
    }

    private void ResetTxt()
    {
        inGameList.Clear();
        inGameTxt.text = string.Empty;
    }
}