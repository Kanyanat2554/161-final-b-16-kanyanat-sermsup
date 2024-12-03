using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WindSpell : Spell
{
    private void Start()
    {
        Cast();
        Cast("Demon Bat");
        Cast("Demon Bat", 20);
        Cast(6);
    }

    public override void Cast()
    {
        Debug.Log($"Casting a {name}!!! Freeze all of them!!!");
    }

    public void Cast(int timeAttackResult)
    {
        Debug.Log($"The result of {name} will show for {timeAttackResult} second");
    }
}
