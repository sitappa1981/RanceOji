using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       //UI関係を動かす準備
using System.Collections;   //コルーチン処理を動かす準備

public class DamejiScript : MonoBehaviour {

    public int PlayerD;
    public GameObject EnemyDamage;
    public GameObject PlayerDamage;



    /*
     * ここではダメージ処理の動きをテストで導入するスクリプトです
     * まずは味方と敵の残存兵力を表示する
     * そしてその値をダメージの値を表示する
     * 
     * 
     */


    // Use this for initialization
    void Start () {
        StartCoroutine("TestCoroutine");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Damage(){

    }

    private IEnumerator TestCoroutine() {

        yield return new WaitForSeconds(3); //3秒待つ

        for (int i=0;i<10;i++) {
            EnemyDamage.transform.position += new Vector3(-60.0f, 0.0f, 0.0f); //オブジェクトが動く

            yield return new WaitForSeconds(0.1f); //3秒待つ
        }



    }




}
