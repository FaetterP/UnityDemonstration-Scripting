using UnityEngine;

namespace Assets.Scripts
{
    class ObjectCreator : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _objectToCreate;

        private void Start()
        {
            Instantiate(_objectToCreate, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        }
    }
}
