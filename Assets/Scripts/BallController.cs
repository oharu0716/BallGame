using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    public GameObject[] balls;
    public float baseWidth;
    int count = 0;
    // Start is call
    // ed once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && count < 3)
        {
            Vector3 mousePosition = Input.mousePosition;
            // Zはカメラからの距離を指定（例：10ユニット先）
            mousePosition.z = 10f;

            // スクリーン座標 → ワールド座標に変換
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Vector3 ballPosition = new Vector3(77f, 6.5f, worldPosition.z);

            int r = Random.Range(0, 3);

            Instantiate(
                balls[r],
                GetInstantiatePosition(),
                Quaternion.identity
            );

            count++;
        }

        if (count == 3)
        {
            StartCoroutine(DoAfterDelay());
        }
    }

    Vector3 GetInstantiatePosition()
    {
        float z = baseWidth * (Input.mousePosition.x / Screen.width) - (baseWidth / 2);
        Debug.Log(z);
        return new Vector3(77f, 6.5f, z);
    }

    System.Collections.IEnumerator DoAfterDelay()
    {
        yield return new WaitForSeconds(5f); // 10秒待つ
        // 現在アクティブなシーンの名前を取得
            string currentSceneName = SceneManager.GetActiveScene().name;

            // そのシーンを再読み込み
            SceneManager.LoadScene(currentSceneName);
    }
}
