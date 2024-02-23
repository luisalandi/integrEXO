using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sinergia : MonoBehaviour
{
    public float RotazioneIniziale = 0;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //transform.eulerAngles = new Vector3(RotazioneIniziale, 0, 0);

        GameObject falange1 = GameObject.Find("perno1");
        Transform falangeposa1 = falange1.transform;
        falangeposa1.eulerAngles = new Vector3(RotazioneIniziale * 1.5f, 0, 0);

        GameObject falange2 = GameObject.Find("perno2");
        Transform falangeposa2 = falange2.transform;
        falangeposa2.eulerAngles = new Vector3(RotazioneIniziale * 2.5f, 0, 0);

        GameObject falange3 = GameObject.Find("perno3");
        Transform falangeposa3 = falange3.transform;
        falangeposa3.eulerAngles = new Vector3(RotazioneIniziale * 5f, 0, 0);
    }

}
