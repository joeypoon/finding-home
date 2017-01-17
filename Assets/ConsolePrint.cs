using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour {

    Vector2 location;
    Vector2 homeLocation;
    Vector2 pathToHome;

	// Use this for initialization
	void Start () {
        location = new Vector2(3.0f, 2.0f);
        homeLocation = new Vector2(0, 0);
        pathToHome = homeLocation - location;
        print("Welcome to Finding Home.");
        print("A game where you need to find your way home.");
        print("Path to home" + location);
        print("Distance to home: " + pathToHome.magnitude);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            location = new Vector2(location.x - 1, location.y);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            location = new Vector2(location.x + 1, location.y);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            location = new Vector2(location.x, location.y + 1);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            location = new Vector2(location.x, location.y - 1);
        }
        pathToHome = homeLocation - location;
        print("Path to home" + location);
        print("Distance to home: " + pathToHome.magnitude);
    }
}
