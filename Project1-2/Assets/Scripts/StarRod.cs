using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarRod : Item {

	public override void Start()
	{
		base.Start();
	}

	public override void FixedUpdate() {}

	public override void PickUpItem(PlayerController player)
	{
		player.Grow();
		Destroy(gameObject);
	}
}
