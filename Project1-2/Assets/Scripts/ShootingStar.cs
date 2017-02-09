using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingStar : Projectile {
	public override void Start() {
		base.Start();
		GameObject mario = GameObject.Find("Star Mario");
		speed = 20f * mario.transform.localScale.x;
		rb.gravityScale = 0;
		rb.isKinematic = false;
	}
		
	public override void FixedUpdate() {
		rb.velocity = new Vector3(speed, 0);
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (LayerMask.LayerToName(coll.gameObject.layer) == "Enemy") {
			Enemy enemy = coll.collider.GetComponentInParent<Enemy>();
			enemy.HitByProjectile();
		}
		Destroy(gameObject);
	}
}
