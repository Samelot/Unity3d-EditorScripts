using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
	
public class DuplicatePrefab : ScriptableObject {
	[MenuItem("Samelot/DuplicateSelected %#d")]
	public static void DuplicateSelected ()
	{
		GameObject clone;
		Transform t = Selection.activeTransform;
		int index = t.GetSiblingIndex ();
		Object prefabRoot = PrefabUtility.GetPrefabParent (Selection.activeGameObject);
		
		if (prefabRoot != null) {
			PrefabUtility.InstantiatePrefab (prefabRoot);
		} else {
			clone = Instantiate (Selection.activeGameObject);	
			clone.transform.SetSiblingIndex (index);
			clone.name = clone.name.Replace("(Clone)", "");
		}
	}
}



