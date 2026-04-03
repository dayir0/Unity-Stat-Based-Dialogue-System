using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public enum statype { None, Strength, Intelligence, Charisma}

[Serializable]
public class DialogueRequirement
{
    public statype requiredStat;
    public int minValue;
}

[Serializable]
public class DialogueOption
{
    [TextArea] public string optionText;
    public DialogueNode nextNode;
    public DialogueRequirement requirement;
}

[CreateAssetMenu(menuName = "Dialogue/New Node")]
public class DialogueNode : ScriptableObject
{
    [TextArea(3, 10)] public string dialogueText;
    public List<DialogueOption> options;
}
