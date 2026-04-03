using UnityEngine;

public class NPCController : MonoBehaviour
{
    // Bu NPC ile konuþunca hangi diyalog açýlacak?
    public DialogueNode dialogueToStart;

    // Oyuncu bu fonksiyona dýþarýdan eriþecek
    public void Interact()
    {
        if (dialogueToStart != null)
        {
            // Manager'ý bul ve diyaloðu baþlat
            FindObjectOfType<DialogueManager>().StartDialogue(dialogueToStart);
        }
    }
}