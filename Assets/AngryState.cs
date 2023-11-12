using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AngryState : secondClass
{
    private static AngryState angry;
    private TextMeshProUGUI ZeusText;

    public static AngryState Angry
    {
        get
        {
            if (angry == null)
            {
                angry = new AngryState();
            }
            return angry;
        }
    }

    public TextMeshProUGUI zeusText
    {
        get { return ZeusText; }
        set { ZeusText = value; }
    }

    private void Awake()
    {
        ZeusText = GetComponent<TextMeshProUGUI>();
    }

    public override void pushAction()
    {
        ZeusText.text = "I'm angry!!";
    }
}
