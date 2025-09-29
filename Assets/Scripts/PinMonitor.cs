using UnityEngine;

public class PinMonitor : MonoBehaviour
{

    private Vector3 initialPosition;
    private Quaternion initialRotation;

    public float positionThreshold = 0.1f; // 位置ズレのしきい値
    public float angleThreshold = 10f;     // 回転ズレのしきい値（度）
    public Score score_sc;

    private bool hasMoved = false;

    void Start()
    {
        // 初期位置・回転を保存
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }

    void Update()
    {
        if (hasMoved) return;

        // 現在位置との距離をチェック
        float positionDiff = Vector3.Distance(transform.position, initialPosition);

        // 回転のズレを角度でチェック
        float angleDiff = Quaternion.Angle(transform.rotation, initialRotation);

        if (positionDiff > positionThreshold || angleDiff > angleThreshold)
        {
            Debug.Log("if文の中");
            hasMoved = true;
            // SendMessage で通知（受け取る側が MoveDetected メソッドを持っている必要あり）
            score_sc.CountScore();
        }
    }

}
