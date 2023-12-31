﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    /// <summary>
    /// This class toggles the door animation.
    /// The gameobject of this script has to have the DoorController script which needs an Animator component
    /// and some kind of Collider which detects your mouse click applied.
    /// </summary>
    [RequireComponent(typeof(DoorController))]
	public class DoorToggle : MonoBehaviour
    {
        private DoorController doorController; 

        public DoorController getDoorController()
        {
            return this.doorController;
        }

        void Awake()
        {
            doorController = GetComponent<DoorController>();
        }


	    void OnMouseDown()
	    {
	        doorController.ToggleDoor();
	    }

	}
