using UnityEngine;

public class BallScript : MonoBehaviour
{
    public bool triggered;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        triggered = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < -10f)
        {
            Destroy(this.gameObject);
        }
    }
}
