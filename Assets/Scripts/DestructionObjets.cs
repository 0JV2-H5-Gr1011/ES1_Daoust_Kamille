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
        // Vérifie si l'objet qui entre en collision a le tag "Bille"
        if (collision.gameObject.CompareTag("Bille")) 
        {
            // Détruit ce cube (l'objet auquel ce script est attaché)
            Destroy(gameObject); 
        }
    }
}
