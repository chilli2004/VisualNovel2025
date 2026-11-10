/*
 * PROJECT: Sympathy for the Devil
 * FILE PURPOSE: Long-note trigger behavior.
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

public class LongNote : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
