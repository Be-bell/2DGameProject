using System;
using System.Collections;
using UnityEngine;

public class Interact : MonoBehaviour
{
    private EventController eventController;

    private readonly string tagNPC = "NPC";
    private float isKeyOn;
    private bool isInteract = false;
    private bool isCoroutineOn = false;
    [SerializeField] private GameObject dialogPanel;
    [SerializeField] private GameObject PressE;

    private void Awake()
    {
        eventController = GetComponent<EventController>();
    }

    private void Start()
    {
        eventController.InteractEvent += GetInteract;
    }

    private void Update()
    {
        if(isInteract && isKeyOn > 0 && !isCoroutineOn)
        {
            StartCoroutine(StayInteract());
        }
    }

    private void GetInteract(float _value)
    {
        isKeyOn = _value;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.tag == tagNPC)
        {
            PressE.SetActive(true);
            isInteract = true;
        }
    }

    IEnumerator StayInteract()
    {
        isCoroutineOn = true;

        //Debug.Log("상호작용 완료");
        isInteract = false;
        yield return new WaitUntil(() => Dialog());
        isKeyOn = 0;
        isCoroutineOn=false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.transform.tag == tagNPC)
        {
            PressE.SetActive(false);
            isInteract = false;
            EndDialog();
        }
    }

    private bool Dialog()
    {
        dialogPanel.SetActive(true);
        return true;
    }

    public void EndDialog()
    {
        dialogPanel.SetActive(false);
    }

}