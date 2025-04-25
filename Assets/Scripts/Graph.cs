using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField] 
    Transform pointPrefab;

    void Awake()
    {
        Transform point;
        var position = Vector3.zero; //Making position start as a zero 3d vector
        var scale = Vector3.one / 5f; //Fixing scale to a 1 3D vector / 5f for proper cube size
        
        for (int i = 0; i < 10; i++)
        {
            point = Instantiate(pointPrefab);
            position.x = (i + 0.5f) / 5f - 1f; //Making the x component in position vector this location on scene
            position.y = position.x * position.x; //Making y component a function, where you plug in x to get it's y coord
            point.localPosition = position; //Setting cube position to the aforementioned
            point.localScale = scale; //Setting scale to the initialized scale I did before the for loop
        }
    }
}
