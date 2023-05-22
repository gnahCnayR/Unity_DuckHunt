using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DuckMover : MonoBehaviour
{
    public GameObject ScoreDisplay;
    static private int totalScore;
    
    public int Bullets = 3;
    
    public GameObject Duck;
    public GameObject bulletNumber;
   

    
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(Duck.gameObject);
            Bullets--;
            totalScore += 1000;
            ScoreDisplay.GetComponent<TextMeshProUGUI>().text = totalScore.ToString();
          
            bulletNumber.GetComponent<TextMeshProUGUI>().text = Bullets.ToString();
        }
    }
    // Update is called once per frame
    void Update()
    {
        float xPos = Random.Range(-5, 8);
        float yVel = Random.Range(9, 12);
        float xVel = Random.Range(-5, 8);

        if (this.transform.position.y < -4)
        {
            xPos = Random.Range(-5, 8);

            if (xPos < -2)
            {
                xVel = Random.Range(-1, 6);
            }
            if (xPos > 3)
            {
                xVel = Random.Range(-6, 1);
            }
            this.transform.position = new Vector2(xPos, -2);

            this.GetComponent<Rigidbody2D>().velocity = new Vector2(xVel, yVel);
        }
    }
}
