using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollisionCube : MonoBehaviour {
    public static int score = 0;
    public static int ScoreCubes = 0;
    public static int ScoreSpheres = 0;
    public bool esteCub;
    public bool esteSfera;
    public Text textScoreCubes;
    public Text textScoreSpheres;
	// Use this for initialization
	void Start () {
	
	}
    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.name == "Car")
        {
            Debug.Log("Picked up cube.");
            GameObject.Destroy(this.gameObject);
            score++;
            if (esteCub)
            {
                ScoreCubes++;
                textScoreCubes.text = "Cubes: " + ScoreCubes;
            }
            if (esteSfera)
            {
                ScoreSpheres++;
                textScoreSpheres.text = "Spheres: " + ScoreSpheres;
            }
        }

    }

    // Update is called once per frame
    void Update () {
        
	
	}
}
