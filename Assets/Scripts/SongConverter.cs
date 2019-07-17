using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using NotelineClass;

public class SongConverter : MonoBehaviour {



	public string title;
	public int bpm;
	public List<Notes> song1data;
	public int numberOfNotes;


	public void ConvertFromFile(TextAsset ta)
	{
		song1data = new List<Notes> ();
		// puts it in a array then organizes it
		string[] textArray = ta.text.Split ("\n" [0]);
		for (int i = 0; i < textArray.Length; i++)
		{
			Debug.Log (textArray [i]);
			if (textArray [i].Contains ("BPMS:")) {
				textArray[i] = textArray [i].Remove (0, 5);
				textArray[i] = textArray [i].Remove (3, 7);
				bpm = Int32.Parse (textArray [i]);
			}
			if (textArray [i].Contains ("TITLE:")) {
				textArray [i] = textArray [i].Remove (0, 6);
				title = textArray [i];
			}
			if (textArray [i].Contains("NOTES:")) 
			{
				Debug.Log ("starting next loop");
				for (int g = i+1; g < textArray.Length; g++) {
					if (textArray [g].Contains (",")) {
						//do nothing
					} else {
						string line = textArray [g];
						Notes temp = new Notes ();
						temp.left = 0;
						temp.middle = 0;
						temp.right = 0;
						Debug.Log (line);
						if (line == "") {
							Debug.Log ("no more data");
						}else{
							if (line [0] != '0') {
								if (line [0] == '2') {
									temp.left = (int)char.GetNumericValue (line [0]);
								} else {
									numberOfNotes++;
									temp.left = (int)char.GetNumericValue (line [0]);
								}
							}
							if (line [1] != '0') {
								if (line [1] == '2') {
									temp.middle = (int)char.GetNumericValue (line [1]);
								} else {
									numberOfNotes++;
									temp.middle = (int)char.GetNumericValue (line [1]);
								}
							}
							if (line [2] != '0') {
								if (line [2] == '2') {
									temp.right = (int)char.GetNumericValue (line [2]);
								} else {
									numberOfNotes++;
									temp.right = (int)char.GetNumericValue (line [2]);
								}
							}
							song1data.Add (temp);
						}

					}
						
					}
				}
					
				}
			}
		


}
