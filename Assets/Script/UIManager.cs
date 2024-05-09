using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{

    public SpriteRenderer ballSprite;
    public Sprite[] spritesChoice;
    public GameManager gameManager;
    public TextMeshProUGUI scoreText;
    [SerializeField] GameObject loseScreen;
    [SerializeField] GameObject ballSelectionScreen;
    public int current = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ScoreText();


    }
    void ScoreText()
    {
        scoreText.text = gameManager.score.ToString();
    }
    public void LoseScreen()
    {
        loseScreen.SetActive(true);
        Color startColor = new Color(255, 255, 255, 22);
        Color endColor = new Color(255, 255, 255, 255);
        scoreText.color = Color.Lerp(startColor, endColor, 500);
    }
    public void OnMouseDownRight()
    {
        Debug.Log("s");
        current++;
        if (current >= spritesChoice.Length)
        {
            current = 0; // Listenin başındaki sprite'a git

        } // Listenin sonuna ulaşıldığında


        ballSprite.sprite = spritesChoice[current]; // Yeni sprite'ı göster
    }
    public void OnMouseDownLeft()
    {

        current--;
        if (current < 0)
        {
            current = 3; // Listenin başındaki sprite'a git

        } // Listenin sonuna ulaşıldığında

        ballSprite.sprite = spritesChoice[current]; // Yeni sprite'ı göster
    }
    public void BallSelectionClose()
    {
        ballSelectionScreen.SetActive(false);
    }
    public void BallSelectionScreenOpen()
    {
        ballSelectionScreen.SetActive(true);
    }

}
