using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ButtonPressed : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private float _holdDuration;

    [SerializeField] private UnityEvent OnHold;

    private bool _isHoldingButton;
    private float _elapsedTime;

    public void OnPointerDown(PointerEventData eventData) => ToggleHoldingButton(true);

    private void ToggleHoldingButton(bool isPointerDown)
    {
        _isHoldingButton = isPointerDown;

        if (isPointerDown)
            _elapsedTime = 0;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ToggleHoldingButton(false);
    }

    private void ManageButtonInteraction()
    {
        if (!_isHoldingButton)
            return;

        _elapsedTime += Time.deltaTime;
        var isHoldClickDurationReached = _elapsedTime > _holdDuration;

        if (isHoldClickDurationReached)
            HoldClick();
    }


    private void HoldClick()
    {
        ToggleHoldingButton(false);
        OnHold?.Invoke();
    }

    private void Update() => ManageButtonInteraction();
}