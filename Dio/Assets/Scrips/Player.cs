using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update}
    public float speed = 5.5f;
    public int hp = 100;
    public string namePlayer = "Ronnie Dio";
    public int attack = 20;
    public int heal = 5;
    private void Start()
    {
        Debug.Log(hp);
        Debug.Log("EJECUTANDO EL START");
        transform.position += Vector3.right;
    }
    // Update is called once per frame
    //PARAMETRO: es una forma de otorgarle al metodo un valor para que lo use internamente
    void Update()
    {
        Damage(attack);
        Debug.Log("EJECUTANDO EL UPDATE");
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
    //METODO
    void Damage(int value)
    {
        hp = hp - value;
    }
    public Player(int heal)
    {
        heal += 5;
    }
}