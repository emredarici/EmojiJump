using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BallMove : MonoBehaviour
{
  private SpriteRenderer spriteRenderer;
  [SerializeField] SpriteRenderer ballChooseSpriteRD;
  public GameManager gameManager;
  public UIManager uIManager;
  public float ballSpeed;
  private int Beat = 1;
  private Rigidbody2D Ballrb;

  void Awake()
  {

  }
  void Start()
  {
    SceneManager.sceneLoaded += sceneReload;
    DontDestroyOnLoad(this.gameObject);
    Ballrb = GetComponent<Rigidbody2D>();
    spriteRenderer = GetComponent<SpriteRenderer>();
    BallForce();
  }
  void Update()
  {
    spriteRenderer.sprite = ballChooseSpriteRD.sprite;

  }
  private void BallForce()
  {
    Ballrb.AddForce(Vector2.down * ballSpeed);
  }

  void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.CompareTag("Platform"))
    {
      Ballrb.AddForce(Vector2.up * Beat);
      Beat += 2;
      gameManager.score++;
      Debug.Log(gameManager.score);
    }
    if (collision.gameObject.CompareTag("RedLine"))
    {
      Destroy(this.gameObject);
      uIManager.LoseScreen();
    }
  }
  public void sceneReload(Scene scene, LoadSceneMode mode)
  {
    gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    uIManager = GameObject.Find("Canvas").GetComponent<UIManager>();
    this.transform.position = new Vector3(0, 0, 0);
  }
}
