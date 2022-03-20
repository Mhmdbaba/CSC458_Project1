using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{

    public float maxHealth = 100;
    public healthBar healthbar;
    private float currHealth;

    public bool isDead =false;

    // Start is called before the first frame update
    void Start()
    {

        currHealth = maxHealth;
        
    }

    // Update is called once per frame
    public void takeDamage(float damage){

        currHealth -= damage;
        healthbar.updateHealth((float) currHealth / (float) maxHealth); 

    }

    public virtual void CheckHealth(){
        if (currHealth >= maxHealth){
            currHealth = maxHealth;
        }
        if (currHealth <= 0){
            currHealth = 0;
            isDead = true;
        }
    }
}
