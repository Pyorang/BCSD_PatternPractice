using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss1 : MonoBehaviour
{
    public secondClass feel;
    public AngryState angry;
    public GreetingState greeting;
    public FlyState fly;

    private void Awake()
    {
        feel= GetComponent<secondClass>();
        angry = GetComponent<AngryState>();
        greeting = GetComponent<GreetingState>();
        fly = GetComponent<FlyState>();
    }

    public boss1(secondClass Feel)
    {
        feel = Feel;
    }

    public void actingGreet()
    {
        feel = greeting;
        greeting.pushAction();
    }

    public void actingAngry()
    {
        feel = angry;
        angry.pushAction();
    }

    public void actingFly()
    {
        feel = fly;
        fly.pushAction();
    }
}
