using UnityEngine;
using System.Collections;

public class ArrayTask : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("【課題】配列を宣言して出力しましょう");
		int[] array = {50, 20, 40, 10, 30};
		outputInOrder (array);
		outputInReverseOrder (array);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void outputInOrder(int[] array)
	{
		Debug.Log ("順番に表示");
		for (int i = 0; i < array.Length; i++)
		{
			Debug.Log (array [i]);
		}
	}

	void outputInReverseOrder(int[] array)
	{
		Debug.Log ("逆順に表示");
		for (int i = array.Length - 1; i >= 0; i--)
		{
			Debug.Log (array [i]);
		}
	}

}
