using System;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public int slotNumber;
    public float modifier;
    public bool multiplier;
    public ScoreHandler scoreHandler;
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log($"{other.name} entered slot {slotNumber}");
        if (multiplier)
        {
            scoreHandler.score /= modifier;
        }
        else
        {
            scoreHandler.score += modifier;
        }
    }
}
