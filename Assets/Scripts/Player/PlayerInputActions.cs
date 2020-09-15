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
                },
                {
                    ""name"": ""Move3"",
                    ""type"": ""Button"",
                    ""id"": ""08f1cddb-b92e-4303-8bdb-9008ff932ba4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JumpFall3"",
                    ""type"": ""Button"",
                    ""id"": ""5dc9d1bd-5241-4d2d-88aa-16d374de8b5d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move4"",
                    ""type"": ""Button"",
                    ""id"": ""d487ff7d-bf94-4d79-820c-10f475e455fe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JumpFall4"",
                    ""type"": ""Button"",
                    ""id"": ""7649ac50-06ce-4c18-9954-beb77d173d19"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move5"",
                    ""type"": ""Button"",
                    ""id"": ""fd9a08bf-58ea-4756-8eef-516354a05be3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JumpFall5"",
                    ""type"": ""Button"",
                    ""id"": ""f2e47113-3db2-4419-aed4-7b044eb41c21"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move6"",
                    ""type"": ""Button"",
                    ""id"": ""31c8f467-508b-4716-afaa-6779c3d2e28c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JumpFall6"",
                    ""type"": ""Button"",
                    ""id"": ""4dfd0322-cdf0-4651-b61c-4f53b3ab9a85"",
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
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""9fd3e5ae-ad48-47d6-a9dd-37abcfe5ed20"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move3"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5f782750-d750-49cb-8e0c-6458d6d1de9e"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""95ce5438-b8c0-45bc-8cdc-7025e100320d"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""a5f59eda-c5f3-4149-9f0e-0e5423c99ccc"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpFall3"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""47783072-dd39-4851-af23-c76a72265d5e"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpFall3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b847644d-ce02-4cca-b0e4-4ac0cdc9a4dd"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpFall3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""01df3329-efe3-435d-b400-8f330c7ff722"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move4"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""adcc2c75-76d0-4944-9429-ee5881c62f2e"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""128c59d6-b0ea-4288-bb44-f8d220f27888"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""b476df8b-7513-4ee0-85ce-eacd452e1208"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpFall4"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5512b618-1545-4684-a7ff-918a9d4e7972"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpFall4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""53622547-2ee4-482d-8e29-382bd05b71e4"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpFall4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""fbc1ed11-c2fc-421f-af76-72ea41003f3c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move5"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5bb6ac28-57b3-4685-9c93-203cab170ef5"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e60b8fb2-594a-45c9-89e1-dbe51bd3cd9b"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""29b793c8-8863-45ab-9ff1-92fd21518f8c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpFall5"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a7693743-23f3-40db-9c77-b7d344063ca0"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpFall5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e35dbfc1-a1be-4cf8-af62-e95c7d345bc6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpFall5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""f6615e92-64a4-4ea5-bff3-7a8fae0edab6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move6"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""665a54b1-8fb0-4f37-97ad-d0998d5d1737"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move6"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b3969ae4-940a-47c9-b518-36dcc025fe65"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move6"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""14fe5af5-e00f-440c-a964-c1fd85f5df0f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpFall6"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a0a524ca-41b9-40ea-a6bd-64c139f29434"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpFall6"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a341396d-631d-4f6b-a9a0-d633bb77dfc3"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpFall6"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""5a33926f-4ccd-4e2a-994b-4bf44f87990c"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""4bddee0c-70ad-4cfc-b7ef-12885b17df5b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""ab60592d-896c-4585-9f8a-e1628d9d6774"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Return"",
                    ""type"": ""Button"",
                    ""id"": ""dca6632c-194d-43d4-a9d8-c17e06c5079b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""a0e6b306-ce72-48f3-9736-fd06ea9482ec"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""21d0bd2f-9dda-448a-990f-b2f15b6009d2"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""af6fe7a3-0c6d-4e22-870e-fb3ee3258481"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""70203d51-f98e-4118-94e8-4d738dbeed51"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1451ebce-9100-42b8-9419-116f0ac1fa29"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Return"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
        m_PlayerControls_Move3 = m_PlayerControls.FindAction("Move3", throwIfNotFound: true);
        m_PlayerControls_JumpFall3 = m_PlayerControls.FindAction("JumpFall3", throwIfNotFound: true);
        m_PlayerControls_Move4 = m_PlayerControls.FindAction("Move4", throwIfNotFound: true);
        m_PlayerControls_JumpFall4 = m_PlayerControls.FindAction("JumpFall4", throwIfNotFound: true);
        m_PlayerControls_Move5 = m_PlayerControls.FindAction("Move5", throwIfNotFound: true);
        m_PlayerControls_JumpFall5 = m_PlayerControls.FindAction("JumpFall5", throwIfNotFound: true);
        m_PlayerControls_Move6 = m_PlayerControls.FindAction("Move6", throwIfNotFound: true);
        m_PlayerControls_JumpFall6 = m_PlayerControls.FindAction("JumpFall6", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Move = m_UI.FindAction("Move", throwIfNotFound: true);
        m_UI_Select = m_UI.FindAction("Select", throwIfNotFound: true);
        m_UI_Return = m_UI.FindAction("Return", throwIfNotFound: true);
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
    private readonly InputAction m_PlayerControls_Move3;
    private readonly InputAction m_PlayerControls_JumpFall3;
    private readonly InputAction m_PlayerControls_Move4;
    private readonly InputAction m_PlayerControls_JumpFall4;
    private readonly InputAction m_PlayerControls_Move5;
    private readonly InputAction m_PlayerControls_JumpFall5;
    private readonly InputAction m_PlayerControls_Move6;
    private readonly InputAction m_PlayerControls_JumpFall6;
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
        public InputAction @Move3 => m_Wrapper.m_PlayerControls_Move3;
        public InputAction @JumpFall3 => m_Wrapper.m_PlayerControls_JumpFall3;
        public InputAction @Move4 => m_Wrapper.m_PlayerControls_Move4;
        public InputAction @JumpFall4 => m_Wrapper.m_PlayerControls_JumpFall4;
        public InputAction @Move5 => m_Wrapper.m_PlayerControls_Move5;
        public InputAction @JumpFall5 => m_Wrapper.m_PlayerControls_JumpFall5;
        public InputAction @Move6 => m_Wrapper.m_PlayerControls_Move6;
        public InputAction @JumpFall6 => m_Wrapper.m_PlayerControls_JumpFall6;
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
                @Move3.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove3;
                @Move3.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove3;
                @Move3.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove3;
                @JumpFall3.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJumpFall3;
                @JumpFall3.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJumpFall3;
                @JumpFall3.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJumpFall3;
                @Move4.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove4;
                @Move4.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove4;
                @Move4.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove4;
                @JumpFall4.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJumpFall4;
                @JumpFall4.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJumpFall4;
                @JumpFall4.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJumpFall4;
                @Move5.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove5;
                @Move5.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove5;
                @Move5.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove5;
                @JumpFall5.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJumpFall5;
                @JumpFall5.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJumpFall5;
                @JumpFall5.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJumpFall5;
                @Move6.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove6;
                @Move6.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove6;
                @Move6.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove6;
                @JumpFall6.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJumpFall6;
                @JumpFall6.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJumpFall6;
                @JumpFall6.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJumpFall6;
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
                @Move3.started += instance.OnMove3;
                @Move3.performed += instance.OnMove3;
                @Move3.canceled += instance.OnMove3;
                @JumpFall3.started += instance.OnJumpFall3;
                @JumpFall3.performed += instance.OnJumpFall3;
                @JumpFall3.canceled += instance.OnJumpFall3;
                @Move4.started += instance.OnMove4;
                @Move4.performed += instance.OnMove4;
                @Move4.canceled += instance.OnMove4;
                @JumpFall4.started += instance.OnJumpFall4;
                @JumpFall4.performed += instance.OnJumpFall4;
                @JumpFall4.canceled += instance.OnJumpFall4;
                @Move5.started += instance.OnMove5;
                @Move5.performed += instance.OnMove5;
                @Move5.canceled += instance.OnMove5;
                @JumpFall5.started += instance.OnJumpFall5;
                @JumpFall5.performed += instance.OnJumpFall5;
                @JumpFall5.canceled += instance.OnJumpFall5;
                @Move6.started += instance.OnMove6;
                @Move6.performed += instance.OnMove6;
                @Move6.canceled += instance.OnMove6;
                @JumpFall6.started += instance.OnJumpFall6;
                @JumpFall6.performed += instance.OnJumpFall6;
                @JumpFall6.canceled += instance.OnJumpFall6;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Move;
    private readonly InputAction m_UI_Select;
    private readonly InputAction m_UI_Return;
    public struct UIActions
    {
        private @PlayerInputActions m_Wrapper;
        public UIActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_UI_Move;
        public InputAction @Select => m_Wrapper.m_UI_Select;
        public InputAction @Return => m_Wrapper.m_UI_Return;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMove;
                @Select.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSelect;
                @Return.started -= m_Wrapper.m_UIActionsCallbackInterface.OnReturn;
                @Return.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnReturn;
                @Return.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnReturn;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Return.started += instance.OnReturn;
                @Return.performed += instance.OnReturn;
                @Return.canceled += instance.OnReturn;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IPlayerControlsActions
    {
        void OnMove1(InputAction.CallbackContext context);
        void OnJumpFall1(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnMove2(InputAction.CallbackContext context);
        void OnJumpFall2(InputAction.CallbackContext context);
        void OnMove3(InputAction.CallbackContext context);
        void OnJumpFall3(InputAction.CallbackContext context);
        void OnMove4(InputAction.CallbackContext context);
        void OnJumpFall4(InputAction.CallbackContext context);
        void OnMove5(InputAction.CallbackContext context);
        void OnJumpFall5(InputAction.CallbackContext context);
        void OnMove6(InputAction.CallbackContext context);
        void OnJumpFall6(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnReturn(InputAction.CallbackContext context);
    }
}
