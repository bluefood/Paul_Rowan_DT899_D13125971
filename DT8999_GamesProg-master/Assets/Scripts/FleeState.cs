using UnityEngine;
using System.Collections;

public class FleeState : State {
	
	public float changeStateTime, changeStateTimer = 5f; //A very simple change state condition!
	GameObject leader; //a reference to the leader we want to chase!
	
	public FleeState(GameObject myGameObject):base (myGameObject) //constructor that needs the same argument as the State base class constructor. use :base(GameObject) to inherit the same myGameObject reference, so this class can access the gameobject it's refereing to
	{
		
	}
	public override void Enter() //override runs over the base class abstract method of the same name (abstract methods can't handle functionality, they are only a blueprint)
	{
		if(myGameObject.GetComponent<SteeringBehaviours>().target == null) //if this boid hasn't already got a target (leader)
		{
			leader = GameObject.Find ("Leader"); //then find the leader in the scene
			myGameObject.GetComponent<SteeringBehaviours>().target = leader; //assign the leader to the target 
		}
		//This is where you toggle the steering behaviours ON!
		myGameObject.GetComponent<SteeringBehaviours>().fleeEnabled = true;
		myGameObject.GetComponent<SteeringBehaviours>().seperationEnabled = true;
		myGameObject.GetComponent<SteeringBehaviours>().cohesionEnabled = false;
		myGameObject.GetComponent<SteeringBehaviours>().alignmentEnabled = true;
		Debug.Log("Boids are fleeing");
	}
	
	public override void Update() //override runs over the base class abstract method of the same name (abstract methods can't handle functionality, they are only a blueprint)
	{
		//This is where we calculate stuff, like the condition to transition to the next state
		//changeStateTime += Time.deltaTime;
		if(Vector3.Distance(myGameObject.transform.position,myGameObject.GetComponent<SteeringBehaviours>().target.transform.position) >= 200f)
		{
//			if(myGameObject.GetComponent<Rigidbody>()!=null)
//			{
//			myGameObject.GetComponent<Rigidbody>().useGravity=false;
//			}
			Debug.Log("Switch Flee to Chase");
			myGameObject.GetComponent<StateMachine>().SwitchState (new ChaseState(myGameObject));
		}	
	}
	
	public override void Exit() //override runs over the base class abstract method of the same name (abstract methods can't handle functionality, they are only a blueprint)
	{
		//this is where we turn off all steering behaviours, as the new state we transition to will enable only the ones it needs
		myGameObject.GetComponent<SteeringBehaviours>().TurnOffAll();
	}
}
