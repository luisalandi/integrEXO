using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Leap;
using Leap.Unity;

public class SeguiPalm : MonoBehaviour
{

    // Variabili per gestire la posizione e la direzione della mano Leap Motion
    public LeapServiceProvider leapProvider;
    Vector3 handPosition;
    Vector3 handDirection;


    void Update()
    {
        // Funzione per ottenere i dati della mano Leap Motion

        GetLeapHandData();
        transform.position = handPosition;
        //transform.eulerAngles = handDirection;
        
    }

    // Metodo per ottenere i dati della mano Leap Motion
    void GetLeapHandData()
    {
        // Si verifica che il LeapProvider (Nel nostro caso LeapServiceProvider) sia stato assegnato

        if (leapProvider != null)
        {
            // Si ottiene il frame corrente

            Frame frame = leapProvider.CurrentFrame;
            
            // Se almeno una mano è rilevata nel frame
            if (frame.Hands.Count > 0)
            {

                

                Hand hand = frame.Hands[0];
                handPosition = hand.PalmPosition;
                Debug.Log(handPosition);
                
                
            }
            else
            {
                Debug.LogWarning("Nessuna mano rilevata nel frame");
            }
        }
        else
        {

            Debug.LogError("LeapProvider non assegnato");
        }
    }
}