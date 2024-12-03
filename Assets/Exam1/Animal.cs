using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;

    public void Init(string newAnimalName = "Animal")
    {
        animalName = newAnimalName;
    }

    public abstract float CalculateFoodRequirement();

    public virtual void MakeSound()
    {
        Debug.Log("Two pets will make a sound.");
    }

    public void DisplayName()
    {
        Debug.Log("This is a " + animalName);
    }
}
