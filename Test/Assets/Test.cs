using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Test : MonoBehaviour
{
	[Serializable]
	public class SpawnPoint
	{
		public int Id;
		public Vector3 Position;
		public int[] Nodes;

		public SpawnPoint (int id, Vector3 position)
		{
			Id = id;
			Position = position;
		}
	}

	[SerializeField] private SpawnPoint m_SpawnPoint;

	private void Start ()
	{
		m_SpawnPoint = new SpawnPoint (1, new Vector3 (1.1f, 1.0f, 2.3f));
	}
}
