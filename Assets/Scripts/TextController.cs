using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	#region Variables
	public Text text;

	private enum States {
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
	#endregion
	
	void Start () {
		text.text = "Welcome!";
	}
	
	void Update () {
		print (myState);
		if (myState == States.cell) {cell();}
		else if (myState == States.cellMirror) {cellMirror();}
		else if (myState == States.closetDoor) {closetDoor();}
		else if (myState == States.corridor1) {corridor1();}
		else if (myState == States.corridor2) {corridor2();}
		else if (myState == States.corridor3) {corridor3();}
		else if (myState == States.courtyard) {courtyard();}
		else if (myState == States.floor) {floor();}
		else if (myState == States.freedom) {freedom();}
		else if (myState == States.inCloset) {inCloset();}
		else if (myState == States.lock0) {lock0();}
		else if (myState == States.lock1) {lock1();}
		else if (myState == States.mirror) {mirror();}
		else if (myState == States.sheets0) {sheets0();}
		else if (myState == States.sheets1) {sheets1();}
		else if (myState == States.stairs0) {stairs0();}
		else if (myState == States.stairs1) {stairs2();}
		else if (myState == States.stairs2) {stairs1();}
		else {text.text = "Insert witty comment here";}
	}
	
	#region Prison Navigation
	void cell() {
		text.text = "Well, Stanley, this is it. You have spent ten years in this cell thinking about that cold November night. The night that changed your life. " +
					"It is time to escape and make things right. Ten years is a long time for a crime you didn't commit, even more when it resulted in her death. " +
					"Time to devise my plan, time to find him. As you look aroud the dark cell, you see the sheets on your bed, the mirror that you have watched " +
					"your face age in these years, and the lock that prevents you from the freedom you so desire.\n\n" +
					"Press S to view Sheets, Press M to view Mirror, press L to view Lock";
		if (Input.GetKeyDown (KeyCode.S)) { myState = States.sheets0; } 
		else if (Input.GetKeyDown(KeyCode.M)) { myState = States.mirror; } 
		else if (Input.GetKeyDown (KeyCode.L)) { myState = States.lock0; }
		//add in later
		//else { errorChecking(); };
	}
	
	void cellMirror() {
	}
	
	void closetDoor() {
	}
	
	void corridor1() {
	}
	
	void corridor2() {
	}
	
	void corridor3() {
	}
	
	void courtyard() {
	}
	
	void floor() {
	}
	
	void freedom() {
	}
	
	void inCloset() {
	}
	
	void lock0() {
	}
	
	void lock1() {
	}
	
	void mirror() {
	}
	
	void sheets0() {
	}
	
	void sheets1() {}
	
	void stairs0() {}
	
	void stairs1() {}
	
	void stairs2() {}

	#endregion
	
	//#region Error Checking
	//void errorChecking() {
		//text.text = "You have selected an invalid key, please press the Space bar to return to the previous screen or don't and keep seeing this message.";
		//if (Input.GetKeyDown (KeyCode.Space)) {
		//	Update (); //run the previous scene
		//} else {
		//errorChecking(); //enter that infinite loop of sarcasm
		//}
	//}
	//#endregion
	
}