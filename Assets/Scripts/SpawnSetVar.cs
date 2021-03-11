using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSetVar : MonoBehaviour
{

    public GameObject[] objs;
    public TreasureVar refobj;
    int rand;
    // Start is called before the first frame update
    void Start()
    {
        objs = GameObject.FindGameObjectsWithTag("T_1");

        StartCoroutine(SetVars());     
    }

    IEnumerator SetVars()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 2 seconds.
        yield return new WaitForSeconds(2);

        foreach (var obj in objs)
        {
            rand = Random.Range(1,9);
            refobj = obj.GetComponent<TreasureVar>();

            refobj.integerToChange = rand;

        }

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);

        yield return new WaitForSeconds(4);
        
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);


    }



}
