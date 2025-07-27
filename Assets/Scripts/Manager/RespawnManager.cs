using System.Collections.Generic;
using DataDeclaration;
using UnityEngine;

public class RespawnManager : MonoSingleton<RespawnManager>
{
    private Queue<Monster> pool;

    private float respawnTime;
    private float respawnTimer;

    [SerializeField] private List<Rect> spawnAreaList;

    protected override void Awake()
    {
        base.Awake();
        isDontDestroyOnLoad = false;

        InitPool();
        respawnTime = 5f;
    }

    private void Update()
    {
        Respawn();
    }

    private void InitPool()
    {
        pool = new Queue<Monster>();
        var monsterList = Resources.LoadAll<MonsterSO>("Data/SO/Monster");
        foreach (var monster in monsterList)
        {
            var prefab = Resources.Load<Monster>($"Prefabs/Character/{monster.MonsterID}");
            for (int i = 0; i < Constants.MONSTER_AMOUNT; i++)
            {
                Monster mon = Instantiate(prefab, transform);
                mon.gameObject.SetActive(false);
                pool.Enqueue(mon);
            }
        }
    }

    private void Respawn()
    {
        if (pool.Count == 0)
        {
            return;
        }
        
        Rect randomArea = spawnAreaList[Random.Range(0, spawnAreaList.Count)];
        Vector2 randomPosition = new Vector2(
            Random.Range(randomArea.xMin, randomArea.xMax),
            Random.Range(randomArea.yMin, randomArea.yMax)
        );
        

        respawnTimer += Time.deltaTime;
        if (respawnTimer >= respawnTime)
        {
            Monster monster = pool.Dequeue();
            monster.transform.position = randomPosition;
            monster.gameObject.SetActive(true);
            respawnTimer = 0f;
        }
    }
    
    private void OnDrawGizmosSelected()
    {
        if (spawnAreaList == null)
            return;

        Gizmos.color = new Color(1, 0, 0, 0.3f);
        foreach (var area in spawnAreaList)
        {
            Vector3 center = new Vector3(area.x + area.width / 2, area.y + area.height / 2);
            Vector3 size = new Vector3(area.width, area.height);
            Gizmos.DrawCube(center, size);
        }
    }
}