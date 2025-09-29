using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject ball;
    // Start is call
    // ed once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            // Zはカメラからの距離を指定（例：10ユニット先）
            mousePosition.z = 10f;

            // スクリーン座標 → ワールド座標に変換
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Vector3 ballPosition = new Vector3(77f, 6.5f, worldPosition.z);

            Instantiate(
                ball,
                ballPosition,
                Quaternion.identity
            );
        }
    }
}
