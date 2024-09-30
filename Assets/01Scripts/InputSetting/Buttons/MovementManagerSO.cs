using UnityEngine;

[CreateAssetMenu(menuName = "Managers/MovementManagerSO")]
public class MovementManagerSO : ScriptableObject
{
    private int _maxJumpCnt = 0; //캐릭터 마다 다르기 때문에 플레이어가 가진 정보 받아오기
    private int _currentJumpCnt = 0;
    private bool _isSliding = false;

    #region Jump methods

    public void InitMaxJumpCnt(int maxJumpCnt) => _maxJumpCnt = maxJumpCnt; //최대로 뛸 수 있는 점프 횟수

    public void SetJumpCnt(int jumpCnt) => _currentJumpCnt = jumpCnt; //현재 점프 횟수를 설정

    public void AddJumpCnt() => SetJumpCnt(++_currentJumpCnt); //점프 할 때 마다 호출

    public void InitJump() => _currentJumpCnt = 0; //현재 점프 횟수를 0으로 초기화(땅에 닿았을 때 또는 부딪혔을 때)

    #endregion

    #region Slide methods

    public bool GetSliding() => _isSliding; //현재 슬라이딩 상태를 리턴

    public void SetSlideActive(bool slideActive) => _isSliding = slideActive; //현재 슬라이드 상태를 설정

    #endregion
}
