using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class Distances : MonoBehaviour
{
    public GameObject shadow;
    public GameObject Treasure_1;
    public GameObject[] objs;
    public string metaldetectorButton = "t";                // Default metaldetector button input name.
    public GameObject Mine;
    public GameObject Explosion;
    public int mineCounter;
    public int mineAmount;
    public GameObject ChildGameObject1;

    List<GameObject> objList = new List<GameObject>();

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
    int a;

    void Start()
    {

        shadow = GameObject.FindWithTag("Player");
        Treasure_1 = GameObject.FindWithTag("T_1");
        objs = GameObject.FindGameObjectsWithTag("T_1");
        mineCounter = MasterSettings.amountOfTreasures;
        mineAmount = Score.minesLeft;


        foreach (var obj in objs)
        {
            objList.Add(obj);
        }

        m_bib_sound = GetComponent<AudioSource>();
        m_bib_sound.clip = Resources.Load<AudioClip>("Sounds/metal_detector_bib_sound");

    }

    public void playSound()
    {
        m_bib_sound.PlayOneShot(m_bib_sound.clip, volume);
    }

    void Update()
    {


        /*         if(Input.GetKey(metaldetectorButton) == false)
         {
             ChildGameObject1.SetActive(false);
         }

         if(Input.GetKey(metaldetectorButton))
         {
             a = 1;
             ChildGameObject1.SetActive(true);
         }*/


        if (Input.GetKeyDown(metaldetectorButton) == true)
        {
            if (ChildGameObject1.activeSelf == true) { ChildGameObject1.SetActive(false); a = 0; return; }

            if (ChildGameObject1.activeSelf == false) { ChildGameObject1.SetActive(true); a = 1; return; }
        }
    }

    void FixedUpdate()
    {

        /* if(Input.GetKey(metaldetectorButton) == false)
         {
             ChildGameObject1.SetActive(false);
         }

         if(Input.GetKey(metaldetectorButton))
         {
             a = 1;
             ChildGameObject1.SetActive(true);
         } 
     */
        if (a == 1)
        {

            foreach (var obj in objList)
            {
                //only do something if object is not null (destroyed)
                if (obj != null)
                {

                    Dist = Vector3.Distance(shadow.transform.position, obj.transform.position);
                    if (Dist > 10)
                    {
                        // Debug.Log(Dist);
                        d1 = 1;
                    }
                    if (Dist < 10 && Dist > 8)
                    {
                        //Debug.Log(Dist);
                        d2 = 2;
                    }
                    if (Dist < 8 && Dist > 6)
                    {
                        //Debug.Log(Dist);
                        d3 = 3;
                    }
                    if (Dist < 6 && Dist > 4)
                    {
                        //Debug.Log(Dist);
                        d4 = 4;
                    }
                    if (Dist < 4 && Dist > 2)
                    {
                        //Debug.Log(Dist);
                        d5 = 5;
                    }
                    if (Dist < 2 && Dist > 1)
                    {
                        //Debug.Log(Dist);
                        d6 = 6;
                    }
                    if (Dist < 1)
                    {
                        //Debug.Log(Dist);
                        d7 = 7;

                        int random = Random.Range(0, mineCounter);

                        CollectTreasure(obj); //reduces mineCount by 1
                        Debug.Log(random + "" + mineCounter);

                        if (mineCounter == mineAmount + 1)
                        {
                            // You win the game
                        }

                        if (random <= mineAmount)
                        {
                            RandomMineSpawn(obj.transform);
                        }
                    }
                }
            }
        }

        if (d1 == 1 && d2 != 2 && d3 != 3 && d4 != 4 && d5 != 5 && d6 != 6 && d7 != 7)
        {
            timer += 0.040f;
            if (timer > timeBetweenShots)
            {
                playSound();
                timer = 0;
            }
        }

        if (d2 == 2)
        {
            timer += 0.070f;
            if (timer > timeBetweenShots)
            {
                playSound();
                timer = 0;
            }
        }

        if (d3 == 3)
        {
            timer += 0.10f;
            if (timer > timeBetweenShots)
            {
                playSound();
                timer = 0;
            }
        }

        if (d4 == 4)
        {
            timer += 0.15f;
            if (timer > timeBetweenShots)
            {
                playSound();
                timer = 0;
            }
        }

        if (d5 == 5)
        {
            timer += 0.22f;
            if (timer > timeBetweenShots)
            {
                playSound();
                timer = 0;
            }
        }

        if (d6 == 6)
        {
            timer += 0.40f;
            if (timer > timeBetweenShots)
            {
                playSound();
                timer = 0;
            }
        }

        if (d7 == 7)
        {
            timer += 0.68f;
            if (timer > timeBetweenShots)
            {
                playSound();

                timer = 0;
            }
        }

        d1 = 0;
        d2 = 0;
        d3 = 0;
        d4 = 0;
        d5 = 0;
        d6 = 0;
        d7 = 0;

    }


    void CollectTreasure(Object treasure)
    {
        Object.Destroy(treasure);
        Score.currentScore = Score.currentScore + 1;
        mineCounter = mineCounter - 1;
    }

    void RandomMineSpawn(Transform mineTransform)
    {
        Object.Instantiate(Mine, mineTransform.position, mineTransform.rotation);
        Object.Instantiate(Explosion,mineTransform.position, mineTransform.rotation);
        Score.currentScore = Score.currentScore - 1;
        Score.minesLeft = Score.minesLeft -1;
        mineAmount = mineAmount -1;
        LoseGame();
    }

    void WinGame()
    {
        Score.scoreString = "You win the game! Highscore = ";
    }

    void LoseGame()
    {
        Score.scoreString = "You died! Highscore = ";
    }

}