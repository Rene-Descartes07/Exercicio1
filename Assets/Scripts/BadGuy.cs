using UnityEngine;
using System.Collections;
using System; 

public class BadGuy : IComparable<BadGuy>
{
    [Header("Dados do Jogador")]
    [HideInInspector] public string name;
    [Range (0,100)] public int level;
    [SerializeField] string story;

    public BadGuy(string newName, int newlevel)
    {
        name = newName;
        level = newlevel;
    }

    public int CompareTo(BadGuy other)
    {
        if (other == null)
        {
            return 1;
        }

        return level - other.level;
    }
}
