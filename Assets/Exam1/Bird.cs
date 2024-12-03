using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Bird : Animal
{
    private float dailyFoodConsumption = 1.5f;
    private float weight= 0.7f;

    private void Start()
    {
        Init("Little Bird");
        DisplayName();
        MakeSound();
        CalculateFoodRequirement();
    }

    public override void MakeSound()
    {
        base.MakeSound();
        Debug.Log($"{animalName} chirps: Jib Jib!");
    }

    public override float CalculateFoodRequirement()
    {
        Debug.Log($"{animalName} eats {dailyFoodConsumption} kg of food daily and weight {weight} kg.");

        float weeklyFoodRequireMent = (dailyFoodConsumption) * weight * 7;
        Debug.Log($"{animalName}'s weekly food requirement: {weeklyFoodRequireMent}");

        return weeklyFoodRequireMent;
    }
    
}
