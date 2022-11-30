using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace GameFramework.Input
{
    [AddComponentMenu("GameFramework/Input/Quick Input Handler")]
    public class QuickInputHandler : MonoBehaviour
    {
        [SerializeField] private InputActionAsset _asset;
        [SerializeField] private string _actionMap;
        [SerializeField] private string _action;

        [SerializeField] private UnityEvent _performed;
        [SerializeField] private UnityEvent<Vector2> _vectorUpdate;

        private InputAction _inputAction;

        private void Awake()
        {
            string actionPath = $"{_actionMap}/{_action}"; 
            _inputAction = _asset.FindAction(actionPath);

            if (_inputAction == null)
            {
                Debug.LogError($"Quick Input Handler couldn't find '{actionPath}'");
                enabled = false;
                return;
            }

            _inputAction.performed += InputActionPerformed;
        }

        private void Update()
        {
            _vectorUpdate.Invoke(_inputAction.ReadValue<Vector2>());
        }
        private void InputActionPerformed(InputAction.CallbackContext obj)
        {
            _performed.Invoke();
        }
        private void OnEnable()
        {
            _inputAction.Enable();
        }
        private void OnDisable()
        {
            if (_inputAction != null) _inputAction.Disable();
        }
    }
}