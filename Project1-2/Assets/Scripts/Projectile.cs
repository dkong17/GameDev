using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile : MonoBehaviour {

	protected Rigidbody2D rb;
	protected Collider2D myCollider;
	protected SpriteRenderer mySprite;
	protected float speed;

	public virtual void Start() {
		rb = GetComponent<Rigidbody2D>();
		myCollider = GetComponent<Collider2D>();
		int projectileLayer = LayerMask.NameToLayer("Projectiles");
		int playerLayer = LayerMask.NameToLayer("Player");
		print(projectileLayer);
		print(playerLayer);
		Physics2D.IgnoreLayerCollision(projectileLayer, playerLayer, true);
	}

	/* Use for item movement, sounds, etc. */
	public abstract void FixedUpdate();
}
