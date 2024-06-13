using UnityEngine;

public class SPRandomGenerate : MonoBehaviour
{
    public GameObject[] spherePrefabs;
    public GameObject background;
    public float minSpawnTime = 7f;
    public float maxSpawnTime = 12f;

    private float nextSpawnTime;
    private Collider2D backgroundCollider;
    private StageGameManager stageGameManager;

    void Start()
    {
        nextSpawnTime = Time.time + Random.Range(minSpawnTime, maxSpawnTime);
        backgroundCollider = background.GetComponent<Collider2D>();

        stageGameManager = FindObjectOfType<StageGameManager>();
        if (stageGameManager == null)
        {
<<<<<<< Updated upstream
            Debug.LogError("StageGameManager¸¦ Ã£À» ¼ö ¾ø½À´Ï´Ù.");
=======
            Debug.LogError("StageGameManagerï¿½ï¿½ Ã£ï¿½ï¿½ ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½ï¿½Ï´ï¿½.");
>>>>>>> Stashed changes
        }
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnSphere();
            nextSpawnTime = Time.time + Random.Range(minSpawnTime, maxSpawnTime);
        }
    }

    void SpawnSphere()
    {
        Vector2 min = backgroundCollider.bounds.min;
        Vector2 max = backgroundCollider.bounds.max;
        Vector3 randomPosition = new Vector3(Random.Range(min.x, max.x), Random.Range(min.y, max.y), 0f);

        int maxIndex;

<<<<<<< Updated upstream
        // StageClearID¿¡ µû¸¥ ÇÁ¸®ÆÕ ÀÎµ¦½º °áÁ¤
        if (stageGameManager.StageClearID <= 5)
        {
            maxIndex = 1; // Ã¹ ¹øÂ° ÇÁ¸®ÆÕ¸¸ »ç¿ë
        }
        else if (stageGameManager.StageClearID <= 10)
        {
            maxIndex = 2; // Ã¹ ¹øÂ°¿Í µÎ ¹øÂ° ÇÁ¸®ÆÕ »ç¿ë
        }
        else if (stageGameManager.StageClearID <= 15)
        {
            maxIndex = 3; // Ã¹ ¹øÂ°, µÎ ¹øÂ°, ¼¼ ¹øÂ° ÇÁ¸®ÆÕ »ç¿ë
        }
        else
        {
            maxIndex = spherePrefabs.Length; // ¸ðµç ÇÁ¸®ÆÕ »ç¿ë
=======
        if (stageGameManager.StageClearID <= 6)
        {
            return;
        }
        else if (stageGameManager.StageClearID <= 10)
        {
            maxIndex = 0;
        }
        else if (stageGameManager.StageClearID <= 17)
        {
            maxIndex = 1;
        }
        else if (stageGameManager.StageClearID <= 25)
        {
            maxIndex = 2;
        }
        else if (stageGameManager.StageClearID <= 32)
        {
            maxIndex = 3;
        }
        else
        {
            maxIndex = spherePrefabs.Length;
>>>>>>> Stashed changes
        }

        int prefabIndex = Random.Range(0, maxIndex);
        Instantiate(spherePrefabs[prefabIndex], randomPosition, Quaternion.identity);
    }
}