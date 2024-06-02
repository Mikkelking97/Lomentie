using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinNoiseMap : MonoBehaviour
{
    Dictionary<int, GameObject> tileset;
    Dictionary<int, GameObject> tile_groups;

    public GameObject tile_snow;
    public GameObject tile_stone;
    public GameObject tile_grass;
    public GameObject tile_sand;
    public GameObject tile_water;
    public GameObject tile_deepwater;

    public int map_width = 16;
    public int map_height = 9;

    List<List<int>> noise_grid = new List<List<int>>();
    List<List<GameObject>> tile_grid = new List<List<GameObject>>();

    // recommended values: 4 to 20
    public float magnification = 7.0f;

    public int x_offset = 0;
    public int y_offset = 0;

    void Start()
    {
        CreateTileset();
        CreateTileGroups();
        GenerateMap();
    }

    void CreateTileset()
    {
        tileset = new Dictionary<int, GameObject>();
        tileset.Add(0, tile_snow);
        tileset.Add(1, tile_stone);
        tileset.Add(2, tile_grass);
        tileset.Add(3, tile_sand);
        tileset.Add(4, tile_water);
        tileset.Add(5, tile_deepwater);
    }

    void CreateTileGroups()
    {
        tile_groups = new Dictionary<int, GameObject>();
        foreach(KeyValuePair<int, GameObject> tile_pair in tileset)
        {
            GameObject tile_group = new GameObject(tile_pair.Value.name);
            tile_group.transform.parent = gameObject.transform;
            tile_group.transform.localPosition = new Vector2(0, 0);
            tile_groups.Add(tile_pair.Key, tile_group);
        }
    }

    void GenerateMap()
    {
        for (int x = 0; x < map_width; x++)
        {
            noise_grid.Add(new List<int>());
            tile_grid.Add(new List<GameObject>());

            for (int y = 0; y < map_height; y++)
            {
                int tile_id = GetIdUsingPerlin(x, y);
                noise_grid[x].Add(tile_id);
                CreateTile(tile_id, x, y);
            }
        }
    }

    int GetIdUsingPerlin(int x, int y)
    {
        float raw_perlin = Mathf.PerlinNoise(
            (x - x_offset) / magnification, 
            (y - y_offset) / magnification
        );

        float clamp_perlin = Mathf.Clamp(raw_perlin, 0.0f, 1.0f);
        float scaled_perlin = clamp_perlin * tileset.Count;

        if(scaled_perlin == 6)
        {
            scaled_perlin = 5;
        }
        return Mathf.FloorToInt(scaled_perlin);
    }

    void CreateTile(int tile_id, int x, int y)
    {
        GameObject tile_prefab = tileset[tile_id];
        GameObject tile_group = tile_groups[tile_id];
        GameObject tile = Instantiate(tile_prefab, tile_group.transform);

        tile.name = string.Format("tile_x{0}_y{1}", x, y);
        tile.transform.localPosition = new Vector2(x, y);

        tile_grid[x].Add(tile);
    }
}
