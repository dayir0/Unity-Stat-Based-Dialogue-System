using UnityEngine;

public class DialogueStatConnector : MonoBehaviour
{
    // Kendi oyununuzdaki scriptin ismini yazýn
    [SerializeField] private PlayerStats myPlayer;

    public bool CheckRequirement(DialogueRequirement req)
    {
        if (req.requiredStat == statype.None) return true;

        int currentValue = 0;
        switch (req.requiredStat)
        {
            case statype.Strength: currentValue = myPlayer.strength; break; // Kendi deðiþkeniniz
            case statype.Intelligence: currentValue = myPlayer.intelligence; break;
        }
        return currentValue >= req.minValue;
    }
}