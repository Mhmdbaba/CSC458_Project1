using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{

    public float maxHealth = 100;
    public healthBar healthbar;
    [SerializeField]
    private float currHealth;

    public bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {

        currHealth = maxHealth;
        
    }

    void Update(){
        CheckHealth();

        if (isDead){
            Application.Quit();
        }
    }

    // Update is called once per frame
    public void takeDamage(float damage){

        currHealth -= damage;
        Debug.Log(currHealth);
        healthbar.updateHealth(currHealth / maxHealth); 

        

    }

    public void CheckHealth(){
        if (currHealth >= maxHealth){
            currHealth = maxHealth;
        }
        if (currHealth <= 0){
            currHealth = 0;
            isDead = true;
        }
    }
}
