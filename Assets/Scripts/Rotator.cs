using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(1, 10, 1) * Time.deltaTime);
    }
}
