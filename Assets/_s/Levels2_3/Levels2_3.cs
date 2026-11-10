/*
 * PROJECT: Sympathy for the Devil
 * FILE PURPOSE: Puzzle level progression and completion control.
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

using System.Collections;
using UnityEngine;

public class Levels2_3 : MonoBehaviour
{
    public GameObject _puz;

    public Puzzle[] _Puzzles;

    public GameObject canvas;
    
    public GameObject pssingOvera;
    public void RotatePuzZStepMinus90()
    {
        if (_puz == null) return;

        var rt = _puz.GetComponent<RectTransform>();
        if (rt != null)
        {
            var e = rt.localEulerAngles;
            e.z = (e.z - 90f + 360f) % 360f; // 避免累计漂移
            rt.localEulerAngles = e;
        }
        else
        {
            var e = _puz.transform.localEulerAngles;
            e.z = (e.z - 90f + 360f) % 360f;
            _puz.transform.localEulerAngles = e;
        }
    }

    public void Finish()
    {
        if (_Puzzles[0]._isPuzzle && _Puzzles[1]._isPuzzle && _Puzzles[2]._isPuzzle && _Puzzles[3]._isPuzzle 
            && _Puzzles[4]._isPuzzle && _Puzzles[5]._isPuzzle)
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
            StartCoroutine(SpawnNotes());
        }
    }

    IEnumerator SpawnNotes()
    {
        yield return new WaitForSeconds(2.0f);
        Destroy(gameObject);
    }
}
