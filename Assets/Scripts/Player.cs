using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Friendly
{
    public void AddHP()
    {
        hp += 10;
        DisplayHpValue(); // HPの表示を更新
    }

    public void AddDamage()
    {
        int damage = Random.Range(0, 21);
        Debug.Log("Playerへのダメージは" + damage);
        hp -= damage;
        DisplayHpValue(); // HPの表示を更新
    }

    public virtual void OnAttack()
    {
        Debug.Log("Playerテク子の攻撃！");

        // gameManagerのOnEnemyDamageを呼び出す
        gameManager.OnEnemyDamage(attackpower);
    }

    public void OnSpSkill()
    {
        Debug.Log("Playerのスキル発動！Enemyへ二倍攻撃！");

        // gameManagerのOnEnemyDamageを呼び出す（攻撃力の二倍）
        gameManager.OnEnemyDamage(attackpower * 2);
    }
}