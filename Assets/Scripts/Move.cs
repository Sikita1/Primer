using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    [SerializeField] private Image _image;

    void Start()
    {
        _image = GetComponent<Image>();
    }
}
