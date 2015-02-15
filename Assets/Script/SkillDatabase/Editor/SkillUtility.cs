using UnityEngine;
using UnityEditor;
using System.Collections;

public class SkillUtility {
	[MenuItem("Assets/Create/Skill")]
	static public void CreateSkill(){ScriptableObjectUtility.CreateAsset<Skill>();}
}
