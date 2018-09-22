using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

	void Start()
	{
		ChangeState(eState.IDLE);
	}

	void Update()
	{

	}

	public enum eState
	{
		IDLE,
		RUN,
	}

	void ChangeState(eState state)
	{
		switch(state)
		{
			case eState.IDLE:
				GetAnimator().SetTrigger("Idle");
				break;
			case eState.RUN:
				GetAnimator().SetTrigger("Run");
				break;

		}
	}

	Animator GetAnimator()
	{
		return gameObject.GetComponent<Animator>();
	}
}
