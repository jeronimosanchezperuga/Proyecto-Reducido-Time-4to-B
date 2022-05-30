using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text txtTime;
    public Text txtTimeFloored;
    public Text txtCountdown;
    int counter;
    public float timeToChange;
    public float waitTime;


    // Start is called before the first frame update
    void Start()
    {
        counter = 3;
        txtCountdown.text = counter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //Acceder al tiempo trasncurrido desde el inicio del juego
        txtTime.text = Time.time.ToString();
        //Redondear el tiempo para obtener solo la parte entera
        txtTimeFloored.text = Mathf.FloorToInt(Time.time).ToString();
        //Cuenta regresiva a partir de cierto tiempo cada cierta cantidad de tiempo
        if (timeToChange < Time.time)
        {
            counter--;
            if (counter > 0)
            {
                txtCountdown.text = counter.ToString();
                timeToChange += waitTime;
            }
            else
            {
                txtCountdown.text = "Go!";
            }           
            
        }
    }
}
