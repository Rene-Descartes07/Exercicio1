using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SomeClass : MonoBehaviour
{
    void Start()
    {
        List<BadGuy> badguys = new List<BadGuy>();

        badguys.Add(new BadGuy("PaladinoAteu", 20));
        badguys.Add(new BadGuy("Bob", 1));
        badguys.Add(new BadGuy("Anna", 3));
        badguys.Add(new BadGuy("Gabriella", 5));
        badguys.Add(new BadGuy("Gengar", 7));
        badguys.Add(new BadGuy("BadEgg", 10));
        badguys.Add(new BadGuy("AqrueiroCego", 15));
        badguys.Add(new BadGuy("BardoUtil", 100));
        badguys.Add(new BadGuy("Charmander", 15));
        badguys.Add(new BadGuy("DoraAventureira", 0));

        badguys.Sort();

        foreach (BadGuy guy in badguys)
        {
            print(guy.name + " " + guy.level);
        }

        badguys.Clear();
    }
}
