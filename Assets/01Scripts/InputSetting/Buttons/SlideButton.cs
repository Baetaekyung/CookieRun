using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlideButton : MonoBehaviour,
    IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private MovementManagerSO _movementManager;

    public Action<bool> OnSlide;

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Slide true");
        _movementManager.SetSlideActive(true);
        OnSlide?.Invoke(true);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Slide false");
        _movementManager.SetSlideActive(false);
        OnSlide?.Invoke(false);
    }
}
