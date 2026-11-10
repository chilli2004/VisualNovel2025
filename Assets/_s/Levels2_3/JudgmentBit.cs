/*
 * PROJECT: Sympathy for the Devil
 * FILE PURPOSE: Puzzle-related object activation.
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

public class JudgmentBit : MonoBehaviour
{
    public GameObject _ga;

    public void An()
    {
        if (_ga==null)
        {
            // 获取当前物体的父物体
            Transform parentTransform = transform.parent;
            _ga = parentTransform.GetChild(0).gameObject;
        }
        _ga.SetActive(true);
        gameObject.SetActive(false);

    }
}
