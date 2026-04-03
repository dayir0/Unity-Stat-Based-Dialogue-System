using System.Data;
using UnityEngine;


public class PlayerStats : MonoBehaviour
{
    public int strength = 10;
    public int intelligence = 10;
    public int charisma = 10;

    public bool CheckRequirement(DialogueRequirement req)
    {
        if (req.requiredStat == statype.None) return true;
        int currentValue = 0;
        switch (req.requiredStat)
        {
            case statype.Strength: currentValue = strength; break;
            case statype.Intelligence: currentValue = intelligence; break;
            case statype.Charisma: currentValue = charisma; break;
        }

        return currentValue >= req.minValue;
    }
}
