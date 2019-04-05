using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       //UI関係を動かす準備
using System.Collections;   //コルーチン処理を動かす準備

public class DamejiScript : MonoBehaviour {

    public int PlayerD;
    public int EnemyD;

    public int PlayerSoldier;
    public int EnemySoldier;

    public GameObject EnemyDamage;
    public GameObject PlayerDamage;
    public Text PlayerDamageText;
    public Text EnemyDamageText;





    /*
     * ここではダメージ処理の動きをテストで導入するスクリプトです
     * まずは味方と敵の残存兵力を表示する
     * そしてその値をダメージの値を表示する
     * 
     * 
     */


    // Use this for initialization
    void Start () {
        PlayerD = 100;
        EnemyD = 100;

        PlayerDamageText.text = PlayerD + "";
        EnemyDamageText.text = EnemyD + "";

        PlayerSoldier = 1000;



        StartCoroutine("TestCoroutine");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Damage(){

    }

    private IEnumerator TestCoroutine() {

        yield return new WaitForSeconds(1); //1秒待つ

        iTween.MoveBy(EnemyDamage, iTween.Hash("x", -600f));    //iTweenを用いてx座標を-600動かす
        iTween.MoveBy(PlayerDamage, iTween.Hash("x", +600f));    //iTweenを用いてx座標を+600動かす

        yield return new WaitForSeconds(2); //2秒待つ

        EnemyD -= 50;
        PlayerD -= 10;

        PlayerDamageText.text = PlayerD + "";
        EnemyDamageText.text = EnemyD + "";


    }




}


/*
 *for (int i=0;i<10;i++) {
            EnemyDamage.transform.position += new Vector3(-60.0f, 0.0f, 0.0f); //オブジェクトが動く

            yield return new WaitForSeconds(0.1f); //3秒待つ
        }
  */
