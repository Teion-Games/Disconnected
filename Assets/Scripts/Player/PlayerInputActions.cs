// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""7b455678-6c08-4a45-b309-3714714e9983"",
            ""actions"": [
                {
                    ""name"": ""Move1"",
                    ""type"": ""Button"",
                    ""id"": ""239b3e9d-aaa4-4a83-b2d0-b6b7206d01a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JumpFall1"",
                    ""type"": ""Button"",
                    ""id"": ""98df2355-11f8-47d5-a010-dc62f423f0a4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""4565f87c-5b61-4545-b9a9-b79461a4de2a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""5f781138-9dea-4251-8425-4e53664229d4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move2"",
                    ""type"": ""Button"",
                    ""id"": ""51946887-7469-491e-9fef-20ea818efb68"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JumpFall2"",
                    ""type"": ""Button"",
                    ""id"": ""ca82cd6c-438e-4166-8423-13e5130c79d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""a26f431c-6831-490a-8dac-d52b16572c62"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c97a9edd-873d-4c56-a477-30e7cbe24832"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ace78200-fb13-4b0b-a5fd-0a903a892763"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""712a4d5f-0ae6-4a79-adb7-869adbd2c91a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Tap(duration=0.5)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpFall1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""65313673-91fc-4288-a95a-abec2b199954"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpFall1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5f97360e-d502-4dd2-99f2-1bce62724b8e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpFall1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""10b3761c-8fe4-4ca9-af34-35f70dd61a10"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ab66f65-d78f-495b-b545-69ee94aaa0f9"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""14e002b0-d1cb-46a7-a2ee-15508b674ad7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move2"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7306f747-1ac1-4666-8a04-9d02d6999d93"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d95d15d3-3b22-4798-ae74-69407f286849"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""0b59c1bc-1b9b-4461-bf52-30eb520b3a96"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Tap(duration=0.5)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpFall2"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5818196b-54cd-4359-b5ae-d7dc90e77030"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpFall2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""adea7078-792f-4f73-9fa2-a5f59b408c3e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpFall2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControls
        m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
        m_PlayerControls_Move1 = m_PlayerControls.FindAction("Move1", throwIfNotFound: true);
        m_PlayerControls_JumpFall1 = m_PlayerControls.FindAction("JumpFall1", throwIfNotFound: true);
        m_PlayerControls_Fire = m_PlayerControls.FindAction("Fire", throwIfNotFound: true);
        m_PlayerControls_Interact = m_PlayerControls.FindAction("Interact", throwIfNotFound: true);
        m_PlayerControls_Move2 = m_PlayerControls.FindAction("Move2", throwIfNotFound: true);
        m_PlayerControls_JumpFall2 = m_PlayerControls.FindAction("JumpFall2", throwIfNotFound: true);
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

    // PlayerControls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_Move1;
    private readonly InputAction m_PlayerControls_JumpFall1;
    private readonly InputAction m_PlayerControls_Fire;
    private readonly InputAction m_PlayerControls_Interact;
    private readonly InputAction m_PlayerControls_Move2;
    private readonly InputAction m_PlayerControls_JumpFall2;
    public struct PlayerControlsActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerControlsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move1 => m_Wrapper.m_PlayerControls_Move1;
        public InputAction @JumpFall1 => m_Wrapper.m_PlayerControls_JumpFall1;
        public InputAction @Fire => m_Wrapper.m_PlayerControls_Fire;
        public InputAction @Interact => m_Wrapper.m_PlayerControls_Interact;
        public InputAction @Move2 => m_Wrapper.m_PlayerControls_Move2;
        public InputAction @JumpFall2 => m_Wrapper.m_PlayerControls_JumpFall2;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @Move1.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove1;
                @Move1.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove1;
                @Move1.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove1;
                @JumpFall1.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJumpFall1;
                @JumpFall1.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJumpFall1;
                @JumpFall1.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJumpFall1;
                @Fire.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnFire;
                @Interact.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInteract;
                @Move2.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove2;
                @Move2.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove2;
                @Move2.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove2;
                @JumpFall2.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJumpFall2;
                @JumpFall2.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJumpFall2;
                @JumpFall2.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJumpFall2;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move1.started += instance.OnMove1;
                @Move1.performed += instance.OnMove1;
                @Move1.canceled += instance.OnMove1;
                @JumpFall1.started += instance.OnJumpFall1;
                @JumpFall1.performed += instance.OnJumpFall1;
                @JumpFall1.canceled += instance.OnJumpFall1;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Move2.started += instance.OnMove2;
                @Move2.performed += instance.OnMove2;
                @Move2.canceled += instance.OnMove2;
                @JumpFall2.started += instance.OnJumpFall2;
                @JumpFall2.performed += instance.OnJumpFall2;
                @JumpFall2.canceled += instance.OnJumpFall2;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
    public interface IPlayerControlsActions
    {
        void OnMove1(InputAction.CallbackContext context);
        void OnJumpFall1(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnMove2(InputAction.CallbackContext context);
        void OnJumpFall2(InputAction.CallbackContext context);
    }
}
