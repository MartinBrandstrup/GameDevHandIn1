using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Distance : MonoBehaviour
{

    public GameObject shadow;
    public GameObject Cube1;

    public AudioSource m_bib_sound;

    public float volume = 1.0f;
    public float timeBetweenShots = 2.0f;
    float timer = 0.0f;

    void Start()
    {

        shadow = GameObject.FindWithTag("Player");
        Cube1 = GameObject.FindWithTag("Cube1");
 
        m_bib_sound = GetComponent<AudioSource>();
        m_bib_sound.clip = Resources.Load<AudioClip>("Sounds/metal_detector_bib_sound");

    }



    public void playSound()
    {
        m_bib_sound.PlayOneShot(m_bib_sound.clip,volume);
    }



    void FixedUpdate()
    {
        //we destroyed the old cube so need to search for the new copy
        Cube1 = GameObject.Find("Cube1(Clone)");

        //TODO spawn med forskelligt navn, brug navnene til at finde nærmeste object.

        float Distance = Vector3.Distance(shadow.transform.position,Cube1.transform.position);

        Debug.Log(Distance);



        //Lav dette til switch Case
        if (Distance > 10)
        {
            timer += 0.008f;
            if (timer > timeBetweenShots)
            {
                playSound();
                timer = 0;
            }
        }

        if (Distance < 10 && Distance > 8)
        {
            timer += 0.012f;
            if (timer > timeBetweenShots)
            {
                playSound();
                timer = 0;
            }
        }

        if (Distance < 8 && Distance > 6)
        {
            timer += 0.020f;
            if (timer > timeBetweenShots)
            {
                playSound();
                timer = 0;
            }
        }

        if (Distance < 6 && Distance > 4)
        {
            timer += 0.030f;
            if (timer > timeBetweenShots)
            {
                playSound();
                timer = 0;
            }
        }

        if (Distance < 4 && Distance > 2)
        {
            timer += 0.050f;
            if (timer > timeBetweenShots)
            {
                playSound();
                timer = 0;
            }
        }

        if (Distance < 2 && Distance > 1)
        {
            timer += 0.080f;
            if (timer > timeBetweenShots)
            {
                playSound();
                timer = 0;
            }
        }

        if (Distance < 1)
        {
            timer += 0.2f;
            if (timer > timeBetweenShots)
            {
                playSound();
                timer = 0;
            }
        }

    }


}