using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // ��_��,, 
    public GameObject[] wallPrefab;
    public GameObject dropPrefab;
    public float interval = 1.5f; // 1.5�� ����
    public float range = 3;
    float term;
    /*float random;
    Vector3 randomposition;
    Vector3 startPos;*/

    // Start is called before the first frame update
    void Start()
    {
        term = interval; // ���ۺ��� ���� ������ �ϱ� ����
    }

    // Update is called once per frame 
    void Update()
    {
        term += Time.deltaTime;
        if (term >= interval)
        {
            /*random = Random.Range(-2, 2);
            randomposition.x += 4;
            randomposition.y += random;*/
            Vector3 pos = transform.position;
            pos.y += Random.Range(-range, range);
            int wallType = Random.Range(0, wallPrefab.Length);
            Instantiate(wallPrefab[wallType], pos, transform.rotation);
            
            if (Random.Range(0,2) == 0) // 50% Ȯ����
            {
                Instantiate(dropPrefab); // �������� ��ֹ� ����
            }
            term -= interval;
        }
        //randomposition = startPos;
    }
}
