namespace VRTK.GrabAttachMechanics
{
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public class FlashlightMechanics : VRTK_InteractableObject 
	{
	   	public AudioSource source;
	   	public AudioClip toggleSound;
	    public AudioClip insert;
	   	public Light myLight;
	    public GameObject Flashlight;
	    private float batteryLifeInSeconds = 1f;
	   	private float batteryLife;
	   	private bool isActive;
	    private bool inventory = false;
	    private FixedJoint joint;
	   	private VRTK_ControllerReference controllerReference;
	
		// Use this for initialization
		void Start () 
		{
		source = GetComponent<AudioSource>();
		batteryLife = myLight.intensity;
		}
		
		// Update is called once per frame
		void Update () 
		{
			if (isActive == true)
			{
			myLight.intensity -= batteryLife / batteryLifeInSeconds * Time.deltaTime;
			}
		}
	
	    void OnTriggerEnter (Collider other)
	    {
	        if(other.CompareTag("Battery"))
	        {
	        AddBatteryLife(1);
	        source.PlayOneShot (insert, 4f);
	        }
	    }
	
		void Haptic () 
		{
	    VRTK_ControllerHaptics.TriggerHapticPulse(controllerReference, 1f, 1f, 220f);
		}
	
	    public void AddBatteryLife(float _batteryPower)
	    {
	    	myLight.intensity += _batteryPower;
	    	if (myLight.intensity > batteryLifeInSeconds)
	    	{
	    	myLight.intensity = batteryLifeInSeconds;
	    	}
	    }
	
	    // public override void Grabbed(VRTK_InteractGrab grabbingObject)
	    // {
	    //     base.Grabbed(grabbingObject);
	    //     controllerReference = VRTK_ControllerReference.GetControllerReference(grabbingObject.controllerEvents.gameObject);
	    //     Destroy(joint);    
	    // }
	
	    [AddComponentMenu("VRTK/Scripts/Interactions/Interactables/Grab Attach Mechanics/VRTK_FixedJointGrabAttach")]
	    public class VRTK_FixedJointGrabAttach : VRTK_BaseJointGrabAttach
	    {
	        [Tooltip("Maximum force the Joint can withstand before breaking. Setting to `infinity` ensures the Joint is unbreakable.")]
	        public float breakForce = 1500f;
	
	        protected override void CreateJoint(GameObject obj)
	        {
	        givenJoint = obj.AddComponent<FixedJoint>();
	        givenJoint.breakForce = (grabbedObjectScript.IsDroppable() ? breakForce : Mathf.Infinity);
	        base.CreateJoint(obj);
	        }
	    }

		public override void StartUsing(VRTK_InteractUse usingObject)
	    {
	    	Haptic();
	    	source.PlayOneShot(toggleSound, 1f);
	    	if (source != null)
	    	{
	    	source.PlayOneShot(toggleSound, 1f);
	    	}
	    	if (batteryLifeInSeconds > 1)
	    	{
	    	myLight.enabled = true;
	    	isActive = true;
	    	}
	    	if (batteryLifeInSeconds == 0)
	    	{
	    	myLight.enabled = false;
	    	}
	    }
	    
	    // public override void StopUsing(VRTK_InteractUse usingObject)
	    // {
	    // 	Haptic();
	    // 	source.PlayOneShot(toggleSound, 1f);
	    //  base.StopUsing(usingObject);
	    //  myLight.enabled = false;
	    //  isActive = false;
	    // }
	
	}
}