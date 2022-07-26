using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector3 direction = new Vector3(-1,0,0);
    public float speed = 2f;
    public int hp = 100;
    public int attack = 25;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Damage(attack);
    }
    private void Move()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
    void Damage(int value)
    {
        hp = hp - value;
    }
}
