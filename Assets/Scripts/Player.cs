using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float CarSpeed;
    Vector2 position;

    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position.x += Input.GetAxis("Horizontal") * CarSpeed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -2f, 2f);
        transform.position = position;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Menu");
        }
    }
}
