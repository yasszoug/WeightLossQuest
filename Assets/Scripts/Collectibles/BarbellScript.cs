﻿using UnityEngine;
using System.Collections;

public class BarbellScript : CollectibleBase 
{
	public float WeightGain = -20f;
	
	public override void OnPickup()
	{
		ServiceManager.Instance.GetService<EventManager>(ServiceType.EventManager).
			FireEvent(StatsManager.WeightChange, new WeightChangeEventArgs(WeightGain));
	}
}
