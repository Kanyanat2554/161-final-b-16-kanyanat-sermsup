using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dog : Animal
{
    private float dailyFoodConsumption = 4.5f;
    private int activityLevel = 3;

    private void Start()
    {
        Init("Smart Dog");
        DisplayName();
        MakeSound();
        CalculateFoodRequirement();
    }

    public override void MakeSound()
    {
        base.MakeSound();
        Debug.Log($"{animalName} barks: Hong Hong Hong!");
    }

    public override float CalculateFoodRequirement()
    {

        Debug.Log($"{animalName} eats {dailyFoodConsumption} kg of food daily with activity level {activityLevel}");

        float weeklyFoodRequireMent = (dailyFoodConsumption) * (activityLevel) * 7;
        Debug.Log($"{animalName}'s weekly food requirement: {weeklyFoodRequireMent}");

        return weeklyFoodRequireMent;
        
    }
}
