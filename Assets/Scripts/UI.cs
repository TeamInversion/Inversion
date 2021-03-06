﻿using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {
//Displays a grid of items to use
	public static int selGridInt = 0;
	public string[] selStrings = new string[] {"Empty", "Windbreaker", "Umbrella", "Sunglasses", "Diet Soda",  "Hard Hat", "Heels", "Spacesuit"};
	private int gridXPos = Screen.width/2 - 350; 
	private int gridYPos = Screen.height/8 -50; 
	private int gridXSize = 800;
	private int gridYSize = 30;
	void Start(){
		//anim = GetComponent<Animator>();
	}

	
	void OnGUI () {
		//Item equiped to recieved, checked for GUI changes, and is set again.
		selGridInt = (int) Player.itemEquiped;
		selGridInt = GUI.SelectionGrid(new Rect(gridXPos, gridYPos, gridXSize, gridYSize), selGridInt, selStrings, 09);
		if(selGridInt != (int)Player.itemEquiped){
			Debug.Log("NEW!");
			Player.itemEquiped = (Items) selGridInt;
		}
		Player.itemEquiped = (Items) selGridInt;

		}
}
 