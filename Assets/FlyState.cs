using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FlyState : secondClass
{
    private static FlyState fly;
    private TextMeshProUGUI ZeusText;

    public static FlyState Fly
    {
        get
        {
            if (fly == null)
            {
                fly = new FlyState();
            }
            return fly;
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
        ZeusText.text = "I'm fling~~!!";
    }

}
