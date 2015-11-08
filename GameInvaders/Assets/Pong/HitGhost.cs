using UnityEngine;
using System.Collections;

public class HitGhost : MonoBehaviour
{
    public static int TotalNumberOfGhosts; 
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.name == "pacman")
        {
            TotalNumberOfGhosts = TotalNumberOfGhosts - 1;
            if(TotalNumberOfGhosts == 0)
            {
                Application.LoadLevel("TheCar");
            }
            Debug.Log("Collider");
            GameObject.Destroy(this.gameObject);
        }
        
    }
}