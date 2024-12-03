using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    private void Awake()
    {
        base.Cast();
    }

    private void Start()
    {
        Cast();
        Cast("Orc");
        Cast("Orc", 15);
        
    }

    public override void Cast()
    {
        Debug.Log($"Casting a {name}!!! Destroy them all!!!");
    }

    

    

}
