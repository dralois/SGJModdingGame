﻿using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New Mod", menuName = "Mods/Empty Mod")]
public class Mod_Empty : IModObject
{
	protected override void AwakeInternal()
	{
	}

	protected override void OnEnableInternal()
	{
	}

	protected override void UpdateInternal()
	{
	}

	protected override void OnDisableInternal()
	{
	}

	protected override void DestroyInternal()
	{
	}
}
