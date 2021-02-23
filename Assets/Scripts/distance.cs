using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Distance : MonoBehaviour
{
    public GameObject shadow;
    public GameObject Treasure_1;
    public GameObject[] objs;


    public AudioSource m_bib_sound;
    public float volume = 1.0f;
    public float timeBetweenShots = 2.0f;
    float timer = 0.0f;

    float Dist;
    int d1;
    int d2;
    int d3;
    int d4;
    int d5;
    int d6;
    int d7;


    void Start()
    {

        shadow = GameObject.FindWithTag("Player");
        Treasure_1 = GameObject.FindWithTag("T_1");
        objs = GameObject.FindGameObjectsWithTag("T_1");
        
 
        m_bib_sound = GetComponent<AudioSource>();
        m_bib_sound.clip = Resources.Load<AudioClip>("Sounds/metal_detector_bib_sound");

    }



    public void playSound()
    {
        m_bib_sound.PlayOneShot(m_bib_sound.clip,volume);
    }



    void FixedUpdate()
    {
        //TODO spawn med forskelligt navn, brug navnene til at finde nærmeste object.    

        foreach (var obj in objs)
        {
             Dist = Vector3.Distance(shadow.transform.position,obj.transform.position);
            if(Dist > 10){
               // Debug.Log(Dist);
                d1 = 1;
            }
                if(Dist < 10 && Dist > 8){
                Debug.Log(Dist);
                d2 = 2;
            }
                if(Dist < 8 && Dist > 6){
                Debug.Log(Dist);
                d3 = 3;
            }
                if(Dist < 6 && Dist > 4){
                Debug.Log(Dist);
                d4 = 4;
            }
                if(Dist < 4 && Dist > 2){
                Debug.Log(Dist);
                d5 = 5;
            }
                if(Dist < 2 && Dist > 1){
                Debug.Log(Dist);
                d6 = 6;
            }      
                if(Dist < 1){
                Debug.Log(Dist);
                d7 = 7;
            }                  
        }

    if(d1 == 1 && d2 != 2 && d3 != 3 && d4 != 4 && d5 != 5 && d6 != 6 && d7 != 7){
            timer += 0.040f;
            if (timer > timeBetweenShots)
            {
                playSound();
                timer = 0;
            }
    }

    if(d2 == 2 && d3 != 3 && d4 != 4 && d5 != 5 && d6 != 6 && d7 != 7){
            timer += 0.070f;
            if (timer > timeBetweenShots)
            {
                playSound();
                timer = 0;
            }
    }

    if(d3 == 3 && d2 != 2 && d4 != 4 && d5 != 5 && d6 != 6 && d7 != 7){
            timer += 0.10f;
            if (timer > timeBetweenShots)
            {
                playSound();
                timer = 0;
            }
    }    

    if(d4 == 4 && d2 != 2 && d3 != 3 && d5 != 5 && d6 != 6 && d7 != 7){
            timer += 0.15f;
            if (timer > timeBetweenShots)
            {
                playSound();
                timer = 0;
            }
    }       

    if(d5 == 5 && d2 != 2 && d3 != 3 && d4 != 4 && d6 != 6 && d7 != 7){
            timer += 0.22f;
            if (timer > timeBetweenShots)
            {
                playSound();
                timer = 0;
            }
    }       

    if(d6 == 6 && d2 != 2 && d3 != 3 && d4 != 4 && d5 != 5 && d7 != 7){
            timer += 0.40f;
            if (timer > timeBetweenShots)
            {
                playSound();
                timer = 0;
            }
    }       

    if(d7 == 7 && d2 != 2 && d3 != 3 && d4 != 4 && d5 != 5 && d6 != 6){
            timer += 0.68f;
            if (timer > timeBetweenShots)
            {
                playSound();
                timer = 0;
            }
    }

    d2 = 0;
    d3 = 0;
    d4 = 0;
    d5 = 0;
    d6 = 0;
    d7 = 0;
    
    }


}