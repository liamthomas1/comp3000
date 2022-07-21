//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Target that sends events when hit by an arrow
//
//=============================================================================

using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.UI;

namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	public class ArcheryTarget : MonoBehaviour
	{
		public UnityEvent onTakeDamage;

		public bool onceOnly = false;
		public Transform targetCenter;

		public Transform baseTransform;
		public Transform fallenDownTransform;
		public float fallTime = 0.5f;

		const float targetRadius = 0.25f;

		private bool targetEnabled = true;
		//Liam code
		public Text targethit;
		public int counthit;

		//-------------------------------------------------
		private void ApplyDamage()
		{
			OnDamageTaken();
		}


		//-------------------------------------------------
		private void FireExposure()
		{
			OnDamageTaken();
		}


		//-------------------------------------------------
		private void OnDamageTaken()
		{
			if ( targetEnabled )
			{
				//liam code
				targethit.text = "";
				counthit = counthit + 1;
				targethit.text = counthit.ToString("0");
				//end of liam code
				onTakeDamage.Invoke();
				StartCoroutine( this.FallDown() );

				if ( onceOnly )
				{
					targetEnabled = false;
				}
			}
		}


		//-------------------------------------------------
		private IEnumerator FallDown()
		{
			if ( baseTransform )
			{
				Quaternion startingRot = baseTransform.rotation;

				float startTime = Time.time;
				float rotLerp = 0f;

				while ( rotLerp < 1 )
				{
					rotLerp = Util.RemapNumberClamped( Time.time, startTime, startTime + fallTime, 0f, 1f );
					baseTransform.rotation = Quaternion.Lerp( startingRot, fallenDownTransform.rotation, rotLerp );
					yield return null;
				}
			}

			yield return null;
		}
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.G))
			{
				targethit.text = null;
				counthit = counthit + 1;
				targethit.text = counthit.ToString("0");
			}
		}
	}
}
