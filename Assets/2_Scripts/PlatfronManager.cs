using System.Collections.Generic;
using UnityEngine;

public class PlatfronManager : MonoBehaviour
{
    [SerializeField] private Transform SpawnPos; //생성 좌표

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
        Platform[] Platforms = PlatFormArrDic[2]; //로컬 지정, L플랫폼 중 불러오기

        int randID = Random.Range(0, Platforms.Length);
        Platform Randomplatform = Platforms[randID];

        Platform platform1 = Instantiate(Randomplatform); //로컬 지정
        Randomplatform.Active(SpawnPos.position); //스폰 위치 불러오기
    }
}
