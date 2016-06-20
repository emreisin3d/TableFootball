using UnityEngine;
using System.Collections;

public class AnimationRGK : MonoBehaviour {
    public GameObject RightGoalKeeperBar;
    public float MaxPositionX;
    public float CurrentPositionX;
    public float CurrentRotationX;
    // Use this for initialization
    void Start () {
        RightGoalKeeperBar= GameObject.Find("RightGoalKeeperBar");
        CurrentPositionX = RightGoalKeeperBar.transform.position.x;
        CurrentRotationX = RightGoalKeeperBar.transform.rotation.x;

	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if (Input.GetKey(KeyCode.DownArrow)&&CurrentPositionX< 6.6f)
			{
				

			transform.Translate(0, 0.2f, 0);
			CurrentPositionX += 0.2f;
			}
		else if (Input.GetKey(KeyCode.UpArrow)&& CurrentPositionX> 3.4f)
			{
				

			transform.Translate(0, -0.2f, 0);
			CurrentPositionX += -0.2f;
			}


        if (Input.GetKey(KeyCode.LeftArrow))
        {
			transform.Rotate(0, 20f, 0);

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
			transform.Rotate(0, -20f, 0);
        }

	}
}
