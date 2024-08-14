using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player Player;
    [SerializeField] private PlatfronManager PlatfronManager;
    

    private void Awake()
    {
        Player.init(); //�÷��̾� �޼ҵ�
        PlatfronManager.init(); //�÷��� �޼ҵ�
    }

    private void Start()
    {
        PlatfronManager.Active();
    }
}
