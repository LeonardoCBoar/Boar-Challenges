using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    obstaclesManager roadMan;
    private void Start() {
        roadMan = GameObject.Find("Road").GetComponent<obstaclesManager>();
    }


    void OnBecameInvisible() {
        //se a pista do meio sai da tela, todas as 3 pistas são realocadas pra frente
        for (int i = 0; i < transform.parent.childCount; i++)
        {
            Transform roadPart = transform.parent.GetChild(i);
            roadPart.position += new Vector3((3.2f*9 ),0,0);
            
            //deleta obstáculos antigos
            if(roadPart.childCount != 0){
                for (int j = 0; j < roadPart.childCount; j++){
                    Destroy(roadPart.GetChild(j).gameObject);
                }
            }
            
            //adiciona novos obstáculos


        }
        if(roadMan.nextObs>0){
            roadMan.nextObs-=1;
            return;
        }
        int chance = Random.Range(0,20);
        if(chance>8){

            addObstacle(transform.parent.GetChild(Random.Range(0,2)));
        }
    }

    public GameObject[] obstacles = new GameObject[3];
    void addObstacle(Transform road){
        var a  = Instantiate(obstacles[0],Vector3.zero,Quaternion.identity,road);
        a.transform.position = new Vector3(road.position.x,road.position.y,-1);
        roadMan.nextObs = 5;
    }
}
