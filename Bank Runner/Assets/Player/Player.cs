using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using imports;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Player : Move
{

/////////////////////////////////////////////////////////////////Movimentação//////////////////////////////////////////////////////
    float time = 0;
    bool movingY;
    float targetPosition;
    int lane = 0;
    void Update()
    {
        if (dead){
            return;
        }
        //Linear interpolation on Y axis
        if (movingY){
            time+= Time.deltaTime;
            transform.position = new Vector3(transform.position.x,Mathf.Lerp(transform.position.y, targetPosition, time), 0);
           
            if(1.0f-time<0.45f){
                time = 0.0f;
                movingY = false;
                transform.position = new Vector3(transform.position.x,targetPosition,0);
            }
            return;
        }

        //Input to move between lanes
        if(Input.GetKey(KeyCode.W) && lane!=0){
            lane-=1;
            movingY = true;
            targetPosition = transform.position.y +3.2f;
        } 
        else if(Input.GetKey(KeyCode.S) && lane!=2){
            lane+=1;
            movingY = true;
            targetPosition = transform.position.y -3.2f;
        }

    }
//////////////////////////////////////////////////////Collision//////////////////////////////////////////////////////
    public GameObject GameOverUi;
    bool dead = true;
    public GameObject cameraa;
    public void crash(){
        cameraa.GetComponent<Move>().speed = 0;
        speed = 0;
        dead = true;
        GameOverUi.SetActive(true);
        GameObject.Find("EndPoints").GetComponent<Text>().text = "You did "+points.ToString()+ " Points";
        if (points > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", points);
            Points.transform.GetChild(0).GetComponent<Text>().text = "Highscore: "+PlayerPrefs.GetInt("highscore", 0).ToString();
        }
        }

//////////////////////////////////////////////////////Points//////////////////////////////////////////////////////
public GameObject Points;
int points = 0;
public void getPoint(){

    speed+=1;
    cameraa.GetComponent<Move>().speed += 1;
    
    points +=2;
    var a  = "Points: "+(points.ToString());
    Points.GetComponent<Text>().text = a;
}

public void SStart(){
    Destroy(GameObject.Find("Start"));
    cameraa.GetComponent<Move>().speed = 80;
    speed = 80;
    dead = false;
    int highScore = PlayerPrefs.GetInt("highscore", 0);
    Points.transform.GetChild(0).GetComponent<Text>().text = "Highscore: "+highScore.ToString();
    Points.SetActive(true);
}
}



