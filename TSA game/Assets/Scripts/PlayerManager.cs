using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public class PlayerInfo{
        private const float HEALTH_MAX = 5.0f;
        private const float SHIELD_MAX = 5.0f;

        public string playerId;

        private float health = 5.0f;
        private float shield = 5.0f;

        public PlayerInfo(string playerId){
            this.playerId = playerId;
        }

        public void setHealth(float health_){
            if(health_ <= HEALTH_MAX) this.health = health_;
        }
        public float getHealth(){
            return this.health;
        }

        public void setShield(float shield_){
            if(shield_ <= SHIELD_MAX) this.shield = shield_;
        }
        public float getShield(){
            return this.shield;
        }
    }

    private PlayerInfo player1 = new PlayerInfo("Player 1");
    private PlayerInfo player2 = new PlayerInfo("Player 2");
    private PlayerInfo player3 = new PlayerInfo("Player 2");
    private PlayerInfo player4 = new PlayerInfo("Player 3");

    public GameObject UI;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
