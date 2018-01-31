using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara : MonoBehaviour
{
	private HeadLookController _headLookController;

	private void Awake()
	{
		_headLookController = GetComponent<HeadLookController>();
	}

	private void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.CompareTag("Player"))
		{
			LookAt(collider.transform);
		}
	}

	private void LookAt(Transform target)
	{
		Debug.Log("LookAt");
		_headLookController.lookTarget = target;
	}
}
