using UnityEngine;

public class VectorStudy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Vector3 a = new Vector3(1, 0, 0);
        // Vector3 b = new Vector3(2, 0, 0);

        // Vector3 c = a + b;

        // Debug.Log("Vector" + c);

        // Vector3 a = new Vector3(1, 1, 0);
        // Vector3 b = new Vector3(2, 0, 0);

        // Vector3 c = a + b;

        // Debug.Log("Vector" + c);

        // Debug.Log("길이 : " + c.magnitude);

        // Vector3 a = new Vector3(3, 0, 0);

        // 정규화 normalize 
        // 벡터의 크기를 1로 만들고 방향만 유지
        // Vector3 normalizedVector = a.normalized;

        // Debug.Log("1의길이 방향만 설정하는 정규화 : " + normalizedVector);
    }

    public float speed = 5.0f; //이동속도

        
    void Update()
    {

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //transform.position += move * speed * Time.deltaTime;
        transform.Translate(move * speed * Time.deltaTime);
    }
}
