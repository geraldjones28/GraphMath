using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField] 
    Transform pointPrefab;
    
    [SerializeField, Range(10, 100)]
    int resolution = 10;

    void Awake()
    {
        Transform point;
        float step = 2f / resolution;
        var position = Vector3.zero; //Making position start as a zero 3d vector
        var scale = Vector3.one * step; //Fixing scale to a uniform 1 3D Vector to scale with resolution size
        
        for (int i = 0; i < resolution; i++)
        {
            point = Instantiate(pointPrefab);
            position.x = (i + 0.5f) * step - 1f; //Making the x component in position vector this location on scene
            position.y = position.x * position.x; //Making y component a function, where you plug in x to get it's y coord
            point.localPosition = position; //Setting cube position to the aforementioned
            point.localScale = scale; //Setting scale to the initialized scale I did before the for loop
        }
        
    }
}
