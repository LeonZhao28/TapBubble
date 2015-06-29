﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.IO;

public class MissionConfig {

	private static Dictionary<int,MissionMeta> missionMetaMap = new Dictionary<int, MissionMeta>();

	public static MissionMeta getMissionMeta(int missionId){

		if (missionMetaMap.Count == 0) {
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load(Application.dataPath+"/mission.xml");
			XmlNodeList nodeList = xmlDoc.SelectSingleNode("mission").ChildNodes;
			foreach(XmlNode xmlNode in nodeList){
				XmlElement xe = (XmlElement) xmlNode;
				MissionMeta meta = new MissionMeta();
				meta.missionId = int.Parse(xe.GetAttribute("mission_id"));
				//meta.bubbleNum = int.Parse(xe.GetAttribute("bubble_num"));
				meta.positiveNum = int.Parse(xe.GetAttribute("postivie_num"));
				meta.negativeNum = int.Parse(xe.GetAttribute("negative_num"));
				meta.easyOperation = int.Parse(xe.GetAttribute("easy_op"));
				meta.hardOperation = int.Parse(xe.GetAttribute("hard_op"));
				meta.radical = int.Parse(xe.GetAttribute("redical_num"));
				meta.time = int.Parse(xe.GetAttribute("time"));
				meta.level3 = int.Parse(xe.GetAttribute("level3"));
				meta.level2 = int.Parse(xe.GetAttribute("level2"));
				meta.level1 = int.Parse(xe.GetAttribute("level1"));
				missionMetaMap.Add(meta.missionId,meta);
			}
		}

		return missionMetaMap[missionId];

	}

}
