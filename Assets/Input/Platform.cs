//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input/Platform.inputactions
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

public partial class @Platform: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Platform()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Platform"",
    ""maps"": [
        {
            ""name"": ""Platform Move"",
            ""id"": ""a4f9cd05-fb5a-4cf9-9cb9-5accada2feb9"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Value"",
                    ""id"": ""d6f55a06-bd7c-43ca-a749-c9693fdd91ad"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""3a1a5a1f-474b-4c14-bff6-595fc81bb891"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""69210ab2-5bed-46b4-8419-2fb5d918fc5c"",
                    ""path"": ""<Keyboard>/#(A)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""87d5d99f-6062-4fa9-9d6e-4083e2e9c01e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Platform Move
        m_PlatformMove = asset.FindActionMap("Platform Move", throwIfNotFound: true);
        m_PlatformMove_Newaction = m_PlatformMove.FindAction("New action", throwIfNotFound: true);
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

    // Platform Move
    private readonly InputActionMap m_PlatformMove;
    private List<IPlatformMoveActions> m_PlatformMoveActionsCallbackInterfaces = new List<IPlatformMoveActions>();
    private readonly InputAction m_PlatformMove_Newaction;
    public struct PlatformMoveActions
    {
        private @Platform m_Wrapper;
        public PlatformMoveActions(@Platform wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_PlatformMove_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_PlatformMove; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlatformMoveActions set) { return set.Get(); }
        public void AddCallbacks(IPlatformMoveActions instance)
        {
            if (instance == null || m_Wrapper.m_PlatformMoveActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlatformMoveActionsCallbackInterfaces.Add(instance);
            @Newaction.started += instance.OnNewaction;
            @Newaction.performed += instance.OnNewaction;
            @Newaction.canceled += instance.OnNewaction;
        }

        private void UnregisterCallbacks(IPlatformMoveActions instance)
        {
            @Newaction.started -= instance.OnNewaction;
            @Newaction.performed -= instance.OnNewaction;
            @Newaction.canceled -= instance.OnNewaction;
        }

        public void RemoveCallbacks(IPlatformMoveActions instance)
        {
            if (m_Wrapper.m_PlatformMoveActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlatformMoveActions instance)
        {
            foreach (var item in m_Wrapper.m_PlatformMoveActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlatformMoveActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlatformMoveActions @PlatformMove => new PlatformMoveActions(this);
    public interface IPlatformMoveActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
