using System.Collections.Generic;
using UnityEngine;

public class PlatfronManager : MonoBehaviour
{
    [System.Serializable]
    public class Data
    {
        public int GroupCount;
    }
    [SerializeField] private Data[] DtatArr; //데이터 배열

    [SerializeField] private Transform SpawnPos; //생성 좌표

    [SerializeField] private Platform[] LargePlatformsArr; //L
    [SerializeField] private Platform[] MiddiePlatformsArr; //M
    [SerializeField] private Platform[] SmallPlatformsArr; //S
    private int platformNumber = 0;

    Dictionary<int, Platform[]> PlatFormArrDic = new Dictionary<int, Platform[]>();
    internal void init()
    {
        PlatFormArrDic.Add(0, SmallPlatformsArr); //L
        PlatFormArrDic.Add(1, MiddiePlatformsArr); //M
        PlatFormArrDic.Add(2, LargePlatformsArr); //S
    }

    internal void Active()
    {
        Vector3 pos = SpawnPos.position;
        int platformGroupSum = 0;
        foreach (Data data in DtatArr)
        {
            platformGroupSum += data.GroupCount;
            while (platformNumber < platformGroupSum)
            {
                pos = ActiveOne(pos);
                platformNumber++;
            }
        }
    }

    private Vector3 ActiveOne(Vector3 pos)
    {
        Platform[] Platforms = PlatFormArrDic[2]; //로컬 지정, L플랫폼 중 불러오기

        int randID = Random.Range(0, Platforms.Length);
        Platform Randomplatform = Platforms[randID];

        Debug.Log("ActiveOne-Pos : " + pos);
        Platform platform1 = Instantiate(Randomplatform); //로컬 지정
        Randomplatform.Active(pos); //스폰 위치 불러오기

        pos += Vector3.right * 6; //플랫폼 위치를 이동
        return pos; //값을 돌리기
    }
}
