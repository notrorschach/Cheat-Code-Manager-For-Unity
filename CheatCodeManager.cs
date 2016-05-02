using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class CheatCodeManager : MonoBehaviour 
{
	[Header("CHEAT CODES, LOL!")]
	
	//array of all cheatcodes you want in the game	
	[SerializeField] string[] targetCode;
	
	[SerializeField] List<string> inputCode = new List<string>();
	string currentCode;

	void Update()
	{
		if(Input.anyKeyDown)
		{

			//if it's one the directional keys
			//up = 0
			//down = 1
			//left = 2
			//right = 3
			if(Input.GetKeyDown(KeyCode.UpArrow))
			{
				inputCode.RemoveAt(0);
				inputCode.Add("0");
			}

			else if(Input.GetKeyDown(KeyCode.DownArrow))
			{
				inputCode.RemoveAt(0);
				inputCode.Add("1");
			
			}

			else if(Input.GetKeyDown(KeyCode.LeftArrow))
			{
				inputCode.RemoveAt(0);
				inputCode.Add("2");
			
			}

			else if(Input.GetKeyDown(KeyCode.RightArrow))
			{
				inputCode.RemoveAt(0);
				inputCode.Add("3");
			
			}

			//if it's an alphabet
			else if(Regex.IsMatch(Input.inputString, @"[a-zA-Z]"))
			{
			    inputCode.RemoveAt(0);
				inputCode.Add(Input.inputString);
			}

			//clear the current code string
			currentCode = "";

			//fill the current code string with all the previous inputs
			for(int i=0; i<inputCode.Count; i++)
			{
				currentCode+=inputCode[i];
			}

			//check of the current code matches with any of the cheat codes
			for(int i=0; i<targetCode.Length; i++)
			{
				if(currentCode.Contains(targetCode[i]))
				{
					ExecuteCode(targetCode[i]);
					for(int j=0; j<inputCode.Count; j++)
					{
						inputCode[j]=null;
					}
				}
			}
		}
	}

	void ExecuteCode(string code)
	{
		switch(code)
		{
			case "00112323ba":
			print("KONAMICODE!");
			//stuff that you want the game to do when the code "00112323ba" is entered
			break;

			//add a new case for each code
		}
	}
}
