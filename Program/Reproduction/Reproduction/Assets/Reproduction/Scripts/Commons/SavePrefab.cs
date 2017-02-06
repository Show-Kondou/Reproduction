
//_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
//
//  [SavePrefab]
//
//  ファイル名：SavePrefab.cs
//  説　　　明：プレハブの任意保存コマンド拡張
//  制　作　者：Show Kondou
//
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
//  - 更新履歴 -
//  2017  01/28　… 新規作成	※変更禁止
//
//_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
public class Util : Editor {
	[UnityEditor.MenuItem( "Edit/SavePrefab %&s" )]
	static void SavePrefab() {
		AssetDatabase.SaveAssets();
	}
}
#endif