//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/PrimalLynx/Player/LynxControlActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @LynxControlActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @LynxControlActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""LynxControlActions"",
    ""maps"": [
        {
            ""name"": ""Lynx"",
            ""id"": ""df4ebb95-3731-4cb9-b7b5-af13fb96ab98"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""2c094258-7ce7-45b3-8af4-95c61f9f95ab"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""567098ec-f97f-43be-a588-187f2cd0f4d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""45fb9906-2896-46e4-837b-db5f3be6378c"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c073e98e-4769-4b78-a1ec-bdc5ae46589d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""91c2c01f-8058-4131-a824-dff4e42d2184"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7e548a29-18de-4643-858b-6c1d4ee0954d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b4090222-cf81-4a10-8be0-a165257ba31b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""22745860-2964-48e9-b52a-b0023d3f8c6a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8dd81fab-44e1-4d71-9465-5deb6c36369b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Lynx
        m_Lynx = asset.FindActionMap("Lynx", throwIfNotFound: true);
        m_Lynx_Move = m_Lynx.FindAction("Move", throwIfNotFound: true);
        m_Lynx_Jump = m_Lynx.FindAction("Jump", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Lynx
    private readonly InputActionMap m_Lynx;
    private ILynxActions m_LynxActionsCallbackInterface;
    private readonly InputAction m_Lynx_Move;
    private readonly InputAction m_Lynx_Jump;
    public struct LynxActions
    {
        private @LynxControlActions m_Wrapper;
        public LynxActions(@LynxControlActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Lynx_Move;
        public InputAction @Jump => m_Wrapper.m_Lynx_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Lynx; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LynxActions set) { return set.Get(); }
        public void SetCallbacks(ILynxActions instance)
        {
            if (m_Wrapper.m_LynxActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_LynxActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_LynxActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_LynxActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_LynxActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_LynxActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_LynxActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_LynxActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public LynxActions @Lynx => new LynxActions(this);
    public interface ILynxActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
