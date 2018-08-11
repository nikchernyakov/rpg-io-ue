using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpPositionController : MonoBehaviour {

	public float HpTextPositionOffset;
	
	private Transform _target;
	
	public void Init(Transform target)
	{
		_target = target;
	}

	public void UpdatePosition()
	{
		transform.position = _target.transform.position + Vector3.up * HpTextPositionOffset;
	}
}
