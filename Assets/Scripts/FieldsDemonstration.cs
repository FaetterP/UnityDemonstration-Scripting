using UnityEngine;

namespace Assets.Scripts
{
    class FieldsDemonstration : MonoBehaviour
    {
        [Header("Visible fields")]
        [SerializeField] private int _int;
        [SerializeField] private float _float;
        [SerializeField] private bool _bool;
        [SerializeField] [TextArea(2,5)] private string _string;
        [SerializeField] private KeyCode _enum;
        [Space] [Space] [Space]
        [SerializeField] private GameObject GameObject;
        [SerializeField] private Vector3 Vector3;
        [SerializeField] private Vector2 Vector2;
        [SerializeField] private AnimationCurve Curve;
        [SerializeField] [Range(1, 5)] private int _range;

        [Header("Invisible fields")]
        [SerializeField] private const int _constInt = 3;
        [SerializeField] private readonly int _readonlyInt;
        [HideInInspector] public readonly int _hidden;
    }
}
