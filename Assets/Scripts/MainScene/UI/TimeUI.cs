using UnityEngine;
using System;
using UnityEngine.UI;
public class TimeUI : MonoBehaviour
{
    private Text timeTxt;

    private void Awake()
    {
        timeTxt = GetComponent<Text>();
    }

    private void Update()
    {
        UpdateTime();
    }

    private void UpdateTime()
    {
        timeTxt.text = DateTime.Now.ToString(("HH:mm"));
    }
}