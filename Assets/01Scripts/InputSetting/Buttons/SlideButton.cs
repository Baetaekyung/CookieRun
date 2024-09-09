using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideButton : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader;

    public void OnClickBtn()
    {
        _inputReader.OnSlideBtnClicked();
    }
}
