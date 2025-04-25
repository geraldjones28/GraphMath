using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField] 
    Transform pointPrefab;

    void Awake()
    {
        Transform point;
        int i = 0;
        while (i < 10)
        {
            point = Instantiate(pointPrefab);
            point.localPosition = Vector3.right * i;
            i++;
        }
    }
}
