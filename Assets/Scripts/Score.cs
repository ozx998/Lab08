using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public GameObject Text;
    public float timer = 5.02f;
    public float delaytime;
    public int score;
    public bool deletescore = true;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("scoreIncrease", 1, 1);
        InvokeRepeating("startscore",1,1);
    }
    
    // Update is called once per frame
    void Update()
    {
        delaytime += Time.deltaTime;
        if( timer <= delaytime)
        {
            deletescore = false;
            
        }
        Text.GetComponent<Text>().text = "Score: " + score;
    }
    void startscore()
    {
        if(deletescore == true)
        {
            
            score = 0;
        }
    }
    void scoreIncrease()
    {
        score++;
    }
}
