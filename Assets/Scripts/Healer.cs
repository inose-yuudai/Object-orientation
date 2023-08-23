using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healer : Friendly
{
    public void AddDamage()
    {
        int damage = Random.Range(0, 11); // 0~10の範囲でダメージを決定
        Debug.Log("healerへのダメージは"+ damage);
        hp -= damage;
        DisplayHpValue(); // HPの表示を更新
    }
    public void AddHP()
    {
        hp += 10;
        DisplayHpValue(); // HPの表示を更新
    }
    public virtual void OnAttack() // overrideを使って基底クラスのメソッドを上書き
    {
        Debug.Log("ヒーラーウーノの攻撃！");

        // gameManagerのOnEnemyDamageを呼び出す
        gameManager.OnEnemyDamage(attackpower);
    }

    public virtual void OnSpSkill() // overrideを使って基底クラスのメソッドを上書き
    {
        Debug.Log("ヒーラーのスキル発動！Playerを回復した");

        // gameManagerのOnPlayerHealを呼び出す
        gameManager.OnPlayerHeal();
    }
}
