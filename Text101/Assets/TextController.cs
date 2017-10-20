using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;

    private enum States
    {
        cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom
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
            case States.freedom:
                state_freedom();
                break;
        }
	}

    void state_cell()
    {
        text.text = "Press S to view Sheets, M to view Mirror, and L to view Lock.";
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

    }

    void state_cell_mirror()
    {

    }

    void state_sheets_1()
    {

    }

    void state_lock_1()
    {

    }

    void state_freedom()
    {

    }
}
