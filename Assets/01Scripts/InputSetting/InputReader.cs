using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/InputReader")]
public class InputReader : ScriptableObject
{
    public event Action<int> OnJumpEvent;
    public event Action<bool> OnSlideEvent;

    private int _maxJumpCnt = 0;
    private int _currentJumpCnt = 0;

    private bool _isSliding = false;

    private void Awake()
    {
        if (_maxJumpCnt == 0)
            SetMaxJumpCount(2);
    }

    public void OnJumpBtnClicked()
    {
        if (_currentJumpCnt == _maxJumpCnt) return;

        _currentJumpCnt++;
        OnJumpEvent?.Invoke(_currentJumpCnt);
    }

    public void OnSlideBtnClicked()
    {
        OnSlideEvent?.Invoke(true);
    }

    public void OffSlideBtnClicked()
    {
        OnSlideEvent?.Invoke(false);
    }

    public void InitializeCurrentJumpCount() => _currentJumpCnt = 0;
    public void SetMaxJumpCount(int maxJumpCount) => _maxJumpCnt = maxJumpCount;
    public int GetCurrentJumpCount() => _currentJumpCnt;
}
