using UnityEngine;
using System.Collections;

public class ForceScript : MonoBehaviour {

    public GameObject Ball;
    public Rigidbody BallRigid;
    public GameObject TableZone;
    
	// Use this for initialization
	void Start () {
        Ball = GameObject.Find("Ball");
        BallRigid = Ball.GetComponent<Rigidbody>();
        TableZone = GameObject.Find("TableZone");
        
	}
	
	// Update is called once per frame
	void Update () {
      
        
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject!=TableZone)
        {
            BallRigid.AddForce(0, 0, 300);
        }
        
    }
}
