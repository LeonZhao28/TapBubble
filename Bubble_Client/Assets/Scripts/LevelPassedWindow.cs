﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelPassedWindow : MonoBehaviour {

	public List<UISprite> StarList;
	public HomeWindow homeWindow;

	public UILabel LevelLabel;

	public void Show(int level, int star)
	{
		LevelLabel.text = level.ToString();
		for(int i = 0; i < StarList.Count; i ++)
		{
			StarList[i].enabled = i < star;
		}
	}

	public void GoNextLevel()
	{
		Debug.Log ("Click to Next Level");
		this.gameObject.SetActive (false);
		AppMain.Instance.CurrentLevel += 1;
		TweenRZ.Add (AppMain.Instance.HomeWindow.background.GetComponent<Background>().earth, 1f, 30f).OnComplete+= AppMain.Instance.HomeWindow.BeginMission;
	}

	public void ShowHome()
	{
		this.gameObject.SetActive (false);
		AppMain.Instance.HomeWindow.ShowHomeWindow ();
	}

	public void StartAgain()
	{
		this.gameObject.SetActive (false);
		AppMain.Instance.HomeWindow.gameController.BeginMission ();
	}
}
