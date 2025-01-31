using Unity.VisualScripting;
using UnityEngine;

public class PegScript : MonoBehaviour
{
    public ScoreHandler scoreHandler;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.GetComponent<BallScript>().triggered)
        {
            scoreHandler.scoreMult += 2;
            collision.gameObject.GetComponent<BallScript>().triggered = true;
            // this.GameObject().GetComponent<MeshRenderer>().material.color = Color.gray;   
        }
    }
}
