using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHeightAdjust : MonoBehaviour {


		

		private float height;
		

		private void Start()
		{
			height = transform.localPosition.y;
			
		}

		private void Update()
	{

			if (transform.localPosition.y > height)
			{
				Vector3 position = transform.localPosition;
				position.y = height;
				transform.localPosition = position;
			}
		}
	}

