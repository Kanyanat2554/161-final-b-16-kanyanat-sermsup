using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpelll : Spell
{
    private void Start()
    {
        Cast();
        Cast("Dark Elf");
        Cast("Dark Elf", 40);
    }

    public override void Cast()
    {
        Debug.Log($"Casting a {name}!!! Blow the enemy!!!");
    }
}
