using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    public GameObject car;
    public float DelayTimer;
    float timer;

    void Start() {
        timer = DelayTimer;
    }

    void Update() {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Vector3 CarPos = new Vector3(Random.Range(-2.0f, 2.0f), transform.position.y, transform.position.z);
            Instantiate(car, CarPos, transform.rotation);
            timer = DelayTimer;
        }
    }
}
