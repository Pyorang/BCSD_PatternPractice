using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private ZeusFeeling feel;
    
    public  Boss(ZeusFeeling feel)
    {
        this.feel = feel;
    }

    public void setFeeling(ZeusFeeling feel)
    {
        this .feel = feel;
    }

    public void actAction()
    {
        feel.pushAction();
    }

}