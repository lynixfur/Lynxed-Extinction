using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimalChunk : MonoBehaviour
{
    [Header("Tile Sprites")]
    public Sprite stone;
    public Sprite dirt;
    public Sprite snowy_grass;
    public Sprite tree;
    public float seed;
    public int chunkSize = 10;
    public int chunkHeight = 10;
    public float caveFreq = 0.08f;
    public float terrainFreq = 0.02f;    
    public float heightMultiplier = 40f;
    public int heightAddition = 25;
    public int dirtLayerHeight = 2;
    public int treeChance = 10;
    public int chunkStart;
    public bool generateCaves = true;
    public Texture2D noiseTexture;

    // Start is called before the first frame update
    void Start()
    {
        if(chunkStart < 40) {
            GenerateNoiseTexture();
            GenerateChunk();
        }
    }


    private void OnEnable() {
        Debug.LogWarning("TEST!");
        GenerateNoiseTexture();
        GenerateChunk();
    }

    private void OnDisable() {
        //if(chunkStart > 40) {
            foreach(Transform child in transform)
            {
                Destroy(child.gameObject);
            }            
        //}
    }
    // Update is called once per frame
    void Update()
    {
        
    }

        public void GenerateChunk() {
        for(int x = 0; x < chunkSize; x++) {

            float height = Mathf.PerlinNoise((x + seed + chunkStart) * terrainFreq, seed * terrainFreq) * heightMultiplier + heightAddition;

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
                        GenerateTree(x + chunkStart,y + 1);
                    }
                }

                if(generateCaves) {
                    if(noiseTexture.GetPixel(x + chunkStart,y).r > 0.2f) {
                        PlacePrimalTile(tileSprite, x + chunkStart, y);
                    }
                } else {
                    PlacePrimalTile(tileSprite, x + chunkStart, y);
                }
            }
        }
    }


    public void GenerateNoiseTexture()
    {
        noiseTexture = new Texture2D(200,200);

        for(int x = 0; x < noiseTexture.width; x++) {
            for(int y = 0; y < noiseTexture.height; y++) {
                float v = Mathf.PerlinNoise((x) * caveFreq, y * caveFreq);
                noiseTexture.SetPixel(x, y, new Color(v, v, v));
            }
        }

        noiseTexture.Apply();
    }

    public void GenerateTree(float x, float y)
    {
        GameObject primalTile = new GameObject();
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

        primalTile.transform.parent = this.transform;

        primalTile.AddComponent<SpriteRenderer>();
        primalTile.AddComponent<BoxCollider2D>().size = new Vector2(1f,1f);
        primalTile.GetComponent<SpriteRenderer>().sprite = tileTexture;
        primalTile.name = tileTexture.name;
        primalTile.transform.position = new Vector2(x + 0.5f,y + 0.5f);
    }
}
