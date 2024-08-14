using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player Player;
    [SerializeField] private PlatfronManager PlatfronManager;
    

    private void Awake()
    {
        Player.init(); //플레이어 메소드
        PlatfronManager.init(); //플랫폼 메소드
    }

    private void Start()
    {
        PlatfronManager.Active();
    }
}
