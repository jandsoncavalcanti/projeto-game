using UnityEngine;
using UnityEditor;
using System.Collections;

public class ItemUtility {
	[MenuItem("Assets/Create/Item")]
	static public void CreateItem(){ScriptableObjectUtility.CreateAsset<Item>();}
}
