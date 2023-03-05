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
        },
        {
            ""name"": ""BattleControls"",
            ""id"": ""920715d9-a7ea-4df9-98fb-c674e7ba6aa8"",
            ""actions"": [
                {
                    ""name"": ""direction"",
                    ""type"": ""Value"",
                    ""id"": ""769156d7-61b1-4cc4-8663-4c89a34d111f"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""action"",
                    ""type"": ""Value"",
                    ""id"": ""12470821-5d9c-4c9e-a687-8fc8a0663726"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5c573398-39c2-4b29-9b46-84766c1b2872"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Overworld"",
                    ""action"": ""direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""2834985b-af67-40c3-95be-13a4167b6430"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5efef1a8-7533-4005-ba80-8cf672afb2ff"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1f204770-5904-44f8-9627-2fcd642e582c"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e2a14d56-cbf9-4183-8159-f7f5c9b1ab4e"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""15c4a142-6b49-4ae4-a35f-b0708dcad50d"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""6853d86d-0100-403c-8022-d3cd60313116"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""091a0974-3d34-419c-b6ab-867b93c644ba"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d5937ffb-aa23-4105-8c4f-2451a4e17401"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d9ffca9d-4705-4fe2-9378-27bca60f2e31"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""793bd46d-8477-4274-b989-ca5181b160bb"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""cd4619f3-c6e1-4c7b-afdd-aa499282e784"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Overworld"",
                    ""action"": ""action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4966e792-6d57-4f85-a267-be1204b6309a"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Overworld"",
                    ""action"": ""action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
        // BattleControls
        m_BattleControls = asset.FindActionMap("BattleControls", throwIfNotFound: true);
        m_BattleControls_direction = m_BattleControls.FindAction("direction", throwIfNotFound: true);
        m_BattleControls_action = m_BattleControls.FindAction("action", throwIfNotFound: true);
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

    // BattleControls
    private readonly InputActionMap m_BattleControls;
    private IBattleControlsActions m_BattleControlsActionsCallbackInterface;
    private readonly InputAction m_BattleControls_direction;
    private readonly InputAction m_BattleControls_action;
    public struct BattleControlsActions
    {
        private @OverworldInput m_Wrapper;
        public BattleControlsActions(@OverworldInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @direction => m_Wrapper.m_BattleControls_direction;
        public InputAction @action => m_Wrapper.m_BattleControls_action;
        public InputActionMap Get() { return m_Wrapper.m_BattleControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BattleControlsActions set) { return set.Get(); }
        public void SetCallbacks(IBattleControlsActions instance)
        {
            if (m_Wrapper.m_BattleControlsActionsCallbackInterface != null)
            {
                @direction.started -= m_Wrapper.m_BattleControlsActionsCallbackInterface.OnDirection;
                @direction.performed -= m_Wrapper.m_BattleControlsActionsCallbackInterface.OnDirection;
                @direction.canceled -= m_Wrapper.m_BattleControlsActionsCallbackInterface.OnDirection;
                @action.started -= m_Wrapper.m_BattleControlsActionsCallbackInterface.OnAction;
                @action.performed -= m_Wrapper.m_BattleControlsActionsCallbackInterface.OnAction;
                @action.canceled -= m_Wrapper.m_BattleControlsActionsCallbackInterface.OnAction;
            }
            m_Wrapper.m_BattleControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @direction.started += instance.OnDirection;
                @direction.performed += instance.OnDirection;
                @direction.canceled += instance.OnDirection;
                @action.started += instance.OnAction;
                @action.performed += instance.OnAction;
                @action.canceled += instance.OnAction;
            }
        }
    }
    public BattleControlsActions @BattleControls => new BattleControlsActions(this);
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
    public interface IBattleControlsActions
    {
        void OnDirection(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
    }
}
