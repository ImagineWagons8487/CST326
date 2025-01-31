using System;
using TMPro;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public int slotNumber;
    public float modifier;
    public bool multiplier;
    public ScoreHandler scoreHandler;
    public TextMeshPro modifierText;

    void Start()
    {
        setModifierText();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log($"{other.name} entered slot {slotNumber}");
        if (multiplier)
        {
            scoreHandler.scoreMult += modifier;
        }
        else
        {
            scoreHandler.scoreFlat += modifier;
        }
        Destroy(other.gameObject);
        modifier *= 0.9f;
        setModifierText();
    }

    private void setModifierText()
    {
        if (multiplier)
        {
            modifierText.text = "x" + modifier.ToString();
        }
        else
        {
            modifierText.text = "+" + modifier.ToString();
        }
    }
}
