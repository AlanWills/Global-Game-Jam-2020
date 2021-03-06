﻿using UnityEngine;
using UnityEditor;
using System.IO;

namespace Celeste.Utility
{
	public static class ScriptableObjectUtility
	{
		public static void CreateAsset<T>() where T : ScriptableObject
		{
			T asset = ScriptableObject.CreateInstance<T>();

			string path = AssetDatabase.GetAssetPath(Selection.activeObject);
			if (path == "")
			{
				path = "Assets";
			}
			else if (Path.GetExtension(path) != "")
			{
				path = path.Replace(Path.GetFileName(AssetDatabase.GetAssetPath(Selection.activeObject)), "");
			}

			string assetPathAndName = AssetDatabase.GenerateUniqueAssetPath(path + "/" + typeof(T).Name + ".asset");

			AssetDatabase.CreateAsset(asset, assetPathAndName);
			AssetDatabase.SaveAssets();
			AssetDatabase.Refresh();
			Selection.activeObject = asset;
			EditorUtility.FocusProjectWindow();
		}
	}
}