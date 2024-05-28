using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Entity_Dialogue : ScriptableObject
{	
	public List<Sheet> sheets = new List<Sheet> ();

	[System.SerializableAttribute]
	public class Sheet
	{
		public string name = string.Empty;
		public List<Param> list = new List<Param>();
	}

	[System.SerializableAttribute]
	public class Param
	{
		
		public int index;
		public int npc;
		public int gamestate;
		public string npcname;
		public string Dialog;
		public int changeState;
		public int choice1;
		public int choice2;
		public string choice1text;
		public string choice2text;
		public int leftface;
		public int rightface;
		public int background;
		public int midimage;
	}
}

