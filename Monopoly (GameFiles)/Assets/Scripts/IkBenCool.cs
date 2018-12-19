using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IkBenCool : MonoBehaviour {

    public int KillerSteps;
    private int Killerdice;

    // Use this for initialization
    void Start () {
        Actions actions = GetComponent<Actions>();
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }
	
	// Update is called once per frame
	void Update () {

        if (Input)




        if (Input.GetKeyDown("space"))
        {
            print("test1");
            int KillerSteps = Random.Range(2, 12);
            for (int i = KillerSteps; i > 0; i--)
            {
                print(transform.position.z);
                if (transform.position.z > -45 && transform.position.x == 55)
                {
                    transform.Translate(0, 0, -10);
                }
                else if (transform.position.z == -45 && transform.position.x > -45)
                {
                    print("test2");
                    transform.Translate(-10, 0, 0);
                }
                else if (transform.position.z < 55 && transform.position.x == -45)
                {
                    transform.Translate(0, 0, 10);
                }
                else if (transform.position.z == 55 && transform.position.x < 55)
                {
                    transform.Translate(10, 0, 0);
                }
            }
        }
    }
}
