using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    public GameObject applePrefab;

    public float speed = 1f;
    public float leftAndRightEdge = 10;
    public float chanceToChangeDirection = 0.1f;
    public float secondsBetweenAppleDrops = 1f;
    // Start is called before the first frame update
    void Start()
    {
        // Dropping apples every second
        InvokeRepeating("DropApple", 2f, secondsBetweenAppleDrops);
    }

    void DropApple()
    {
        GameObject apple = Instantiate(applePrefab) as GameObject;
        apple.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //move right
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); //move left
        }
    }
    void FixedUpdate()
    {
        // Change drection randomly
        if (Random.value < chanceToChangeDirection)
        {
            speed *= -1; //change direction
        }
    }
}