using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class BallShoot:MonoBehaviour {

	public GameObject golfBall;
    private Rigidbody rb;

    public float SquareMagnitude;

    // Use this for initialization
    void Start () 
	{
        rb = golfBall.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Alpha1)) 
		{
            rb.AddForceAtPosition(Vector3.forward*2, Vector3.back, ForceMode.Impulse);
        }
		if (Input.GetKeyDown(KeyCode.Alpha2)) 
		{
            rb.AddForceAtPosition(Vector3.forward*6, Vector3.back, ForceMode.Impulse);
        }
		if (Input.GetKeyDown(KeyCode.Alpha3)) 
		{
            rb.AddForceAtPosition(Vector3.forward * 18, Vector3.back, ForceMode.Impulse);
        }
		if (Input.GetKeyDown(KeyCode.Alpha4)) 
		{
            rb.AddForceAtPosition(Vector3.forward*54, Vector3.back, ForceMode.Impulse);
        }

        SquareMagnitude = rb.velocity.magnitude;

        if (rb.velocity.magnitude < 0.1) 
		{
            // rb.velocity = Vector3.zero;
        }
	}
}
