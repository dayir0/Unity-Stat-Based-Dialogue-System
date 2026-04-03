using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI npcText;
    public Transform buttonsParent;
    public Button buttonPrefab;
    public PlayerStats player;
    public GameObject dialoguePanel;
    public DialogueNode testStartNode;

    void Start()
    {
        if(testStartNode != null)
        {
            dialoguePanel.SetActive(false);
        }
    }

    public void StartDialogue(DialogueNode node)
    {
        if (dialoguePanel != null)
        {
            dialoguePanel.SetActive(true);
        }
        
        npcText.text = node.dialogueText;

        foreach (Transform child in buttonsParent) Destroy(child.gameObject);

        foreach (var option in node.options)
        {
            Button btn = Instantiate(buttonPrefab, buttonsParent);
            TextMeshProUGUI txt = btn.GetComponentInChildren<TextMeshProUGUI>();

            bool isMet = player.CheckRequirement(option.requirement);

            if (isMet)
            {
                txt.text = option.optionText;
                txt.color = Color.black;
                btn.onClick.AddListener(() =>{
                    if (option.nextNode != null)
                    {
                        StartDialogue(option.nextNode);
                    }
                    else
                    {
                        EndDialogue();
                    }
                });
            }
            else
            {
                txt.text = $"[GEREKEN: {option.requirement.requiredStat} {option.requirement.minValue}] {option.optionText}";
                txt.color = Color.red;
                btn.interactable = false; 
            }
        }
    }
    public void EndDialogue()
    {
        if (dialoguePanel != null)
        {
            dialoguePanel.SetActive(false);
        }
    }
}
