using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Sprite healthStage1, healthStage2, healthStage3, healthStage4;
    public Image healthBarIMG;

    private void Start()
    {
        healthBarIMG = GetComponent<Image>();
        ChangeHealthBarStage();
    }

    public void Damage(double damage) 
    {
        if ((Health.totalHealth -= damage) >= 0)
        {
            Health.totalHealth -= damage;
        }
        else
        {
            Health.totalHealth = 0; 
        }
        ChangeHealthBarStage();
    }

    public void Heal(double heal) 
    {
        if ((Health.totalHealth += heal) < 100)
        {
            Health.totalHealth += heal;
        }
        else
        {
            Health.totalHealth = 100;
        }
        ChangeHealthBarStage();
    }

    public void ChangeHealthBarStage()
    {
        if (Health.totalHealth >= 100)
        {
            healthBarIMG.sprite = healthStage1;
        }
        if (Health.totalHealth <= 75)
        {
            healthBarIMG.sprite = healthStage2;
        }
        if (Health.totalHealth <= 50)
        {
            healthBarIMG.sprite = healthStage3;
        }
        if (Health.totalHealth <= 25    )
        {
            healthBarIMG.sprite = healthStage4;
        }
    }

}
