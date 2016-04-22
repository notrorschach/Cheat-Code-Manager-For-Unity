using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CheatCodeManager : MonoBehaviour 
{
	[Header("CHEAT CODES, LOL!")]
	
	//array of all cheatcodes you want in the game	
	public string[] targetCode;
	
	public List<string> inputCode = new List<string>();
	string currentCode;
	
	void Update()
	{
		if(Input.anyKeyDown)
		{
			inputCode.RemoveAt(0);
			inputCode.Add(Input.inputString);
			currentCode = "";
			for(int i=0; i<inputCode.Count; i++)
			{
				currentCode+=inputCode[i];
			}
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
			case "nyancat":
			//stuff that you want the game to do when the code "nyancat" is entered
			break;

			//add a new case for each code
		}
	}
}
