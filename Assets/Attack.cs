using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Transform attackPos;
    public LayerMask enemies;
    public float attackrange;
    public int damage;
    private Animator anim;
    private int wechsel;
    private bool mobile_attack = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        wechsel = PlayerPrefs.GetInt("wechsel", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1) || mobile_attack == true) 
        {
            mobile_attack = false;
            if(wechsel == 1)
            {
                anim.SetBool("IsAttacking_iron", true);
            }
            if(wechsel == 2)
            {
                anim.SetBool("IsAttacking_dia", true);
            }
            if(wechsel == 3)
            {
                anim.SetBool("IsAttacking_black", true);
            }
            if(wechsel == 1)
            {
                anim.SetBool("IsAttacking", true);
            }

            FindObjectOfType<AudioManager>().Play("Sword");
            Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackrange, enemies);
            for(int i = 0; i< enemiesToDamage.Length; i++) 
            {
                enemiesToDamage[i].GetComponent<Enemy>().health -= damage;
            }
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackrange);
    }
    public void attack()
    {
        mobile_attack = true;
    }
}
