using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Transform player1;
    public Transform player2;
    public Transform player3;
    public Transform player4;

    void Update()
    {
  
        Vector3 player1Movement = new Vector3(Input.GetAxis("Horizontal_P1"), Input.GetAxis("Vertical_P1"),0);
        player1.Translate(player1Movement * moveSpeed * Time.deltaTime);

    
        Vector3 player2Movement = new Vector3(Input.GetAxis("Horizontal_P2"), Input.GetAxis("Vertical_P2"),0);
        player2.Translate(player2Movement * moveSpeed * Time.deltaTime);


        Vector3 player3Movement = new Vector3(Input.GetAxis("Horizontal_P3"), Input.GetAxis("Vertical_P3"),0);
        player3.Translate(player3Movement * moveSpeed * Time.deltaTime);

    
        Vector3 player4Movement = new Vector3(Input.GetAxis("Horizontal_P4"), Input.GetAxis("Vertical_P4"),0);
        player4.Translate(player4Movement * moveSpeed * Time.deltaTime);
    }
}
