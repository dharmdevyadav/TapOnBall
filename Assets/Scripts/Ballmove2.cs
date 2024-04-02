using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballmove2 : MonoBehaviour
{
  Rigidbody2D rb;
  [SerializeField] float moveSpeed = 0.75f;
  ExitLevel1 ExitLevel;
  void Start()
  {
    ExitLevel = FindObjectOfType<ExitLevel1>();
    rb = GetComponent<Rigidbody2D>();
  }
  public void OnMouseDown()
  {
    ExitLevel.Won();
    Destroy(gameObject);
    
  }
  // Update is called once per frame
  void FixedUpdate()
  {
    Vector2 moveDirection = new Vector2(Random.Range(-1, 2), 0.5f);
    rb.AddForce(moveDirection * moveSpeed, ForceMode2D.Impulse);
  }
}
