/*
 * PROJECT: Sympathy for the Devil
 * FILE PURPOSE: Short-note interaction behavior.
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

using System;
using UnityEngine;

public class ShortNote : MonoBehaviour
{
    public GameObject _ga;
    public GameObject _notes;
    public void No()
    {
        Destroy(gameObject);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    public void Ga()
    {
        if (_ga != null && _notes != null)
        {
            // 获取当前音符的位置
            RectTransform currentRect = GetComponent<RectTransform>();
            
            if (currentRect != null)
            {
                // 1. 首先生成 _ga，作为 _notes 的子物品
                GameObject gaInstance = Instantiate(_ga, _notes.transform);
                
                // 2. 把当前这个脚本的物品位置给 _ga（使用 localPosition）
                RectTransform gaRect = gaInstance.GetComponent<RectTransform>();
                if (gaRect != null)
                {
                    // 将世界坐标转换为本地坐标
                    Vector2 localPos = _notes.transform.InverseTransformPoint(currentRect.position);
                    gaRect.localPosition = localPos;
                    gaRect.localScale = Vector3.one * 1f;
                }
                
                gaInstance.SetActive(true);
                Destroy(gameObject);
            }
        }
    }
}
