//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.0
//     from Assets/Input/PlayerInput.inputactions
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

namespace ProjectMaster.Input
{
    public partial class @PlayerInput: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Battle"",
            ""id"": ""8e655625-5885-48d9-9afa-0d6072bfac67"",
            ""actions"": [
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""d513e8bb-821c-4151-9a89-7454fb927777"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""149323d9-0791-4e9d-9619-483c5a8f8f92"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ActionSelect"",
                    ""type"": ""Button"",
                    ""id"": ""d47e47be-2484-42d5-8108-65dea8c3453e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ActionDirection"",
                    ""type"": ""Value"",
                    ""id"": ""61d48b45-8404-4192-b2de-bdeec048fe03"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9955c082-08a3-4918-a558-10d7ea04ce0c"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d322af4f-6daf-4e64-8349-802988e8aa49"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f54eb81-40ad-4641-9213-6bed77f10939"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c95cc819-5ef6-4a2b-8ec0-ce4d3f2d970f"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0fdeeb5e-7d01-482c-a7e8-2d02cd3196ba"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""ActionSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8dfafeb2-55d0-4dfe-bbba-cb39abaae1c2"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""ActionSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba99ea43-06ec-4e93-9066-7e045a9eacbc"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""ActionSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa49aeac-b865-4d43-8f5f-81ad70005fdc"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""ActionSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Face [Gamepad]"",
                    ""id"": ""248644c6-350e-4192-97cc-7f8b126d3896"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2c6874e7-4fbc-4a59-a5c4-e5160a5f8faa"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""ActionDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4cb7438c-a4ca-484c-90cb-2aa23bdab976"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""ActionDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ac583323-1ba1-4b81-94ca-22da4f7347ea"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""ActionDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d1b0a574-55c9-405a-882f-7978cc1fdda4"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""ActionDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Default"",
            ""bindingGroup"": ""Default"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Battle
            m_Battle = asset.FindActionMap("Battle", throwIfNotFound: true);
            m_Battle_Confirm = m_Battle.FindAction("Confirm", throwIfNotFound: true);
            m_Battle_Cancel = m_Battle.FindAction("Cancel", throwIfNotFound: true);
            m_Battle_ActionSelect = m_Battle.FindAction("ActionSelect", throwIfNotFound: true);
            m_Battle_ActionDirection = m_Battle.FindAction("ActionDirection", throwIfNotFound: true);
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

        // Battle
        private readonly InputActionMap m_Battle;
        private List<IBattleActions> m_BattleActionsCallbackInterfaces = new List<IBattleActions>();
        private readonly InputAction m_Battle_Confirm;
        private readonly InputAction m_Battle_Cancel;
        private readonly InputAction m_Battle_ActionSelect;
        private readonly InputAction m_Battle_ActionDirection;
        public struct BattleActions
        {
            private @PlayerInput m_Wrapper;
            public BattleActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Confirm => m_Wrapper.m_Battle_Confirm;
            public InputAction @Cancel => m_Wrapper.m_Battle_Cancel;
            public InputAction @ActionSelect => m_Wrapper.m_Battle_ActionSelect;
            public InputAction @ActionDirection => m_Wrapper.m_Battle_ActionDirection;
            public InputActionMap Get() { return m_Wrapper.m_Battle; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(BattleActions set) { return set.Get(); }
            public void AddCallbacks(IBattleActions instance)
            {
                if (instance == null || m_Wrapper.m_BattleActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_BattleActionsCallbackInterfaces.Add(instance);
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @ActionSelect.started += instance.OnActionSelect;
                @ActionSelect.performed += instance.OnActionSelect;
                @ActionSelect.canceled += instance.OnActionSelect;
                @ActionDirection.started += instance.OnActionDirection;
                @ActionDirection.performed += instance.OnActionDirection;
                @ActionDirection.canceled += instance.OnActionDirection;
            }

            private void UnregisterCallbacks(IBattleActions instance)
            {
                @Confirm.started -= instance.OnConfirm;
                @Confirm.performed -= instance.OnConfirm;
                @Confirm.canceled -= instance.OnConfirm;
                @Cancel.started -= instance.OnCancel;
                @Cancel.performed -= instance.OnCancel;
                @Cancel.canceled -= instance.OnCancel;
                @ActionSelect.started -= instance.OnActionSelect;
                @ActionSelect.performed -= instance.OnActionSelect;
                @ActionSelect.canceled -= instance.OnActionSelect;
                @ActionDirection.started -= instance.OnActionDirection;
                @ActionDirection.performed -= instance.OnActionDirection;
                @ActionDirection.canceled -= instance.OnActionDirection;
            }

            public void RemoveCallbacks(IBattleActions instance)
            {
                if (m_Wrapper.m_BattleActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IBattleActions instance)
            {
                foreach (var item in m_Wrapper.m_BattleActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_BattleActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public BattleActions @Battle => new BattleActions(this);
        private int m_DefaultSchemeIndex = -1;
        public InputControlScheme DefaultScheme
        {
            get
            {
                if (m_DefaultSchemeIndex == -1) m_DefaultSchemeIndex = asset.FindControlSchemeIndex("Default");
                return asset.controlSchemes[m_DefaultSchemeIndex];
            }
        }
        public interface IBattleActions
        {
            void OnConfirm(InputAction.CallbackContext context);
            void OnCancel(InputAction.CallbackContext context);
            void OnActionSelect(InputAction.CallbackContext context);
            void OnActionDirection(InputAction.CallbackContext context);
        }
    }
}
