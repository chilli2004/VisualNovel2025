/*
 * PROJECT: Sympathy for the Devil
 * FILE PURPOSE: Timed input and game-state behavior.
 * CONTRIBUTION / AI DISCLOSURE:
 * - The project used tutorials and AI assistance for C# implementation.
 * - The original creation history is incomplete. I cannot reliably label
 *   individual lines or methods here as self-written, AI-generated, or
 *   tutorial-adapted; their specific authorship is UNVERIFIED.
 * - My confirmed work on this project was game mechanics and level design,
 *   assembling Unity scenes/UI/assets, playtesting, troubleshooting,
 *   and adjusting parameters. This is project-level participation,
 *   not a claim of independent authorship of this script.
 * - This disclosure was added later for review; executable code is unchanged.
 */

using TMPro;
using UnityEngine;
using System.Collections;

public class Levels2 : MonoBehaviour
{
    public float[] AppTime;
    
    public TextMeshProUGUI _L;

    public TextMeshProUGUI _R;
    
    // 可配置的按键
    public KeyCode targetKey = KeyCode.A; // 默认为A键，可在Inspector中修改
    void Start()
    {
        StartCoroutine(SpawnNotes());
    }
    
    IEnumerator SpawnNotes()
    {
        // 确保数组长度一致
        int count = AppTime.Length;
        
        float timer = 0f;
        int currentIndex = 0;
        
        while (currentIndex < count)
        {
            // 每帧累加时间
            timer += Time.deltaTime;
            // 检查是否到达下一个生成时间
            if (timer >= AppTime[currentIndex])
            {
                if (!gameObject.transform.GetChild(1).gameObject.activeInHierarchy)
                {
                    gameObject.transform.GetChild(0).gameObject.SetActive(false);
                    gameObject.transform.GetChild(2).gameObject.SetActive(false);
                    gameObject.transform.GetChild(1).gameObject.SetActive(true);
                }
                currentIndex++;
            }
            
            yield return null; // 等待下一帧
        }
    }

    private float tim;
    
    void LateUpdate()
    {
        if (gameObject.transform.GetChild(1).gameObject.activeInHierarchy)
        {
            // 每帧累加时间
            tim += Time.deltaTime;
            // 短音符：按 A 键立即触发
            if (Input.GetKeyDown(targetKey))
            {
                gameObject.transform.GetChild(1).gameObject.SetActive(false);
                gameObject.transform.GetChild(2).gameObject.SetActive(true);
                string l1 = _L.text;
                int l11 = int.Parse(l1);
                l11 += 100;
                _L.text = l11.ToString();
                string r1 = _R.text;
                int r11 = int.Parse(r1);
                r11 += 100;
                _R.text = r11.ToString();
            }

            if (tim>=1f)
            {
                gameObject.transform.GetChild(2).gameObject.SetActive(false);
                gameObject.transform.GetChild(1).gameObject.SetActive(false);
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
            }
        }
        else
        {
            tim = 0;
        }
        
    }
}
