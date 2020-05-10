using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SnapToGround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    [MenuItem("Custom/Snap To Ground %g")]
    public static void Ground()
    {
        foreach (var transform in Selection.transforms)
        {
            RaycastHit2D hitInfo;
            var hits = Physics2D.RaycastAll(transform.position + Vector3.up, Vector3.down, 10f);
            foreach (var hit in hits)
            {
                if (hit.collider.gameObject == transform.gameObject)
                    continue;
                transform.position = hit.point;
                break;
            }
        }

    }
}
