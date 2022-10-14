// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/MenuActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MenuActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MenuActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MenuActions"",
    ""maps"": [
        {
            ""name"": ""Exit"",
            ""id"": ""5b6903ae-8fc8-4e05-b24e-09c087e13c32"",
            ""actions"": [
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""abdd3349-0849-43e2-9aaa-e6ccbc0986fa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""53a5bf1a-d554-46e3-ad38-479186f6bfc1"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Exit
        m_Exit = asset.FindActionMap("Exit", throwIfNotFound: true);
        m_Exit_Exit = m_Exit.FindAction("Exit", throwIfNotFound: true);
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

    // Exit
    private readonly InputActionMap m_Exit;
    private IExitActions m_ExitActionsCallbackInterface;
    private readonly InputAction m_Exit_Exit;
    public struct ExitActions
    {
        private @MenuActions m_Wrapper;
        public ExitActions(@MenuActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Exit => m_Wrapper.m_Exit_Exit;
        public InputActionMap Get() { return m_Wrapper.m_Exit; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ExitActions set) { return set.Get(); }
        public void SetCallbacks(IExitActions instance)
        {
            if (m_Wrapper.m_ExitActionsCallbackInterface != null)
            {
                @Exit.started -= m_Wrapper.m_ExitActionsCallbackInterface.OnExit;
                @Exit.performed -= m_Wrapper.m_ExitActionsCallbackInterface.OnExit;
                @Exit.canceled -= m_Wrapper.m_ExitActionsCallbackInterface.OnExit;
            }
            m_Wrapper.m_ExitActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Exit.started += instance.OnExit;
                @Exit.performed += instance.OnExit;
                @Exit.canceled += instance.OnExit;
            }
        }
    }
    public ExitActions @Exit => new ExitActions(this);
    public interface IExitActions
    {
        void OnExit(InputAction.CallbackContext context);
    }
}
