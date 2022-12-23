using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class StepManager : MonoBehaviour
{
    

    #region variable

    RaycastHit hit;
    Ray ray;

    public int step;

    public GameObject stupa;

    public GameObject scales;
    public GameObject text;

    public GameObject cup1;
    public GameObject cup2;
    public GameObject cup3;
    public GameObject cup4;
    public GameObject cup5;
    public GameObject cup6;
    public GameObject cup7;
    public GameObject cup8;
    public GameObject cup9;

    public GameObject bottom;
    public GameObject bottom_2;

    public GameObject heap100;


    public GameObject shpat1;
    public GameObject shpat2;
    public GameObject shpat3;
    public GameObject shpat4;

    public GameObject pestik1;
    public GameObject pestik2;
    public GameObject pestik3;

    public GameObject heap1;
    public GameObject heap2;
    public GameObject heap3;
    public GameObject heap4;
    public GameObject heap5;
    public GameObject heap6;

    public GameObject heap8;

    public GameObject heap11;
    public GameObject heap22;
    public GameObject heap33;
    public GameObject heap44;
    public GameObject heap55;
    public GameObject heap66;
    public GameObject heap77;
    public GameObject heap88;
    public GameObject heap99;

    public GameObject heap301;
    public GameObject heap302;
    public GameObject heap303;
    public GameObject heap304;
    public GameObject heap305;
    public GameObject heap306;
    public GameObject heap307;
    public GameObject heap308;

    public GameObject cap;
    public GameObject cap1;
    public GameObject sieve10;
    public GameObject sieve5;
    public GameObject sieve2;
    public GameObject sieve1;
    public GameObject sieve0_5;
    public GameObject sieve0_25;
    public GameObject sieve0_1;
    
    public GameObject sieves;

    public GameObject cap_2;
    public GameObject sieve10_2;
    public GameObject sieve5_2;
    public GameObject sieve2_2;
    public GameObject sieve1_2;
    public GameObject sieve0_5_2;
    public GameObject sieve0_25_2;
    public GameObject sieve0_1_2;
    
   


    public static bool key;
    public static int num;
    public static float timer;
    public static bool even;
    public static int step_count;




    #endregion 

   
    void Start()
    {
        step_count = 1;
        key = false;
        timer = 6;
        even = false;
       

    }

void Update()
    {
        
        step = step_count;
        if (!InputManager.isPaused)
        {
            if (key)
            {
                timer -= Time.deltaTime;
                if (timer <= 0)
                {
                    key = false;
                    Step();
                }
            }

            //ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //if (Physics.Raycast(ray, out hit, 3f))
            //{
            //
            //    if (Input.GetKeyDown(KeyCode.Mouse0))
            //    {
            //        hit.collider.gameObject.SetActive(false);
            //
            //        step_count++;
            //    }
            //
            //}


            #region Шаг 1
            if (step_count == 1)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap1"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            hit.collider.gameObject.SetActive(false);
                            heap2.SetActive(true);

                            //text.SetActive(true);
                            
                            //text.GetComponent<TextMesh>().text = "ХУЙ!!!!";


                            step_count++;
                        }
                    }
                }
            }
            #endregion


            #region Шаг 2

            if (step_count == 2)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("pestik1"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            hit.collider.gameObject.SetActive(false);
                            pestik3.SetActive(true);
            
                            step_count++;
                        }
                    }
                }
            }

            #endregion



            #region Шаг 3
            
            if (step_count == 3)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("pestik3"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            step_count = 0;

                            pestik3.GetComponent<Animator>().Play("Mix");

                            heap2.SetActive(false);
                            heap3.SetActive(true);

                            
                            
                        }
                    }
                }
            }

            #endregion

            #region Шаг 4
            if (step_count == 4)
            {
                
                heap2.SetActive(false);
                heap3.SetActive(true);


                step_count++;
            }

            #endregion



            #region Шаг 5

            if (step_count == 5)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("pestik3"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
           
                            pestik3.SetActive(false);
                            pestik1.SetActive(true);
           
           
                            step_count++;
                        }
                    }
                }
            }
           
            #endregion


            #region Шаг 6

            if (step_count == 6)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap3"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {

                            hit.collider.gameObject.SetActive(false);
                            heap4.SetActive(true);


                            step_count++;
                        }
                    }
                }
            }

            #endregion

            #region Шаг 7

            if (step_count == 7)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("shpat1"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {

                            hit.collider.gameObject.SetActive(false);
                            shpat2.SetActive(true);


                            step_count++;
                        }
                    }
                }
            }

            #endregion

            #region Шаг 8

            if (step_count == 8)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("shpat2"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            step_count = 0;

                            hit.collider.gameObject.SetActive(false);
                            shpat3.SetActive(true);

                            shpat3.GetComponent<Animator>().Play("glad");

                            

                            
                        }
                    }
                }
            }

            #endregion

            #region Шаг 9

            if (step_count == 9)
            {
                heap4.SetActive(false);
                heap5.SetActive(true);

                step_count++;
            }

            #endregion

            #region Шаг 10

            if (step_count == 10)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("shpat3"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            step_count = 0;

                            hit.collider.gameObject.SetActive(false);
                            shpat4.SetActive(true);

                            shpat4.GetComponent<Animator>().Play("cut");

                        }
                    }
                }
            }

            #endregion

            #region Шаг 11

            if (step_count == 11)
            {
                heap5.SetActive(false);
                heap6.SetActive(true);

                step_count++;
            }

            #endregion

            #region Шаг 12

            if (step_count == 12)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("shpat4"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            

                            hit.collider.gameObject.SetActive(false);
                            shpat1.SetActive(true);

                            step_count=302;
                        }
                    }
                }
            }

            #endregion

            

            

            #region Шаг 30.2

            if (step_count == 302)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("cap"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            cap.SetActive(false);
                            cap1.SetActive(true);

                            step_count=29;
                        }
                    }
                }
            }

            #endregion

            #region Шаг 29

            if (step_count == 29)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap6-1") || hit.collider.gameObject.name.Equals("heap6-2"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            heap6.SetActive(false);

                            heap8.SetActive(true);


                            step_count=304;
                        }
                    }
                }
            }

            #endregion


            #region Шаг 30.4

            if (step_count == 304)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("cap1"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            cap1.SetActive(false);
                            cap.SetActive(true);

                            step_count++;
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.5

            if (step_count == 305)
            {
                sieves.GetComponent<Animator>().Play("Sieves_Up");// - НЕТ АНИМАЦИИ И ПРОДОЛЖЕНИЯ. ОСТАЛОСЬ СДЕЛАТЬ АНИМАЦИЮ ТРЯСКИ, РАСКИДАТЬ ПО ОСТАЛЬНЫМ ЧАШКАМ (done!)
                

                step_count = 0;
            }

            #endregion

            #region Шаг 30.6

            if (step_count == 306)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("cap"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            heap8.SetActive(false);
                            heap301.SetActive(true);
                            heap302.SetActive(true);
                            heap303.SetActive(true);
                            heap304.SetActive(true);
                            heap305.SetActive(true);
                            heap306.SetActive(true);
                            heap307.SetActive(true);
                            heap308.SetActive(true);

                            cap.SetActive(false);
                            cap_2.SetActive(true);

                            step_count = 3061;//-------------------------------!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                        }
                    }
                }
            }

            #endregion







            #region Шаг 30.6.1

            if (step_count == 3061)//---------------------
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("cup1"))//----------
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            hit.collider.gameObject.SetActive(false);
                            cup9.SetActive(true);//------------

                            text.SetActive(true);
                            text.GetComponent<TextMesh>().text = "30.1";//--------



                            step_count = 3062;//-----------
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.6.2

            if (step_count == 3062)//--------------
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("cup9"))//------------------
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            hit.collider.gameObject.SetActive(false);
                            cup1.SetActive(true);//------

                            text.SetActive(false);



                            step_count = 307;//----------
                        }
                    }
                }
            }

            #endregion


            #region Шаг 30.7

            if (step_count == 307)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap301") || hit.collider.gameObject.name.Equals("sieve10"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            heap301.SetActive(false);
                            sieve10.SetActive(false);

                            sieve10_2.SetActive(true);

                            heap11.SetActive(true);//--------

                            step_count++;
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.8

            if (step_count == 308)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap11") || hit.collider.gameObject.name.Equals("cup1"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            heap11.SetActive(false);
                            cup1.SetActive(false);

                            heap99.SetActive(true);
                            cup9.SetActive(true);

                            text.SetActive(true);
                            text.GetComponent<TextMesh>().text = "35.6";



                            step_count++;
                        }
                    }
                }
            }

            #endregion


            #region Шаг 30.9

            if (step_count == 309)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap99") || hit.collider.gameObject.name.Equals("cup9"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {

                            heap99.SetActive(false);
                            cup9.SetActive(false);

                            heap11.SetActive(true);
                            cup1.SetActive(true);

                            text.SetActive(false);

                            step_count=3091;
                        }
                    }
                }
            }

            #endregion





            #region Шаг 30.9.1

            if (step_count == 3091)//---------------------
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("cup2"))//----------
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            hit.collider.gameObject.SetActive(false);
                            cup9.SetActive(true);//------------

                            text.SetActive(true);
                            text.GetComponent<TextMesh>().text = "30.5";//--------



                            step_count = 3092;//-----------
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.9.2

            if (step_count == 3092)//--------------
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("cup9"))//------------------
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            hit.collider.gameObject.SetActive(false);
                            cup2.SetActive(true);//------

                            text.SetActive(false);



                            step_count = 310;//----------
                        }
                    }
                }
            }

            #endregion







            #region Шаг 30.10

            if (step_count == 310)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap302") || hit.collider.gameObject.name.Equals("sieve5"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            heap302.SetActive(false);
                            sieve5.SetActive(false);

                            sieve5_2.SetActive(true);

                            heap22.SetActive(true);//-----

                            step_count++;
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.11

            if (step_count == 311)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap22") || hit.collider.gameObject.name.Equals("cup2"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            heap22.SetActive(false);
                            cup2.SetActive(false);

                            heap99.SetActive(true);
                            cup9.SetActive(true);

                            text.SetActive(true);
                            text.GetComponent<TextMesh>().text = "45.5";



                            step_count++;
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.12

            if (step_count == 312)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap99") || hit.collider.gameObject.name.Equals("cup9"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {

                            heap99.SetActive(false);
                            cup9.SetActive(false);

                            heap22.SetActive(true);
                            cup2.SetActive(true);

                            text.SetActive(false);

                            step_count=30121;
                        }
                    }
                }
            }

            #endregion


            #region Шаг 30.12.1

            if (step_count == 30121)//---------------------
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("cup3"))//----------
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            hit.collider.gameObject.SetActive(false);
                            cup9.SetActive(true);//------------

                            text.SetActive(true);
                            text.GetComponent<TextMesh>().text = "31.0";//--------



                            step_count = 30122;//-----------
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.12.2

            if (step_count == 30122)//--------------
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("cup9"))//------------------
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            hit.collider.gameObject.SetActive(false);
                            cup3.SetActive(true);//------

                            text.SetActive(false);



                            step_count = 313;//----------
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.13

            if (step_count == 313)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap303") || hit.collider.gameObject.name.Equals("sieve2"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            heap303.SetActive(false);//----
                            sieve2.SetActive(false);//----

                            sieve2_2.SetActive(true);

                            heap33.SetActive(true);//---

                            step_count++;
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.14

            if (step_count == 314)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap33") || hit.collider.gameObject.name.Equals("cup3"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            heap33.SetActive(false);
                            cup3.SetActive(false);

                            heap99.SetActive(true);
                            cup9.SetActive(true);

                            text.SetActive(true);
                            text.GetComponent<TextMesh>().text = "51.0";



                            step_count++;
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.15

            if (step_count == 315)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap99") || hit.collider.gameObject.name.Equals("cup9"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {

                            heap99.SetActive(false);
                            cup9.SetActive(false);

                            heap33.SetActive(true);
                            cup3.SetActive(true);

                            text.SetActive(false);

                            step_count=30151;
                        }
                    }
                }
            }

            #endregion


            #region Шаг 30.15.1

            if (step_count == 30151)//---------------------
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("cup4"))//----------
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            hit.collider.gameObject.SetActive(false);
                            cup9.SetActive(true);//------------

                            text.SetActive(true);
                            text.GetComponent<TextMesh>().text = "35.0";//--------



                            step_count = 30152;//-----------
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.15.2

            if (step_count == 30152)//--------------
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("cup9"))//------------------
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            hit.collider.gameObject.SetActive(false);
                            cup4.SetActive(true);//------

                            text.SetActive(false);



                            step_count = 316;//----------
                        }
                    }
                }
            }

            #endregion

            #region 30.16

            if (step_count == 316)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap304") || hit.collider.gameObject.name.Equals("sieve1"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            heap304.SetActive(false);//----
                            sieve1.SetActive(false);//----

                            sieve1_2.SetActive(true);

                            heap44.SetActive(true);//---

                            step_count++;
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.17

            if (step_count == 317)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap44") || hit.collider.gameObject.name.Equals("cup4"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            heap44.SetActive(false);
                            cup4.SetActive(false);

                            heap99.SetActive(true);
                            cup9.SetActive(true);

                            text.SetActive(true);
                            text.GetComponent<TextMesh>().text = "75.5";



                            step_count++;
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.18

            if (step_count == 318)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap99") || hit.collider.gameObject.name.Equals("cup9"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {

                            heap99.SetActive(false);
                            cup9.SetActive(false);

                            heap44.SetActive(true);
                            cup4.SetActive(true);

                            text.SetActive(false);

                            step_count=30181;
                        }
                    }
                }
            }

            #endregion


            #region Шаг 30.18.1

            if (step_count == 30181)//---------------------
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("cup5"))//----------
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            hit.collider.gameObject.SetActive(false);
                            cup9.SetActive(true);//------------

                            text.SetActive(true);
                            text.GetComponent<TextMesh>().text = "31.4";//--------



                            step_count = 30182;//-----------
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.18.2

            if (step_count == 30182)//--------------
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("cup9"))//------------------
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            hit.collider.gameObject.SetActive(false);
                            cup5.SetActive(true);//------

                            text.SetActive(false);



                            step_count = 319;//----------
                        }
                    }
                }
            }

            #endregion

            #region 30.19

            if (step_count == 319)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap305") || hit.collider.gameObject.name.Equals("sieve0.5"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            heap305.SetActive(false);//----
                            sieve0_5.SetActive(false);//----

                            sieve0_5_2.SetActive(true);

                            heap55.SetActive(true);//---

                            step_count++;
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.20

            if (step_count == 320)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap55") || hit.collider.gameObject.name.Equals("cup5"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            heap55.SetActive(false);
                            cup5.SetActive(false);

                            heap99.SetActive(true);
                            cup9.SetActive(true);

                            text.SetActive(true);
                            text.GetComponent<TextMesh>().text = "81.8";



                            step_count++;
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.21

            if (step_count == 321)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap99") || hit.collider.gameObject.name.Equals("cup9"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {

                            heap99.SetActive(false);
                            cup9.SetActive(false);

                            heap55.SetActive(true);
                            cup5.SetActive(true);

                            text.SetActive(false);

                            step_count=30211;
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.18.1

            if (step_count == 30211)//---------------------
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("cup6"))//----------
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            hit.collider.gameObject.SetActive(false);
                            cup9.SetActive(true);//------------

                            text.SetActive(true);
                            text.GetComponent<TextMesh>().text = "30.0";//--------



                            step_count = 30212;//-----------
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.21.2

            if (step_count == 30212)//--------------
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("cup9"))//------------------
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            hit.collider.gameObject.SetActive(false);
                            cup6.SetActive(true);//------

                            text.SetActive(false);



                            step_count = 322;//----------
                        }
                    }
                }
            }

            #endregion

            #region 30.22

            if (step_count == 322)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap306") || hit.collider.gameObject.name.Equals("sieve0.25"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            heap306.SetActive(false);//----
                            sieve0_25.SetActive(false);//----

                            sieve0_25_2.SetActive(true);

                            heap66.SetActive(true);//---

                            step_count++;
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.23

            if (step_count == 323)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap66") || hit.collider.gameObject.name.Equals("cup6"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            heap66.SetActive(false);
                            cup6.SetActive(false);

                            heap99.SetActive(true);
                            cup9.SetActive(true);

                            text.SetActive(true);
                            text.GetComponent<TextMesh>().text = "114.0";



                            step_count++;
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.24

            if (step_count == 324)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap99") || hit.collider.gameObject.name.Equals("cup9"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {

                            heap99.SetActive(false);
                            cup9.SetActive(false);

                            heap66.SetActive(true);
                            cup6.SetActive(true);

                            text.SetActive(false);

                            step_count = 30241;
                        }
                    }
                }
            }

            #endregion


            #region Шаг 30.18.1

            if (step_count == 30241)//---------------------
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("cup7"))//----------
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            hit.collider.gameObject.SetActive(false);
                            cup9.SetActive(true);//------------

                            text.SetActive(true);
                            text.GetComponent<TextMesh>().text = "81.7";//--------



                            step_count = 30242;//-----------
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.24.2

            if (step_count == 30242)//--------------
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("cup9"))//------------------
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            hit.collider.gameObject.SetActive(false);
                            cup7.SetActive(true);//------

                            text.SetActive(false);



                            step_count = 325;//----------
                        }
                    }
                }
            }

            #endregion

            #region 30.25

            if (step_count == 325)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap307") || hit.collider.gameObject.name.Equals("sieve0.1"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            heap307.SetActive(false);//----
                            sieve0_1.SetActive(false);//----

                            sieve0_1_2.SetActive(true);

                            heap77.SetActive(true);//---

                            step_count++;
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.26

            if (step_count == 326)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap77") || hit.collider.gameObject.name.Equals("cup7"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            heap77.SetActive(false);
                            cup7.SetActive(false);

                            heap99.SetActive(true);
                            cup9.SetActive(true);

                            text.SetActive(true);
                            text.GetComponent<TextMesh>().text = "336.7";



                            step_count++;
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.27

            if (step_count == 327)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap99") || hit.collider.gameObject.name.Equals("cup9"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {

                            heap99.SetActive(false);
                            cup9.SetActive(false);

                            heap77.SetActive(true);
                            cup7.SetActive(true);

                            text.SetActive(false);

                            step_count= 33333333;
                        }
                    }
                }
            }

            #endregion


            //-----------------------------------------------------------------------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------------------------------------------------------------------


            #region Шаг 30.18.1

            if (step_count == 33333333)//---------------------
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("cup8"))//----------
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            hit.collider.gameObject.SetActive(false);
                            cup9.SetActive(true);//------------

                            text.SetActive(true);
                            text.GetComponent<TextMesh>().text = "31.0";//--------



                            step_count = 33333334;//-----------
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.24.2

            if (step_count == 33333334)//--------------
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("cup9"))//------------------
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            hit.collider.gameObject.SetActive(false);
                            cup8.SetActive(true);//------

                            text.SetActive(false);



                            step_count = 33333335;//----------
                        }
                    }
                }
            }

            #endregion

            #region 30.25

            if (step_count == 33333335)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap308") || hit.collider.gameObject.name.Equals("bottom"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            heap308.SetActive(false);//----
                            bottom.SetActive(false);//----

                            bottom_2.SetActive(true);

                            heap88.SetActive(true);//---

                            step_count++;
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.26

            if (step_count == 33333336)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap88") || hit.collider.gameObject.name.Equals("cup8"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {


                            heap88.SetActive(false);
                            cup8.SetActive(false);

                            heap99.SetActive(true);
                            cup9.SetActive(true);

                            text.SetActive(true);
                            text.GetComponent<TextMesh>().text = "56.0";



                            step_count++;
                        }
                    }
                }
            }

            #endregion

            #region Шаг 30.27

            if (step_count == 33333337)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("heap99") || hit.collider.gameObject.name.Equals("cup9"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {

                            heap99.SetActive(false);
                            cup9.SetActive(false);

                            heap88.SetActive(true);
                            cup8.SetActive(true);

                            text.SetActive(false);

                            
                        }
                    }
                }
            }

            #endregion

        }

    }






















    bool IsCouldUse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;


        if(Physics.Raycast(ray, out hit, 15))
        {
               
            return true;
        }
        
        return false;
    }




    public void Step()
    {
        even = false;
        InputManager.isStopedController = false;
        //Time.timeScale = 1f;
        timer = 6;
        
        step_count = 7 + num;
    }

    public void Again()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
