using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public virtual void Cast()
    {
        Debug.Log("Spell-Casting Game Started!!!");
        Debug.Log("Casting a normal spell!");
    }

    public void Cast(string target)
    {
        Debug.Log($"Casting a spell on target: {target}");
    }

    public void Cast(string target, int castLevel)
    {
        Debug.Log($"Casting a spell on target: {target} with power level: {castLevel}");
    }

   
}
