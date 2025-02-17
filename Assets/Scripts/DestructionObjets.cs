using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionObjets : MonoBehaviour
{

    [SerializeField] private GameObject _Portail;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("Bille")) 
        {
            Destroy(gameObject); 
        }
    }


}
