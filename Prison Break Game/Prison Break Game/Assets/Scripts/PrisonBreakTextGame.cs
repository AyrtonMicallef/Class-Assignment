using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrisonBreakTextGame : MonoBehaviour
{

    public Text myText;

    private enum States
    {
        cell, sheets_0, mirror, lock_0, cell_mirror, sheets_1, lock_1, freedom, corridor_0, stairs_0, floor, closet_door, stairs_1, corridor_1, in_closet, stairs_2, corridor_2, courtyard, corridor_3
    };

    private States myState;


    // Use this for initialization
    void Start()
    {
        myText.text = "Fl-ahhar l-AC qed jahdem!!";

        myState = States.cell;

    }
    void Cell()
    {
        myText.text = "You are in a prison cell, and you want to escape." +
                       "There are " + "some dirty sheets on the bed, a mirror on the wall, " +
                       "and the door " + " is locked from the outside.\n" +
                       "Press S to view Sheets, M to view Mirror and L to view Lock";
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

    void Sheets_0()
    {
        myText.text = "You can't believe you sleep in these things. Surely it's " +
            "time somebody changed them. The pleasures of prison life " +
            "I guess!\n\n" + "Press R to Return to roaming your cell";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void Mirror()
    {
        myText.text = "You are still in your cell, and you STILL want to escape! There are " +
                        "some dirty sheets on the bed, a mirror , " +
                        "and that pesky door is still there, and firmly locked!\n\n" +
                        "Press R to go back Cell or T to Take the Mirror";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.cell_mirror;
        }
    }
    void Lock_0()
    {
        myText.text = "This is one of those button locks. You have no idea what the " +
                        "combination is. You wish you could somehow see where the dirty " +
                        "fingerprints were, maybe that would help.\n\n" +
                        "Press R to Return to roaming your cell";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }
    void Cell_mirror()
    {
        myText.text = "You are still in your cell, and you STILL want to escape! There are " +
                         "some dirty sheets on the bed, a mark where the mirror was, " +
                         "and that pesky door is still there, and firmly locked!\n\n" +
                         "Press S to view Sheets, or L to view Lock";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_1;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_1;
        }
    }
    void Sheets_1()
    {
        myText.text = "Holding a mirror in your hand doesn't make the sheets look " +
                        "“any better.\n\n" +
                        "Press R to Return to roaming your cell";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
    }
    void Lock_1()
    {
        myText.text = "You carefully put the mirror through the bars, and turn it round " +
                        "so you can see the lock. You can just make out fingerprints around " +
                        "the buttons. You press the dirty buttons, and hear a click.\n\n" +
                        "Press O to Open, or R to Return to your cell";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            myState = States.freedom;
        }
    }
    void Freedom()
    {
        myText.text = "YOU ARE FREE!!";

        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.cell;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.corridor_0;
        }

    }
    void Corridor_0()
    {
        myText.text = "CORRIDOR";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.stairs_0;
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            myState = States.floor;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.closet_door;
        }
    }
    void Stairs_0()
    {
        myText.text = "You start walking up the stairs towards the outside light. " +
            "You realise it's not break time, and you'll be caught immediately. " +
            "You slither back down the stairs and reconsider.\n\n";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_0;
        }
    }
    void Floor()
    {
        myText.text = "Rummaging around on the dirty floor, you find a hairclip.\n\n";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_0;
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            myState = States.corridor_1;
        }
    }
    void Closet_door()
    {
        myText.text = "You are looking at a closet door, unfortunately it's locked. " +
                      "Maybe you could find something around to help enourage it open?\n\n";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_0;
        }
    }
    void Corridor_1()
    {
        myText.text = "Still in the corridor. Floor still dirty. Hairclip in hand. " +
                      "Now what? You wonder if that lock on the closet would succumb to " +
                      "to some lock-picking?\n\n";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.stairs_1;
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.in_closet;
        }
    }
    void Stairs_1()
    {
        myText.text = "Unfortunately wielding a puny hairclip hasn't given you the " +
                      "confidence to walk out into a courtyard surrounded by armed guards!\n\n";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_2;
        }
    }
    void In_closet()
    {
        myText.text = "Inside the closet you see a cleaner's uniform that looks about your size! " +
                      "Seems like your day is looking-up.\n\n";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_2;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.corridor_3;
        }
    }
    void Corridor_2()
    {
        myText.text = "CORRIDOR 2";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.stairs_2;
        }
    }
    void Stairs_2()
    {
        myText.text = "STAIRS_2";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_2;
        }
    }
    void Corridor_3()
    {
        myText.text = "You're standing back in the corridor, now convincingly dressed as a cleaner. " +
                      "You strongly consider the run for freedom.\n\n";
        if (Input.GetKeyDown(KeyCode.U))
        {
            myState = States.in_closet;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.courtyard;
        }
    }
    void Courtyard()
    {
        myText.text = "You walk through the courtyard dressed as a cleaner. " +
                    "The guard tips his hat at you as you waltz past, claiming " +
                    "your freedom. You heart races as you walk into the sunset.\n\n" +
                    "Press P to Play again.";
        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.corridor_0;
        }
    }
    // Update is called once per frame
    void Update()
    {

        print(myState);
        if (myState == States.cell)
        {
            Cell();
        }
        else if (myState == States.sheets_0)
        {
            Sheets_0();
        }
        else if (myState == States.mirror)
        {
            Mirror();
        }
        else if (myState == States.lock_0)
        {
            Lock_0();
        }
        else if (myState == States.cell_mirror)
        {
            Cell_mirror();
        }
        else if (myState == States.sheets_1)
        {
            Sheets_1();
        }
        else if (myState == States.lock_1)
        {
            Lock_1();
        }
        else if (myState == States.freedom)
        {
            Freedom();
        }
        else if (myState == States.corridor_0)
        {
            Corridor_0();
        }
        else if (myState == States.stairs_0)
        {
            Stairs_0();
        }
        else if (myState == States.floor)
        {
            Floor();
        }
        else if (myState == States.closet_door)
        {
            Closet_door();
        }
        else if (myState == States.corridor_1)
        {
            Corridor_1();
        }
        else if (myState == States.stairs_1)
        {
            Stairs_1();
        }
        else if (myState == States.in_closet)
        {
            In_closet();
        }
        else if (myState == States.corridor_2)
        {
            Corridor_2();
        }
        else if (myState == States.stairs_2)
        {
            Stairs_2();
        }
        else if (myState == States.corridor_3)
        {
            Corridor_3();
        }
        else if (myState == States.courtyard)
        {
            Courtyard();
        }

    }
}
