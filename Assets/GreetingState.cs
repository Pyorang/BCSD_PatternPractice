using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GreetingState : secondClass
{
    private static GreetingState greet;
    private TextMeshProUGUI ZeusText;

    public static GreetingState Greet
    {
        get
        {
            if(greet == null)
            {
                greet = new GreetingState();
            }
            return greet;
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
        ZeusText.text = "I'm Zeus";
    }
}
