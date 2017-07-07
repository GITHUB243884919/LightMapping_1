﻿using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	//烘培烘培贴图1
	public Texture2D greenLightMap;
	//烘培贴图2
	public Texture2D redLightMap;
	void OnGUI()
	{
		if(GUILayout.Button("green"))
		{
			LightmapData data = new LightmapData();
			data.lightmapFar = greenLightMap;
			LightmapSettings.lightmaps = new LightmapData[1]{data};
		}

		if(GUILayout.Button("red"))
		{
			LightmapData data = new LightmapData();
			data.lightmapFar = redLightMap;
			LightmapSettings.lightmaps = new LightmapData[1]{data};
		}
	}
}
