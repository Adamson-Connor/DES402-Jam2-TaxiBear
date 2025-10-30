using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class UIButtonAnimations : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private float maxScale = 1.2f;
    [SerializeField] private float defaultScale = 1f;
    [SerializeField] private float scaleTimerIncrease = 0.2f;
    [SerializeField] private float scaleTimerDecrease = 0.1f;

    private GameObject button;

    public void Start()
    {
        button = gameObject;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        LeanTween.scale(button, Vector2.one * maxScale, scaleTimerIncrease); //.setLoopPingPong();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //LeanTween.pause(button);
        LeanTween.scale(button, Vector2.one * defaultScale, scaleTimerDecrease);
    }
}
