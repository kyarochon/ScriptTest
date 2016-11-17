using UnityEngine;
using System.Collections;


public class Boss {        
	private int hp = 100;	// 体力
	private int power = 25; // 攻撃力
	private int mp = 53;	// 魔法力

	// 攻撃用の関数
	public void Attack()
	{ 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public void Defence(int damage)
	{ 
		Debug.Log( damage + "のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

	// 魔法用の関数
	public void Magic(int requiredMp)
	{
		if (this.mp >= requiredMp)
		{
			// 残りmpを減らす
			this.mp -= requiredMp;
			Debug.Log("魔法攻撃をした。残りMPは" +  this.mp);
		}
		else
		{
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}
}



public class BossTask : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("【発展課題】Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう");

		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		// 攻撃用の関数を呼び出す
		lastboss.Attack();

		// 防御用の関数を呼び出す
		lastboss.Defence(3);

		// 魔法用の関数を11回呼び出す
		for (int i = 0; i < 11; i++)
		{
			lastboss.Magic(5);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
