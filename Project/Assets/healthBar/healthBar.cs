using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class healthBar : MonoBehaviour
{
    public Image healthbar;

    public void updateHealth(float fraction){

        healthbar.fillAmount = fraction;

    }
}
