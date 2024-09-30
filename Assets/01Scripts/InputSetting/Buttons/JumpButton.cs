using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class JumpButton : MonoBehaviour,
    IPointerDownHandler
{
    [SerializeField] private MovementManagerSO _movementManager;
    public event Action OnJump;

    public void OnPointerDown(PointerEventData eventData)
    {
        _movementManager.SetSlideActive(false);
        _movementManager.AddJumpCnt();
        Debug.Log("Jump");

        OnJump?.Invoke();
    }
}
