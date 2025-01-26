using UnityEngine;

public class Sample : MonoBehaviour
{
    public float yawDegreesPerSecond = 25f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotate a little bit
        Transform myTransform = GetComponent<Transform>();
        myTransform.Rotate(0f, yawDegreesPerSecond * Time.deltaTime, 0f);
    }
}
