
using UnityEngine;
using System.Collections;

[RequireComponent(typeof (CharacterController))]
public class playerMovement : MonoBehaviour
	
{
	private Vector3 movementVector;
	private CharacterController controller;
	private float movementSpeed = 8;
	private float jumpPower = 15;
	private float gravity = 50;
	public float speed;

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	private float nextFire;
	private Quaternion targetRotation;
	public float rotationSpeed = 360;



	void Start()
	{
		controller = GetComponent<CharacterController>();
	}
	
	
	void Update()
	{

//This can be changed to change movement speed
		Vector3 input = new Vector3(Input.GetAxis ("Horizontal")*speed, 0, Input.GetAxisRaw ("Vertical")*speed);
	//	transform.rotation = Quaternion.LookRotation(input);

		if (input != Vector3.zero){
			targetRotation = Quaternion.LookRotation(input);
			transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle(transform.eulerAngles.y,targetRotation.eulerAngles.y,rotationSpeed*Time.deltaTime);
		}


		Vector3 motion = input;
		input *= (Mathf.Abs (input.x) == 1 && Mathf.Abs (input.z) == 1) ? .7f : 5;
		 
		motion += Vector3.up * -8;
		controller.Move(motion * Time.deltaTime);

		
	

//				if(controller.isGrounded)
//		{
//			movementVector.y = 0;
//			
//			if(Input.GetButtonDown("A"))
//			{
//				movementVector.y = jumpPower;
//				nextFire = Time.time + fireRate;
//				Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
//			}
//		}
		
	
//		movementVector.y -= gravity * Time.deltaTime;
		
//		characterController.Move(movementVector * Time.deltaTime);

	}
	
}
