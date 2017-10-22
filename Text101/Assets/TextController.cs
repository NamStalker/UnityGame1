using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;

    private enum States
    {
        cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, corridor_0
    };
    private States myState;

    // Use this for initialization
    void Start () {
        myState = States.cell;
        text.text = "Press S to view Sheets, M to view Mirror, and L to view Lock.";
	}
	
	// Update is called once per frame
	void Update () {
        switch (myState)
        {
            case States.cell:
                state_cell();
                break;
            case States.mirror:
                state_mirror();
                break;
            case States.sheets_0:
                state_sheets_0();
                break;
            case States.lock_0:
                state_lock_0();
                break;
            case States.cell_mirror:
                state_cell_mirror();
                break;
            case States.sheets_1:
                state_sheets_1();
                break;
            case States.lock_1:
                state_lock_1();
                break;
            case States.corridor_0:
                state_corridor_0();
                break;
        }
	}

    void state_cell()
    {
        text.text = "You are in the middle of a prison cell, how will you get out of this one? \n\n" +
            "Press S to view Sheets, M to view Mirror, and L to view Lock.";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_0;
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.mirror;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_0;
        }
    }

    void state_mirror()
    {
        text.text = "There is a mirror on the wall, slender and long, it could prove useful at some point. \n\n" +
            "Press R to return, T to take the mirror.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.cell_mirror;
        }
    }

    void state_sheets_0()
    {
        text.text = "You walk up to the stained and rancid sheets, and wonder why they let you sleep in such deplorable conditions. \n\n" +
                    "Press R to return.";
        if (Input.GetKeyDown(KeyCode.R))
            myState = States.cell;
    }

    void state_lock_0()
    {
        text.text = "The door to your cell is locked, but you could manage to get to the lock with the aid of some tool. \n\n" +
            "Press R to return";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void state_cell_mirror()
    {
        text.text = "You no have a mirror, what could you acomplish with this? You are back in the center of your cell. \n\n" +
            "Press S to view the Sheets, L to view the lock.";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_1;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_1;
        }
    }

    void state_sheets_1()
    {
        text.text = "The stained sheets are starting to get to you, your quality of sleep is diminishing. \n\n" +
            "Press R to return.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
    }

    void state_lock_1()
    {
        text.text = "The lock is just out of reach, but you might be able to knock it off with the mirror. \n\n" +
            "Press R to return, O to attempt to open the lock.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            myState = States.corridor_0;
        }
    }

    void state_corridor_0()
    {
        text.text = "It worked! the lock is off, you open the door and you are free from your cell! \n\n" +
            "Press Return to play again, Q to quit.";
        if (Input.GetKeyDown(KeyCode.Return))
        {
            myState = States.cell;
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }
}
