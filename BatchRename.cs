using UnityEngine;
using UnityEditor;
using System.Collections;

public class BatchRename : ScriptableObject {
	
	[MenuItem ("Samelot/BatchRename")]
		static void gorb() { // Renames all selected items in the Hierarchy to the first item selected, with numbers.
		string iname;
		string ispacer = "0"; 
		
		int icount = 0; 
		iname = Selection.activeGameObject.name;   // The item in the inspector
		GameObject[] objs = Selection.gameObjects;
//		istuff = Selection.gameObjects.length;  // if I wanted this to support renaming of > 99 objects correctly, I'd use this. 
		foreach (GameObject obj in objs) {
//			icount ++; 
//			if (icount > 9) {
//				ispacer = ""; 
//			}
			obj.name = iname + "-" + ispacer + icount; 
			icount ++;
		}
	}	
}
