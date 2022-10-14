// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/PlayerInputSystem.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputSystem : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputSystem"",
    ""maps"": [
        {
            ""name"": ""Moving"",
            ""id"": ""2a8ddff8-c7fb-44f2-9b39-ce7ef54884d8"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f0a8a6ed-97e0-4436-ae43-e9ac52eeb625"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2DVector"",
                    ""id"": ""6db31465-8771-4fb4-b1e1-88d2d7f85fa1"",
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
                    ""id"": ""01c94e82-59fe-4548-b1b8-88813606f45a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""52a08b25-0eef-4fcd-bac5-b84b32694244"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a0df2562-81b8-4ef6-ab6c-16ef440ef9a7"",
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
                    ""id"": ""922eddbb-9b9c-455f-b7f0-53936ec587bb"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Interactions"",
            ""id"": ""4b6c83cd-14dd-485e-8eec-a1c0c7c7950e"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""c2c201b6-0bc5-4787-b3a3-b29e2f45ca40"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""PauseMenu"",
                    ""type"": ""Button"",
                    ""id"": ""5de60a07-93bf-436c-94f1-2df69b4a168b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Continue"",
                    ""type"": ""Button"",
                    ""id"": ""d3f808fb-2ae0-4634-8b33-c67cc37ff53a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1203c7f1-c22a-4e8e-96ec-89ffb4b0bccf"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11228ce3-0766-4e24-928f-b7ce3df5c074"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""901f8fcc-6558-442d-9842-97b33c630a2a"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Continue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Moving
        m_Moving = asset.FindActionMap("Moving", throwIfNotFound: true);
        m_Moving_Move = m_Moving.FindAction("Move", throwIfNotFound: true);
        // Interactions
        m_Interactions = asset.FindActionMap("Interactions", throwIfNotFound: true);
        m_Interactions_Interact = m_Interactions.FindAction("Interact", throwIfNotFound: true);
        m_Interactions_PauseMenu = m_Interactions.FindAction("PauseMenu", throwIfNotFound: true);
        m_Interactions_Continue = m_Interactions.FindAction("Continue", throwIfNotFound: true);
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

    // Moving
    private readonly InputActionMap m_Moving;
    private IMovingActions m_MovingActionsCallbackInterface;
    private readonly InputAction m_Moving_Move;
    public struct MovingActions
    {
        private @PlayerInputSystem m_Wrapper;
        public MovingActions(@PlayerInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Moving_Move;
        public InputActionMap Get() { return m_Wrapper.m_Moving; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovingActions set) { return set.Get(); }
        public void SetCallbacks(IMovingActions instance)
        {
            if (m_Wrapper.m_MovingActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MovingActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MovingActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MovingActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_MovingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public MovingActions @Moving => new MovingActions(this);

    // Interactions
    private readonly InputActionMap m_Interactions;
    private IInteractionsActions m_InteractionsActionsCallbackInterface;
    private readonly InputAction m_Interactions_Interact;
    private readonly InputAction m_Interactions_PauseMenu;
    private readonly InputAction m_Interactions_Continue;
    public struct InteractionsActions
    {
        private @PlayerInputSystem m_Wrapper;
        public InteractionsActions(@PlayerInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_Interactions_Interact;
        public InputAction @PauseMenu => m_Wrapper.m_Interactions_PauseMenu;
        public InputAction @Continue => m_Wrapper.m_Interactions_Continue;
        public InputActionMap Get() { return m_Wrapper.m_Interactions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InteractionsActions set) { return set.Get(); }
        public void SetCallbacks(IInteractionsActions instance)
        {
            if (m_Wrapper.m_InteractionsActionsCallbackInterface != null)
            {
                @Interact.started -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnInteract;
                @PauseMenu.started -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.performed -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.canceled -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnPauseMenu;
                @Continue.started -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnContinue;
                @Continue.performed -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnContinue;
                @Continue.canceled -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnContinue;
            }
            m_Wrapper.m_InteractionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @PauseMenu.started += instance.OnPauseMenu;
                @PauseMenu.performed += instance.OnPauseMenu;
                @PauseMenu.canceled += instance.OnPauseMenu;
                @Continue.started += instance.OnContinue;
                @Continue.performed += instance.OnContinue;
                @Continue.canceled += instance.OnContinue;
            }
        }
    }
    public InteractionsActions @Interactions => new InteractionsActions(this);
    public interface IMovingActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IInteractionsActions
    {
        void OnInteract(InputAction.CallbackContext context);
        void OnPauseMenu(InputAction.CallbackContext context);
        void OnContinue(InputAction.CallbackContext context);
    }
}
