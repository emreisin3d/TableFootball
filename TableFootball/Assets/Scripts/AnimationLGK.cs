using UnityEngine;
using System.Collections;

public class AnimationLGK : MonoBehaviour {
    public GameObject LeftGoalKeeperBar;
    public float MaxPositionX;
    public float MaxRotationX;
    public float CurrentPositionX;
    public float CurrentRotationX;
    // Use this for initialization
    void Start () {
        LeftGoalKeeperBar= GameObject.Find("LeftGoalKeeperBar");
		CurrentPositionX = LeftGoalKeeperBar.transform.position.x;
		CurrentRotationX = LeftGoalKeeperBar.transform.rotation.x;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.S))
        {
			transform.Translate(0, 0.2f, 0);
            CurrentPositionX += 0.2f;
        }
		else if (Input.GetKey(KeyCode.W))
        {
			transform.Translate(0, -0.2f, 0);
            CurrentPositionX += -0.2f;
        }
		if (Input.GetKey(KeyCode.A))
        {
			transform.Rotate(0, 20f, 0);

        }
		else if (Input.GetKey(KeyCode.D))
        {
			transform.Rotate(0, -20f, 0);
        }

	}
}
