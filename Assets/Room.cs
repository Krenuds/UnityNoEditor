using UnityEngine;
using System.Collections;

public class Room {
	//Based on center
	private Vector3 position; 

	private float width;
	private float length;
	private float hight;

	public Room (float w, float l, float h, Vector3 p){
		width = w;
		length = l;
		hight = h;
		position = p;

	}

	public void DisplayRoomInfo () {
		Debug.Log ("width:" + width + "/n" + 
		           "hight:" + hight + "/n" + 
		           "length:" + length + "/n" + 
		           "position:" + position );
		         
	}

}


