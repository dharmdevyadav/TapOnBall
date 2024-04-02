using UnityEngine;

public class BallMoment : MonoBehaviour
{
  Rigidbody2D rb;
  [SerializeField] float moveSpeed =1f;
  NextLevel nextload;
   public void Start()
    {
    rb = GetComponent<Rigidbody2D>();
    nextload=FindObjectOfType<NextLevel>();
    }
  public void OnMouseDown()
  {
    nextload.WonGame();
    Destroy(gameObject);
   
  }
  void FixedUpdate()
    {
    Vector2 moveDirection = new Vector2(Random.Range(-1, 2), 0.5f);
    rb.AddForce(moveDirection * moveSpeed, ForceMode2D.Impulse);
    }
}
