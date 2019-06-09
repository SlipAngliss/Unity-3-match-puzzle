using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    /// <summary>
    /// 이차원 배열 보류
    /// </summary>
    //private Tile[,] m_aryTilesArray = new Tile [ 6, 8 ];

    private Dictionary<string, Tile> m_dicTilesDictionary = new Dictionary<string, Tile>();

    private GameObject[] m_TilePrefab;

    //static private Dictionary<string, GameObject> _cache = new Dictionary<string, GameObject>();
    
    public int m_nWidth;
    public int m_nHeight;
    
    void Start()
    {
        //m_TilePrefab = Resources.Load("Prefabs/CandyGreen") as GameObject;
        GameObject TilePrefab1 = Resources.Load("Prefabs/CandyBlue") as GameObject;
        GameObject TilePrefab2 = Resources.Load("Prefabs/CandyGreen") as GameObject;
        GameObject TilePrefab3 = Resources.Load("Prefabs/CandyOrange") as GameObject;
        GameObject TilePrefab4 = Resources.Load("Prefabs/CandyPurple") as GameObject;
        GameObject TilePrefab5 = Resources.Load("Prefabs/CandyRed") as GameObject;
        GameObject TilePrefab6 = Resources.Load("Prefabs/CandyYellow") as GameObject;

        m_TilePrefab = new GameObject[] { TilePrefab1, TilePrefab2, TilePrefab3, TilePrefab4, TilePrefab5, TilePrefab6 };

        // 실험용
        /*Tile tile_0 = Instantiate<Tile>(m_TilePrefab.transform.GetComponent<Tile>());

        tile_0.transform.position = Vector3.zero;

        // 타일의 부모를 Board로 설정
        tile_0.transform.SetParent(this.transform);*/

        CreateTiles();
    }

    //static public void Load(string Prefabs)
    //{
    //    object[] t0 = Resources.LoadAll(Prefabs);
    //    for(int i = 0; i < t0.Length; i++)
    //    {
    //        GameObject t1 = (GameObject)(t0[i]);
    //        _cache[t1.name] = t1;
    //    }
    //}

    // 프리팹으로 타일생성
    private void CreateTiles()
    {
        //Random rand = new Random();
        //rand.

        //int random = Random.Range(1, 6);

        for (int y = 0; y < m_nHeight; y++)
        {
            for(int x = 0; x < m_nWidth; x++)
            {
                // 1 ~ 6까지 랜덤숫자 발생
                int random = Random.Range(0, 6);

                string key = x.ToString() + "," + y.ToString();

                Tile tile = Instantiate<Tile>(m_TilePrefab[random].transform.GetComponent<Tile>());
                tile.transform.SetParent(this.transform);
                tile.transform.position = new Vector3(x + 2, y + 2, 0f);

                m_dicTilesDictionary.Add(key, tile);
                GetTile(x, y);
            }
        }
    }

    /// <summary>
    /// Tile 을 반환함
    /// </summary>
    /// <param name="x">좌표</param>
    /// <param name="y">좌표</param>
    /// <returns>Tile</returns>
    public Tile GetTile(int x, int y)
    {
        string key = x.ToString() + "," + y.ToString();
        //Debug.Log("Board.GetTile: x=" + x +"/y=" + y);
        return m_dicTilesDictionary[key];
    }

    /// <summary>
    /// Tile 을 반환함
    /// </summary>
    /// <param name="xy">좌표</param>
    /// <returns>Tile</returns>
    public Tile GetTile(string xy)
    {
        Debug.Log("Board.GetTile: xy=" + xy);
        return m_dicTilesDictionary[xy];
    }
}
