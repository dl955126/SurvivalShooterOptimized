using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Slider healthSlider;
    public Image damageImage;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);
    public float flashSpeed = 5f;

    [SerializeField] Text text;

    public void UpdateHealthUI(int currentHealth)
    {
        healthSlider.value = currentHealth;
    }

    public void OnDamaged()
    {
        damageImage.color = flashColour;
    }

    public void NotDamaged()
    {
        damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
    }

    public void UpdateScore(int score)
    {
        text.text = "Score: " + score;
    }

}
