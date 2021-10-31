using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public GameObject Text;
    public float timer = 5.3f;
    public float delaytime;
    public int score;
    public bool scorestart = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        delaytime += Time.deltaTime;
        if( timer <= delaytime)
        {
            scorestart = true;
            
        }
        Text.GetComponent<Text>().text = "Score: " + score;
    }
    void startscore()
    {
        while(scorestart == true)
        {
            InvokeRepeating("scoreIncrease", 1, 1);
        }
    }
    void scoreIncrease()
    {
        score++;
    }
}
