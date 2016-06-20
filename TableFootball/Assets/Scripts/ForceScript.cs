using UnityEngine;
using System.Collections;

public class ForceScript : MonoBehaviour {

    public GameObject Ball;
    public Rigidbody BallRigid;
    public GameObject TableZone;
    public GameObject Corners;
    public GameObject Field;
    public float Velocity;
    public GameObject Players;
    public float RotationSpeed;
    public float impactforce;
    private Transform newPosition;
    int myint;
	

    //void Awake()
    //{
    //    for (int i = 0; i < 1; i++)
    //    {
    //        Instantiate(Ball, new Vector3(Random.Range(9, 11), Random.Range(4, 6)), Quaternion.identity);
    //    }
        
    //}


	void Start () {
        Ball = GameObject.Find("Ball");
        BallRigid = Ball.GetComponent<Rigidbody>();
        TableZone = GameObject.Find("TableZone");
        Corners = GameObject.Find("Corners");
        Field = GameObject.Find("Field");
       Ball.transform.position = Random.insideUnitSphere+Ball.transform.position+new Vector3(0,0.3f,0);
        RandomWay();
        
    }
	
	
	void Update () {
		
        Velocity = BallRigid.velocity.x;

        
	}
    


    void OnCollisionEnter(Collision col)
    {
		
		Vector3 shootDir = BallRigid.transform.position - col.transform.position; //calculate delta vector
        shootDir.Normalize(); //normalize

		if (col.gameObject.tag =="Players")
        {
            
            BallRigid.AddForce(shootDir*250);

        }
    }
    //void SpawnBall()
    //{
    //    Instantiate(gameObject, Vector3(Random.Range(minY, maxY), Random.Range(minZ, maxZ), Random.Range(minX, maxX)), Quaternion.identity)
    //}

    void RandomWay()
    {
        myint = Random.Range(1, 3);
        if (myint == 1)
        {
            BallRigid.AddForce(0, 0, 0.2f);
        }
        else if (myint == 2)
        {
            BallRigid.AddForce(0, 0, -0.2f);
        }
    }

}
