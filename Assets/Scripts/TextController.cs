using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class TextController : MonoBehaviour
{

    #region Variables
    private enum States
    {
        cell, //start point
        cellMirror, //needed to escape cell	
        closetDoor,
        corridor0,
        corridor1,
        corridor2,
        corridor3,
        courtyard,
        floor,
        freedom, //escape the cell
        inCloset,
        lock0,
        lock1,
        mirror,
        sheets0,
        sheets1,
        stairs0,
        stairs1,
        stairs2
    };

    private States myState; //set the location of where you are in the maze

    public Text text;

    #endregion

    void Start()
    {
        myState = States.cell;
    }

    void Update()
    {
        print(myState);
        switch (myState)
        {
            default:
                errorChecking();
                break;
            case States.cell:
                Cell();
                break;
            case States.cellMirror:
                CellMirror();
                break;
            case States.closetDoor:
                ClosetDoor();
                break;
            case States.corridor1:
                Corridor1();
                break;
            case States.corridor2:
                Corridor2();
                break;
            case States.corridor3:
                Corridor3();
                break;
            case States.courtyard:
                Courtyard();
                break;
            case States.floor:
                Floor();
                break;
            case States.freedom:
                Freedom();
                break;
            case States.inCloset:
                InCloset();
                break;
            case States.lock0:
                Lock0();
                break;
            case States.lock1:
                Lock1();
                break;
            case States.mirror:
                Mirror();
                break;
            case States.sheets0:
                Sheets0();
                break;
            case States.sheets1:
                Sheets1();
                break;
            case States.stairs0:
                Stairs0();
                break;
            case States.stairs1:
                Stairs2();
                break;
            case States.stairs2:
                Stairs1();
                break;
        }
    }

    #region Prison Navigation

        #region Escape the Cell

		    void Cell()
		    {
		        text.text = "Well, Stanley, this is it. You have spent ten years in this cell thinking about that cold November night. The night that changed your life. " +
		                    "It is time to escape and make things right. Ten years is a long time for a crime you didn't commit, even more when it resulted in her death. " +
		                    "Time to devise my plan, time to find him. As you look aroud the dark cell, you see the sheets on your bed, the mirror that you have watched " +
		                    "your face age in these years, and the lock that prevents you from the freedom you so desire.\n\n" +
		                    "Press S to view Sheets, Press M to view Mirror, press L to view Lock";
		        if (Input.GetKeyDown(KeyCode.S)) { myState = States.sheets0; }
		        else if (Input.GetKeyDown(KeyCode.M)) { myState = States.mirror; }
		        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.lock0; }
                //else if (!Input.GetKeyDown(KeyCode.S) && !Input.GetKeyDown(KeyCode.M) && !Input.GetKeyDown(KeyCode.L) && Input.anyKeyDown) { errorChecking(); };
		    }

		    void CellMirror()
		    {
		        text.text = "With the piece of mirror in hand, it is time to devise your next strategy. The thought, \"Where do I go from here?\", crosses your racing mind.\n\n" +
		                    "Press S to view Sheets, Press L to view the Lock.";
		        if (Input.GetKeyDown(KeyCode.S)) { myState = States.sheets1; }
		        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.lock1; }
		    }

		    void Freedom()
		    {
		        text.text = "With the lock picked, it is time to open the door. You enter the dark corridor with much trepidation.\n\n" +
		            "Press C to open the door and get your freedom.";
		        if (Input.GetKeyDown(KeyCode.C)) { myState = States.corridor1; }
		    }


		    void Lock0()
		    {
		        text.text = "You walk over to the cell door. Cold steel, used to keep locked up what society deems undesireable. Beyond that is the dark hallway where nothing is stiring tonight. " +
		                    "You look at the lock and tell yourself, \"Stanley, think. There has to be a way to open this door!\" You stare with a blank stare while you try to generate any idea to get this door open. " +
		                    "But you realize, it is not here.\n\n" +
		                    "Press R to return to the the cell.";
		        if (Input.GetKeyDown(KeyCode.R)) { myState = States.cell; }
		    }

		    void Lock1()
		    {
		        text.text = "You walk back over to the cell door, this time with the piece of glass in hand. When you arrive at the door, you realize that the piece of glass will fit in the lock. " +
		                    "You look to be sure there are no guards patrolling your hall and you then you take your hand through the bars. You fiddle with the glass in the keyhole and all of a sudden you hear it. \"Click.\" " +
		                    "You suddenly fill full of adrenline for the next step of your escape.\n\n" +
		                    "Press the space bar to continue.";
		        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.freedom; }
		    }

		    void Mirror()
		    {
		        text.text = "You walk over to that mirror. As you stare at your aged face in the mirror, you notice a small shard has fallen out.\n\n" +
		            "Press T to take the shard or press R to return to the cell.";
		        if (Input.GetKeyDown(KeyCode.T)) { myState = States.cellMirror; }
		        else if (Input.GetKeyDown(KeyCode.R)) { myState = States.cell; }
		    }

		    void Sheets0()
		    {
		        text.text = "You walk over and look at the sheets on your tiny prison bed. You can see the sweat stains that have accumluated over the years. So many restless dreams, but nothing that will help you to avenge her.\n\n" +
		                    "Press R to return to your cell";
		        if (Input.GetKeyDown(KeyCode.R)) { myState = States.cell; }
		    }

		    void Sheets1()
		    {
		        text.text = "You walk back over to your bed. It is still the same old sheets. There isn't much you can do with these, so you decided to walk back to the cell.\n\n" +
		            "Press R to return to the cell.";
		        if (Input.GetKeyDown(KeyCode.R)) { myState = States.cellMirror; }
		    }
        #endregion

        #region Final Escape
		    void ClosetDoor(){
        
		    }

            void Corridor1() {
		    }

		    void Corridor2() {
		    }

		    void Corridor3() {
		    }

		    void Courtyard() {
		    }

		    void Floor() {
        
		    }

		    void InCloset() {
		    }

		    void Stairs0() { 
            }

		    void Stairs1() { 
            }

		    void Stairs2() { 
            }

        #endregion

    #endregion

    #region Error Checking 
    void errorChecking() {
        text.text = "You have selected an invalid key, please press the Space bar to return to the previous screen or don't and keep seeing this message.";
        if (Input.GetKeyDown(KeyCode.Space)) { Update(); } //run the previous scene
		else { errorChecking(); } //enter that infinite loop of sarcasm
    }
    #endregion

}