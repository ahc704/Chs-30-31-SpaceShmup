using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Enemy_1 extends the Enemy class
public class Enemy_1 : Enemy {

    [Header("Set in Inspector: Enemy_1")]
    public float waveFrequency = 2;
    public float waveWidth = 4;
    public float waveRotY = 45;

    private float x0; //The initial x value of pos
    private float birthTime;


	// Use this for initialization
	void Start()
    {
        x0 = pos.x;

        birthTime = Time.time;
    }

    // Override the Move function on Enemy
    public override void Move()
    {
        Vector3 tempPos = pos;

        float age = Time.deltaTime - birthTime;
        float theta = Mathf.PI * 2 * age / waveFrequency;
        float sin = Mathf.Sin(theta);
        tempPos.x = x0 + waveWidth * sin;

        base.Move();
    }
    // make sure to read the section on what is needed to override a function


}
