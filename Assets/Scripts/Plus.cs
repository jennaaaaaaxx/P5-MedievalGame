using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plus : MonoBehaviour
{
    public Text thisText;
    
    public GameObject canvas;
    public int x, y;
    
    public float timer;
    public int speed;

    void Start()
    {
        timer = 0;

        canvas = GameObject.Find("Canvas");
        transform.SetParent(canvas.transform);

        x = Random.Range(-150, 151);
        y = Random.Range(-150, 151);

        transform.localPosition = new Vector3(x, y, 0);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= 1f)
        {
            Destroy(this.gameObject);
        }

        transform.position = new Vector3(transform.position.x, transform.position.y + Time.deltaTime * speed, 0);
        thisText.text = "+" + Game.hitPower;
    }
}
