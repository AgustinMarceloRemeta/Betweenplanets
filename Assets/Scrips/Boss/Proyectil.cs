using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : Enemy
{
    [SerializeField] float KeyVelocity, TimeDestroy;
    // Player player;
    public override void Start()
    {
        base.Start();
        Destroy(gameObject, TimeDestroy);
    }
    public override void Update()
    {
        base.Update();

    }

    public override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Player>().Color == color) ToDie = true;
        base.OnCollisionEnter2D(collision);

    }
    public override void Mov()
    {
        this.transform.Translate(new Vector3(-KeyVelocity* Time.deltaTime, 0),Space.Self);
    }
}
