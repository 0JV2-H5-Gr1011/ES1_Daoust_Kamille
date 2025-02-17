using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemarrerParcours : MonoBehaviour
{

    [SerializeField] private GameObject _PlataformeInitiale;


    //  [SerializeField] private GameObject _Bille;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

   
        
    }

    public void DebutGlissade()
    {
        Destroy(_PlataformeInitiale);

    }


   
}



