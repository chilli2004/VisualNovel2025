/*
 * PROJECT: Sympathy for the Devil
 * FILE PURPOSE: UI object spawning and scene/presentation transitions.
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

using UnityEngine;

public class PssingOvera : MonoBehaviour
{
    public GameObject _ga1;
    public GameObject _ga2;
    public GameObject _ga3;
    public GameObject pssingOvera;
    public GameObject canvas;

    public bool es;
    public AudioSource _audio;
    public void G1()
    {
        _ga2.SetActive(true);
        Destroy(_ga1);
    }

    public void G2()
    {
        PssigOvera();
    }
    
    public void PssigOvera(){
        if (pssingOvera != null && canvas != null)
        {
            // 获取 pssingOvera 的世界位置
            RectTransform pssingRect = pssingOvera.GetComponent<RectTransform>();
            Vector3 worldPosition = Vector3.zero;
            if (pssingRect != null)
            {
                worldPosition = pssingRect.position;
            }
        
            // 生成 pssingOvera，先作为 canvas 的子物品
            GameObject pssingInstance = Instantiate(pssingOvera, canvas.transform);
        
            // 获取实例的 RectTransform
            RectTransform instanceRect = pssingInstance.GetComponent<RectTransform>();
            if (instanceRect != null && canvas != null)
            {
                // 将世界坐标转换为 canvas 的本地坐标
                instanceRect.position = worldPosition;
            }
        
            pssingInstance.SetActive(true);
            if (es)
            {
                _audio.Stop();
            }
            Destroy(_ga3);
        }
    }
}
