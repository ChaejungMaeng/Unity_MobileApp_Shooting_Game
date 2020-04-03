using UnityEngine;
using UnityEngine.EventSystems;

public class ShotButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [HideInInspector]
    public bool Pressed;

    public addbullet shot;

    // Use this for initialization
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
        Debug.Log("press");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }
}