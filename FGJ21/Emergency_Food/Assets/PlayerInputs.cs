// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""MovementMap"",
            ""id"": ""0ea78ba7-e640-4546-bcac-7edea9b1c908"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""b991e0fd-b361-4216-843d-a6489368c08e"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""695833df-2abd-4d7a-9453-bfeae2ea536a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Meow"",
                    ""type"": ""Button"",
                    ""id"": ""de90a1ed-ff85-4812-9474-8fb402753596"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Lay"",
                    ""type"": ""Button"",
                    ""id"": ""4c3ec851-3666-4b4e-9be3-313300ae16c9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pet"",
                    ""type"": ""Button"",
                    ""id"": ""00710a86-22e4-40e5-8bfa-0b923d84f28b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""e2c38c0f-1b6d-4852-adb4-689b8293d684"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""146ce23b-d504-494e-ba20-fecf7ec9c3fb"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""CatScheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e5ae493b-9a85-415c-9c60-7a39b741ba7e"",
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
                    ""id"": ""2058f1da-c106-441e-bbb6-12948504019c"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""CatScheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""dc98e5b5-95b7-447d-9f7d-62a9126baf22"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""CatScheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f18ea1f9-8894-4171-8eb4-064feddaeea5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""CatScheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6f4884e0-8bab-4624-a2f8-9e171fe413a3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""CatScheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a18da630-c3d0-4a1f-955e-3561199b2352"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""CatScheme"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ed3df7f-7374-4bad-ac2e-9aa79f9d3777"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""CatScheme"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b536b6e-f1a1-4af3-a683-ea74331b3d4c"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""CatScheme"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb17baf6-65be-422f-a2dc-8c808c5e3c96"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Meow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e06d067c-9fee-422c-88d3-50a374d96ffc"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Meow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a46ddacc-79f0-45e1-9e32-6d766c6d3f64"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lay"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cbf6f745-6690-48fc-b3e0-16d035c8e677"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lay"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33790e9b-d446-4947-a74a-07291e6f2d95"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91e4164d-0fb1-4f54-959f-76f1e2451c33"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""080ffe2a-6330-4023-8fb4-2136a3a6aff8"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f8d64ff-ae1f-44f8-857c-b7003afe9c21"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MenuMap"",
            ""id"": ""dd3c5762-02ce-4759-b301-592cdc8d8227"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""c2b18447-4abb-4f3d-b22c-28087bfecd56"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""38f7c093-7f2a-4fa7-b9d2-a32b3c0b30c2"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50a19e54-1584-4216-9684-0078ed5d09c6"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""CatScheme"",
            ""bindingGroup"": ""CatScheme"",
            ""devices"": []
        }
    ]
}");
        // MovementMap
        m_MovementMap = asset.FindActionMap("MovementMap", throwIfNotFound: true);
        m_MovementMap_Move = m_MovementMap.FindAction("Move", throwIfNotFound: true);
        m_MovementMap_Jump = m_MovementMap.FindAction("Jump", throwIfNotFound: true);
        m_MovementMap_Meow = m_MovementMap.FindAction("Meow", throwIfNotFound: true);
        m_MovementMap_Lay = m_MovementMap.FindAction("Lay", throwIfNotFound: true);
        m_MovementMap_Pet = m_MovementMap.FindAction("Pet", throwIfNotFound: true);
        m_MovementMap_Pause = m_MovementMap.FindAction("Pause", throwIfNotFound: true);
        // MenuMap
        m_MenuMap = asset.FindActionMap("MenuMap", throwIfNotFound: true);
        m_MenuMap_Pause = m_MenuMap.FindAction("Pause", throwIfNotFound: true);
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

    // MovementMap
    private readonly InputActionMap m_MovementMap;
    private IMovementMapActions m_MovementMapActionsCallbackInterface;
    private readonly InputAction m_MovementMap_Move;
    private readonly InputAction m_MovementMap_Jump;
    private readonly InputAction m_MovementMap_Meow;
    private readonly InputAction m_MovementMap_Lay;
    private readonly InputAction m_MovementMap_Pet;
    private readonly InputAction m_MovementMap_Pause;
    public struct MovementMapActions
    {
        private @PlayerInputs m_Wrapper;
        public MovementMapActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_MovementMap_Move;
        public InputAction @Jump => m_Wrapper.m_MovementMap_Jump;
        public InputAction @Meow => m_Wrapper.m_MovementMap_Meow;
        public InputAction @Lay => m_Wrapper.m_MovementMap_Lay;
        public InputAction @Pet => m_Wrapper.m_MovementMap_Pet;
        public InputAction @Pause => m_Wrapper.m_MovementMap_Pause;
        public InputActionMap Get() { return m_Wrapper.m_MovementMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementMapActions set) { return set.Get(); }
        public void SetCallbacks(IMovementMapActions instance)
        {
            if (m_Wrapper.m_MovementMapActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MovementMapActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MovementMapActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MovementMapActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_MovementMapActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MovementMapActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MovementMapActionsCallbackInterface.OnJump;
                @Meow.started -= m_Wrapper.m_MovementMapActionsCallbackInterface.OnMeow;
                @Meow.performed -= m_Wrapper.m_MovementMapActionsCallbackInterface.OnMeow;
                @Meow.canceled -= m_Wrapper.m_MovementMapActionsCallbackInterface.OnMeow;
                @Lay.started -= m_Wrapper.m_MovementMapActionsCallbackInterface.OnLay;
                @Lay.performed -= m_Wrapper.m_MovementMapActionsCallbackInterface.OnLay;
                @Lay.canceled -= m_Wrapper.m_MovementMapActionsCallbackInterface.OnLay;
                @Pet.started -= m_Wrapper.m_MovementMapActionsCallbackInterface.OnPet;
                @Pet.performed -= m_Wrapper.m_MovementMapActionsCallbackInterface.OnPet;
                @Pet.canceled -= m_Wrapper.m_MovementMapActionsCallbackInterface.OnPet;
                @Pause.started -= m_Wrapper.m_MovementMapActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_MovementMapActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_MovementMapActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_MovementMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Meow.started += instance.OnMeow;
                @Meow.performed += instance.OnMeow;
                @Meow.canceled += instance.OnMeow;
                @Lay.started += instance.OnLay;
                @Lay.performed += instance.OnLay;
                @Lay.canceled += instance.OnLay;
                @Pet.started += instance.OnPet;
                @Pet.performed += instance.OnPet;
                @Pet.canceled += instance.OnPet;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public MovementMapActions @MovementMap => new MovementMapActions(this);

    // MenuMap
    private readonly InputActionMap m_MenuMap;
    private IMenuMapActions m_MenuMapActionsCallbackInterface;
    private readonly InputAction m_MenuMap_Pause;
    public struct MenuMapActions
    {
        private @PlayerInputs m_Wrapper;
        public MenuMapActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_MenuMap_Pause;
        public InputActionMap Get() { return m_Wrapper.m_MenuMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuMapActions set) { return set.Get(); }
        public void SetCallbacks(IMenuMapActions instance)
        {
            if (m_Wrapper.m_MenuMapActionsCallbackInterface != null)
            {
                @Pause.started -= m_Wrapper.m_MenuMapActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_MenuMapActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_MenuMapActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_MenuMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public MenuMapActions @MenuMap => new MenuMapActions(this);
    private int m_CatSchemeSchemeIndex = -1;
    public InputControlScheme CatSchemeScheme
    {
        get
        {
            if (m_CatSchemeSchemeIndex == -1) m_CatSchemeSchemeIndex = asset.FindControlSchemeIndex("CatScheme");
            return asset.controlSchemes[m_CatSchemeSchemeIndex];
        }
    }
    public interface IMovementMapActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMeow(InputAction.CallbackContext context);
        void OnLay(InputAction.CallbackContext context);
        void OnPet(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IMenuMapActions
    {
        void OnPause(InputAction.CallbackContext context);
    }
}
