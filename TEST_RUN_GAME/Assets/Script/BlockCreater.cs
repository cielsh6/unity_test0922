using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCreater : MonoBehaviour {

	void Start ()
	{
		
	}
	
	void Update ()
	{
		if(_createInterval <= _createDuration)
		{
			_createDuration = 0.0f;
			CreateBlock();
		}
		_createDuration += Time.deltaTime;
	}

	float _createInterval = 2.0f;
	float _createDuration = 0.0f;

	public GameObject BlockPrefab;
	public float BlockSpeed = 5.0f;
	
	void CreateBlock()
	{
		//프리팹을 이용해서 블럭 게임오브젝트 생성
		GameObject Block = GameObject.Instantiate(BlockPrefab);

		//블럭의 위치를 지정
		Block.transform.position = transform.position;

		//블럭의 속도 적용
		Block.GetComponent<Block>().SetSpeed(BlockSpeed);

		//만들어진 블럭 파괴
		GameObject.Destroy(Block, 6.0f);
	}
}
