using System.Collections.Generic;
using UnityEngine;

public class PlatfronManager : MonoBehaviour
{
    [SerializeField] private Transform SpawnPos; //���� ��ǥ

    [SerializeField] private Platform[] LargePlatformsArr; //L
    [SerializeField] private Platform[] MiddiePlatformsArr; //M
    [SerializeField] private Platform[] SmallPlatformsArr; //S

    Dictionary<int, Platform[]> PlatFormArrDic = new Dictionary<int, Platform[]>();
    internal void init()
    {
        PlatFormArrDic.Add(0, SmallPlatformsArr); //L
        PlatFormArrDic.Add(1, MiddiePlatformsArr); //M
        PlatFormArrDic.Add(2, LargePlatformsArr); //S
    }
    internal void Active()
    {
        Platform[] Platforms = PlatFormArrDic[2]; //���� ����, L�÷��� �� �ҷ�����

        int randID = Random.Range(0, Platforms.Length);
        Platform Randomplatform = Platforms[randID];

        Platform platform1 = Instantiate(Randomplatform); //���� ����
        Randomplatform.Active(SpawnPos.position); //���� ��ġ �ҷ�����
    }
}
