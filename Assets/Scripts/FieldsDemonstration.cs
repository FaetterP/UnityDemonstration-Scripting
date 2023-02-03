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
        [SerializeField] private Quaternion _quaternion;
        [SerializeField] private AnimationCurve Curve;
        [SerializeField] [Range(1, 5)] private int _range;
        [SerializeField] private Color _color;
        [SerializeField] private Gradient _gradient;

        [Header("Invisible fields")]
        [SerializeField] private const int _constInt = 3;
        [SerializeField] private readonly int _readonlyInt;
        [HideInInspector] public int _hidden;

        [Header("bool vs enum")]
        [SerializeField] private bool _isControlledByKeyboardNotMouse;
        enum ControllerType
        {
            [InspectorName("Override Keyboard Name")] Keyboard,
            Mouse
        }
        [SerializeField] private ControllerType _controller;

        [Header("Colors")]
        [SerializeField] [ColorUsage(true)] private Color _colorWithAplha;
        [SerializeField] [ColorUsage(true, true)] private Color _colorHDR;

        [Header("Gradient")]
        [SerializeField] [GradientUsage(true)] private Gradient _gradientHDR;        

        [Header("default values")]
        [SerializeField] private LayerMask _layerMask;
        [SerializeField] private Transform _transform;
        [SerializeField] private Sprite _sprite;
    }
}
