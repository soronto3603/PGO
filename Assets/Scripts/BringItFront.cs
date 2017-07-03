using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BringItFront : MonoBehaviour
{
    void OnEnable()
    {
        transform.SetAsLastSibling();
    }
}
