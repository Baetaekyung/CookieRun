using UnityEngine;

[CreateAssetMenu(menuName = "Managers/MovementManagerSO")]
public class MovementManagerSO : ScriptableObject
{
    private int _maxJumpCnt = 0; //ĳ���� ���� �ٸ��� ������ �÷��̾ ���� ���� �޾ƿ���
    private int _currentJumpCnt = 0;
    private bool _isSliding = false;

    #region Jump methods

    public void InitMaxJumpCnt(int maxJumpCnt) => _maxJumpCnt = maxJumpCnt; //�ִ�� �� �� �ִ� ���� Ƚ��

    public void SetJumpCnt(int jumpCnt) => _currentJumpCnt = jumpCnt; //���� ���� Ƚ���� ����

    public void AddJumpCnt() => SetJumpCnt(++_currentJumpCnt); //���� �� �� ���� ȣ��

    public void InitJump() => _currentJumpCnt = 0; //���� ���� Ƚ���� 0���� �ʱ�ȭ(���� ����� �� �Ǵ� �ε����� ��)

    #endregion

    #region Slide methods

    public bool GetSliding() => _isSliding; //���� �����̵� ���¸� ����

    public void SetSlideActive(bool slideActive) => _isSliding = slideActive; //���� �����̵� ���¸� ����

    #endregion
}
