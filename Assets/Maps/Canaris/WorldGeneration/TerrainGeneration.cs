using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGeneration : MonoBehaviour
{
    public int worldSize = 900;
    public float caveFreq = 0.05f;
    public float terrainFreq = 0.05f;    
    public float heightMultiplier = 40f;
    public int heightAddition = 25;
    public int dirtLayerHeight = 2;
    public int treeChance = 10;
    public float seed;
    public bool generateCaves = true;
    public int chunkSize = 16;
    public Texture2D noiseTexture;

    [Header("Tile Sprites")]
    public Sprite stone;
    public Sprite dirt;
    public Sprite snowy_grass;
    public Sprite tree;

    public GameObject[] worldChunks;
    private void Start()
    {
        seed = Random.Range(-10000,10000);
        GenerateNoiseTexture();
        CreateChunks();
        GenerateTerrain();
    }

    public void CreateChunks() 
    {
        int numChunks = worldSize / chunkSize;
        worldChunks = new GameObject[numChunks];
        for (int i = 0; i < numChunks; i++) {
            GameObject primalChunk = new GameObject();
            primalChunk.name = "Primal Chunk " + i.ToString();
            primalChunk.transform.parent = this.transform;
            worldChunks[i] = primalChunk;
        }
    }

    public void GenerateTerrain() {
        for(int x = 0; x < worldSize; x++) {

            float height = Mathf.PerlinNoise((x + seed) * terrainFreq, seed * terrainFreq) * heightMultiplier + heightAddition;

            for(int y = 0; y < height; y++) {
                Sprite tileSprite;

                if( y < height - dirtLayerHeight) 
                {
                    tileSprite = stone;
                } else if(y < height - 1) 
                {
                    tileSprite = dirt;
                } else {

                    // Surface

                    tileSprite = snowy_grass;

                    int t = Random.Range(0, treeChance);
                    if(t == 1) {
                        //Generate a tree
                        GenerateTree(x,y + 1);
                    }
                }

                if(generateCaves) {
                    if(noiseTexture.GetPixel(x,y).r > 0.2f) {
                        PlacePrimalTile(tileSprite, x, y);
                    }
                } else {
                    PlacePrimalTile(tileSprite, x, y);
                }
            }
        }
    }

    public void GenerateTree() 
    {

    }

    public void GenerateNoiseTexture()
    {
        noiseTexture = new Texture2D(worldSize, worldSize);

        for(int x = 0; x < noiseTexture.width; x++) {
            for(int y = 0; y < noiseTexture.height; y++) {
                float v = Mathf.PerlinNoise(x * caveFreq, y * caveFreq);
                noiseTexture.SetPixel(x, y, new Color(v, v, v));
            }
        }

        noiseTexture.Apply();
    }

    public void GenerateTree(float x, float y)
    {
        GameObject primalTile = new GameObject(name = "PrimalTree_Snowy");
        primalTile.transform.parent = this.transform;
        primalTile.AddComponent<SpriteRenderer>();
        //primalTile.AddComponent<BoxCollider2D>().size = new Vector2(1f,1f);
        primalTile.GetComponent<SpriteRenderer>().sprite = tree;
        primalTile.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(-2, -1);
        primalTile.transform.position = new Vector2(x + 0.5f,y + 1.45f);
        primalTile.transform.localScale = new Vector2(2f,2f);
    }
    public void PlacePrimalTile(Sprite tileTexture, int x, int y)
    {
        GameObject primalTile = new GameObject();

        float chunkCoordinate = (Mathf.Round(x / chunkSize) * chunkSize);
        chunkCoordinate /= chunkSize;
        primalTile.transform.parent = worldChunks[(int)chunkCoordinate].transform;

        primalTile.AddComponent<SpriteRenderer>();
        primalTile.AddComponent<BoxCollider2D>().size = new Vector2(1f,1f);
        primalTile.GetComponent<SpriteRenderer>().sprite = tileTexture;
        primalTile.name = tileTexture.name;
        primalTile.transform.position = new Vector2(x + 0.5f,y + 0.5f);
    }
}
