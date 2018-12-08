using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingPatral : MonoBehaviour {

	// Use this for initialization
	 public Texture2D tex;
     public float speed;

    private Rigidbody2D rb2D;
    private Sprite mySprite;
    private SpriteRenderer sr;
    private float revSpeed = 50.0f;

    void Awake()
    {
        //sr = gameObject.AddComponent<SpriteRenderer>();
        //rb2D = gameObject.AddComponent<Rigidbody2D>();
    }

    void Start()
    {
        //mySprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);
       // transform.localScale = new Vector3(3.0f, 3.0f, 3.0f);
        //rb2D.gravityScale = 0.0f;
        //sr.sprite = mySprite;\
        //rd2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 moement = new Vector3 (moveHorizontal, moveVertical, 0.0f);
        //rb2D.MoveRotation(rb2D.rotation + revSpeed * Time.fixedDeltaTime);
    }
}
