using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBoss : MonoBehaviour
{
    public int hp = 300;
    [SerializeField] Text hpText;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        DisplayHpValue();
    }

    /// <summary>
    /// Bossがダメージを受けた際の処理
    /// </summary>
    public void AddDamage(float power)
    {
        hp -= (int)(Random.Range(0, 21) * power);
        DisplayHpValue();
    }

    /// <summary>
    /// Textへhpの値を反映させるメソッド
    /// </summary>
    void DisplayHpValue()
    {
        hpText.text = "HP: " + hp.ToString();
    }

    /// <summary>
    /// ボスの攻撃処理を記載したメソッド
    /// </summary>
    public void OnAttack()
    {
        Debug.Log("ボスの攻撃！");
        gameManager.OnPlayersDamage();
    }
}
