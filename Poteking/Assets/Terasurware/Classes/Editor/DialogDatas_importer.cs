using UnityEngine;
using System.Collections;
using System.IO;
using UnityEditor;
using System.Xml.Serialization;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;

public class DialogDatas_importer : AssetPostprocessor {
	private static readonly string filePath = "Assets/GameResource/Excel/DialogDatas.xlsx";
	private static readonly string exportPath = "Assets/GameResource/Excel/DialogDatas.asset";
	private static readonly string[] sheetNames = { "Dialogue", };
	
	static void OnPostprocessAllAssets (string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
	{
		foreach (string asset in importedAssets) {
			if (!filePath.Equals (asset))
				continue;
				
			Entity_Dialogue data = (Entity_Dialogue)AssetDatabase.LoadAssetAtPath (exportPath, typeof(Entity_Dialogue));
			if (data == null) {
				data = ScriptableObject.CreateInstance<Entity_Dialogue> ();
				AssetDatabase.CreateAsset ((ScriptableObject)data, exportPath);
				data.hideFlags = HideFlags.NotEditable;
			}
			
			data.sheets.Clear ();
			using (FileStream stream = File.Open (filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) {
				IWorkbook book = null;
				if (Path.GetExtension (filePath) == ".xls") {
					book = new HSSFWorkbook(stream);
				} else {
					book = new XSSFWorkbook(stream);
				}
				
				foreach(string sheetName in sheetNames) {
					ISheet sheet = book.GetSheet(sheetName);
					if( sheet == null ) {
						Debug.LogError("[QuestData] sheet not found:" + sheetName);
						continue;
					}

					Entity_Dialogue.Sheet s = new Entity_Dialogue.Sheet ();
					s.name = sheetName;
				
					for (int i=1; i<= sheet.LastRowNum; i++) {
						IRow row = sheet.GetRow (i);
						ICell cell = null;
						
						Entity_Dialogue.Param p = new Entity_Dialogue.Param ();
						
					cell = row.GetCell(0); p.index = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(1); p.npc = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(2); p.gamestate = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(3); p.npcname = (cell == null ? "" : cell.StringCellValue);
					cell = row.GetCell(4); p.Dialog = (cell == null ? "" : cell.StringCellValue);
					cell = row.GetCell(5); p.changeState = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(6); p.choice1 = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(7); p.choice2 = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(8); p.choice1text = (cell == null ? "" : cell.StringCellValue);
					cell = row.GetCell(9); p.choice2text = (cell == null ? "" : cell.StringCellValue);
					cell = row.GetCell(10); p.leftface = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(11); p.rightface = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(12); p.background = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(13); p.midimage = (int)(cell == null ? 0 : cell.NumericCellValue);
						s.list.Add (p);
					}
					data.sheets.Add(s);
				}
			}

			ScriptableObject obj = AssetDatabase.LoadAssetAtPath (exportPath, typeof(ScriptableObject)) as ScriptableObject;
			EditorUtility.SetDirty (obj);
		}
	}
}
