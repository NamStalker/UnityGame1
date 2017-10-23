using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;

    private enum States
    {
        cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, corridor_0, stairs_0,
        stairs_1, stairs_2, courtyard, floor, corridor_1, corridor_2, corridor_3, closet_door, in_closet
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
            case States.cell: cell(); break;
            case States.mirror: mirror(); break;
            case States.sheets_0: sheets_0(); break;
            case States.lock_0: lock_0(); break;
            case States.cell_mirror: cell_mirror(); break;
            case States.sheets_1: sheets_1(); break;
            case States.lock_1: lock_1(); break;
            case States.corridor_0: corridor_0(); break;
            case States.stairs_0: stairs_0(); break;
            case States.stairs_1: stairs_1(); break;
            case States.stairs_2: stairs_2(); break;
            case States.courtyard: courtyard(); break;
            case States.floor: floor(); break;
            case States.corridor_1: corridor_1(); break;
            case States.corridor_2: corridor_2(); break;
            case States.corridor_3: corridor_3(); break;
            case States.closet_door: closet_door(); break;
            case States.in_closet: in_closet(); break;
        }
	}

    void cell()
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

    void mirror()
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

    void sheets_0()
    {
        text.text = "You walk up to the stained and rancid sheets, and wonder why they let you sleep in such deplorable conditions. \n\n" +
                    "Press R to return.";
        if (Input.GetKeyDown(KeyCode.R))
            myState = States.cell;
    }

    void lock_0()
    {
        text.text = "The door to your cell is locked, but you could manage to get to the lock with the aid of some tool. \n\n" +
            "Press R to return";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void cell_mirror()
    {
        text.text = "You now have a mirror, what could you acomplish with this? You are back in the center of your cell. \n\n" +
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

    void sheets_1()
    {
        text.text = "The stained sheets are starting to get to you, your quality of sleep is diminishing. \n\n" +
            "Press R to return.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
    }

    void lock_1()
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

    void corridor_0()
    {
        text.text = "The lock is dangling from your cell door, and you are now in the corridor where you see a janitor's closet and stairs leading to the courtyard. \n\n" +
            "Press F to Search the dirty floor, S to climb the stairs, or C to go to the closet.";
        if (Input.GetKeyDown(KeyCode.F))
        {
            myState = States.floor;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.stairs_0;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.closet_door;
        }
    }

    void corridor_1()
    {
        text.text = "You are now in the corridor with a new tool, the hairclip. Could this prove useful in unlocking the closet door? \n\n" +
            "Press P to attempt to pick the lock, S to climb the stairs.";
        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.in_closet;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.stairs_1;
        }
    }

    void corridor_2()
    {
        text.text = "Back in the corridor. having declined to dress-up as a janitor. \n\n" +
            "Press C to revisit the closet, S to climb the stairs.";
        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.in_closet;
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            myState = States.stairs_2;
        }
    }

    void corridor_3()
    {
        text.text = "You are standing back in the corridor now convingly dressed as a janitor. You start to really consider gunning for the exit. \n\n" +
            "Press S to go up the stairs, U to undress.";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.courtyard;
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            myState = States.in_closet;
        }
    }

    void stairs_0()
    {
        text.text = "You start to move up the stairs, but remember that it is not break time and the guards will surely "+
            "catch you immediately. You move back down to the bottom of the stairs. \n\n" +
            "Press R to return to the corridor.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_0;
        }
    }
    void stairs_1()
    {
        text.text = "The hairclip you found does not seem like it will be useful in fending off the guards, you decide not go further. \n\n" +
            "Press R to return to the corridor.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_1;
        }
    }
    void stairs_2()
    {
        text.text = "Though you have picked the closet door, you still can't sum up the courage to face the guards armed only with a hairclip. \n\n" +
            "Press R to return to the corridor.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_2;
        }
    }

    void courtyard()
    {
        text.text = "You go through the courtyard in your cleaner disguise. The guard sees you and tips his hat, "+
            "telling you to have a good day. You have exited the facility and have claimed your freedom! \n\n" +
            "Press P to play again.";
        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.cell;
        }
    }

    void floor()
    {
        text.text = "You look around the floor for anything useful, and, in the corner, is a hairclip. That could prove useful. \n\n" +
            "Press R to return, H to take the hairclip.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_0;
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            myState = States.corridor_1;
        }
    }

    void closet_door()
    {
        text.text = "The door is locked, though the simple lock on the door could be jimmied off. \n\n" +
            "Press R to return to the corridor.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_0;
        }
    }

    void in_closet()
    {
        text.text = "The lock has been picked by the hairclip. In the closet you see the janitor's uniform, surprisingly it is in your size! \n\n" +
            "Press D to dress-up, R to return to the corridor.";
        if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.corridor_3;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_2;
        }
    }
}
