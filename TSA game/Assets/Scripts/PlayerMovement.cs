using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Movement speed for all players
    public float moveSpeed = 5f;

    // References to all players (set these in the Inspector)
    public Transform player1;
    public Transform player2;
    public Transform player3;
    public Transform player4;

    void Update()
    {
        // Player 1 Movement (WASD)
        Vector3 player1Movement = new Vector3(Input.GetAxis("Horizontal_P1"), Input.GetAxis("Vertical_P1"),0);
        player1.Translate(player1Movement * moveSpeed * Time.deltaTime);

        // Player 2 Movement (Arrow Keys)
        Vector3 player2Movement = new Vector3(Input.GetAxis("Horizontal_P2"), Input.GetAxis("Vertical_P2"),0);
        player2.Translate(player2Movement * moveSpeed * Time.deltaTime);

        // Player 3 Movement (IJKL)
        Vector3 player3Movement = new Vector3(Input.GetAxis("Horizontal_P3"), Input.GetAxis("Vertical_P3"),0);
        player3.Translate(player3Movement * moveSpeed * Time.deltaTime);

        // Player 4 Movement (Numpad 8, 4, 5, 6)
        Vector3 player4Movement = new Vector3(Input.GetAxis("Horizontal_P4"), Input.GetAxis("Vertical_P4"),0);
        player4.Translate(player4Movement * moveSpeed * Time.deltaTime);
    }
}
