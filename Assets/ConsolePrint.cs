using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour {

	// Use this for initialization
	void Start () {
        float location = 5.0f;
        float homeLocation = 2.1f;
        print("Welcome to Finding Home.");
        print("A game where you need to find your way home.");
        print("You are " + (location - homeLocation) + " meters from home.");

        if (location > homeLocation)
        {
            print("Go back to find home!");
        }
        else if (homeLocation < location)
        {
            print("Go forward to get home!");
        }
        else
        {
            print("You're home!");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
