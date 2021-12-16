using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChunkStats : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lynx;
    public int chunkSize = 10;
    [SerializeField] TextMeshProUGUI m_Object;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         m_Object.text = "Chunk : " + ((int)(lynx.transform.position.x / chunkSize)).ToString() + "," + ((int)(lynx.transform.position.y / chunkSize)).ToString();
    }
}
