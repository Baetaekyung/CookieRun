using UnityEngine;

public class JumpButton : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader;

    public void OnClickBtn()
    {
        _inputReader.OnJumpBtnClicked();
    }
}
