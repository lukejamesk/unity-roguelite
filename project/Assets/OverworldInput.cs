//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/OverworldInput.inputactions
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

public partial class @OverworldInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @OverworldInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""OverworldInput"",
    ""maps"": [
        {
            ""name"": ""OverworldControls"",
            ""id"": ""a7b81cad-7b36-4648-863b-3b095564ecb3"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""a481296e-ce4a-4b3e-b110-5983c36085d7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3565bcbd-6c3b-4294-b452-66add59fe71c"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""6adb3783-60ae-4eef-9f14-5e4bfbb164be"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""03f1192f-b8cc-4004-8c4f-7398ee8cfce2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4b06f8b9-3a61-4ba8-ae06-af840a045a28"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""061a10db-ded9-47b1-8689-4904a1af7b34"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""54f2dcda-1ccf-4cef-a4e7-7bf4f5f99ea6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Overworld"",
            ""bindingGroup"": ""Overworld"",
            ""devices"": []
        }
    ]
}");
        // OverworldControls
        m_OverworldControls = asset.FindActionMap("OverworldControls", throwIfNotFound: true);
        m_OverworldControls_Movement = m_OverworldControls.FindAction("Movement", throwIfNotFound: true);
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

    // OverworldControls
    private readonly InputActionMap m_OverworldControls;
    private IOverworldControlsActions m_OverworldControlsActionsCallbackInterface;
    private readonly InputAction m_OverworldControls_Movement;
    public struct OverworldControlsActions
    {
        private @OverworldInput m_Wrapper;
        public OverworldControlsActions(@OverworldInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_OverworldControls_Movement;
        public InputActionMap Get() { return m_Wrapper.m_OverworldControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OverworldControlsActions set) { return set.Get(); }
        public void SetCallbacks(IOverworldControlsActions instance)
        {
            if (m_Wrapper.m_OverworldControlsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_OverworldControlsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_OverworldControlsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_OverworldControlsActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_OverworldControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public OverworldControlsActions @OverworldControls => new OverworldControlsActions(this);
    private int m_OverworldSchemeIndex = -1;
    public InputControlScheme OverworldScheme
    {
        get
        {
            if (m_OverworldSchemeIndex == -1) m_OverworldSchemeIndex = asset.FindControlSchemeIndex("Overworld");
            return asset.controlSchemes[m_OverworldSchemeIndex];
        }
    }
    public interface IOverworldControlsActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
}
