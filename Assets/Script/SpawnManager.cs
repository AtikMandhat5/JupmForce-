using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spwanPos= new Vector3(25,0,0);
    private float startDelay=2;
    private float repeatRate=2;
    public PlayerConroller playerControllerScript;
    

    // Start is called before the first frame update
    void Start()
    {

        // reapating function calling 
        InvokeRepeating("SpawnObsacle",startDelay,repeatRate);

    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnObsacle()
    {
     if(playerControllerScript.gameOver == false)
     {
        //create copy object , position, transform rotation 
        Instantiate(obstaclePrefab,spwanPos,obstaclePrefab.transform.rotation);
    }
    }
}
