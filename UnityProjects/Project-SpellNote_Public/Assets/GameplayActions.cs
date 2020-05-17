// GENERATED AUTOMATICALLY FROM 'Assets/GameplayActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameplayActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameplayActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameplayActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""7b261b45-f72e-4921-86ba-6d418ecf1e7b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""099f7a1e-98f7-499b-907c-5dc15e2e50ab"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""b5229bb1-1f62-4a89-85e2-ad08bace5330"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""04312203-cfe1-438f-aa03-5fb68de52965"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Note"",
                    ""type"": ""Button"",
                    ""id"": ""979b9de4-2044-405d-884e-e83a0c87e0e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrintLog"",
                    ""type"": ""Button"",
                    ""id"": ""2de3b685-23f6-478f-b277-08327921ecee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WipeLog"",
                    ""type"": ""Button"",
                    ""id"": ""b3ae5ce3-56d3-492f-a6b5-8e500c694b44"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TestAction"",
                    ""type"": ""Button"",
                    ""id"": ""0ba54068-11da-4740-922b-d9edf680b4d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GoFlat"",
                    ""type"": ""Button"",
                    ""id"": ""3e67d453-9acf-45b8-baa6-2b641b39355b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GoSharp"",
                    ""type"": ""Button"",
                    ""id"": ""768e8f48-5a03-4a27-816e-4e0007dd3dc6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""978bfe49-cc26-4a3d-ab7b-7d7a29327403"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""00ca640b-d935-4593-8157-c05846ea39b3"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e2062cb9-1b15-46a2-838c-2f8d72a0bdd9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8180e8bd-4097-4f4e-ab88-4523101a6ce9"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""320bffee-a40b-4347-ac70-c210eb8bc73a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1c5327b5-f71c-4f60-99c7-4e737386f1d1"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d2581a9b-1d11-4566-b27d-b92aff5fabbc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2e46982e-44cc-431b-9f0b-c11910bf467a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fcfe95b8-67b9-4526-84b5-5d0bc98d6400"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""77bff152-3580-4b21-b6de-dcd0c7e41164"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1635d3fe-58b6-4ba9-a4e2-f4b964f6b5c8"",
                    ""path"": ""<XRController>/{Primary2DAxis}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ea4d645-4504-4529-b061-ab81934c3752"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1f7a91b-d0fd-4a62-997e-7fb9b69bf235"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c8e490b-c610-4785-884f-f04217b23ca4"",
                    ""path"": ""<Pointer>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse;Touch"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e5f5442-8668-4b27-a940-df99bad7e831"",
                    ""path"": ""<Joystick>/{Hatswitch}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""143bb1cd-cc10-4eca-a2f0-a3664166fe91"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05f6913d-c316-48b2-a6bb-e225f14c7960"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""886e731e-7071-4ae4-95c0-e61739dad6fd"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee3d0cd2-254e-47a7-a8cb-bc94d9658c54"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8255d333-5683-4943-a58a-ccb207ff1dce"",
                    ""path"": ""<XRController>/{PrimaryAction}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b25c73e-62af-4b40-a6f4-53fd5829119a"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Note"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94eedfd6-3828-4ae3-b11e-b694240131fb"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Note"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e46bd017-489d-481f-b2aa-b432db4b76b0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""PrintLog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5464548-6899-490f-b8e3-2252c56f85ea"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""PrintLog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6de6beb-fc5d-494d-a127-d714c8d7b30a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""WipeLog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba2988cb-25ae-46cf-acc1-7b340faf988b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""TestAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eebe7323-83ae-485d-a79d-d05a5fccd6c1"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoFlat"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6688bddb-dc39-456a-8a84-eaeb9efbb976"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoSharp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""5858215b-df9c-4055-9d3e-7501bfdbe365"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""81ec30a2-5ce3-47e2-9bde-c1181faf24c3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""b0e4ec00-a2b3-4840-91a7-2d2e7dfd4cce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""cb47d5d4-0ffa-4921-ac4f-8be9dd5ad805"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""df3c81a5-9d33-4d41-b239-aaefe0601446"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""50a31220-77be-4fc5-842d-8ca4b75efd55"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ca7c3c47-5b47-4d45-95aa-e863819a25c6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a2766da0-2bb6-4c79-99ae-4af506aa6b36"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bc5c0cd9-f519-4ba0-898a-9247c3af2308"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDevicePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""86b632a6-3c5c-4c4a-8e7a-682d8948cfea"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDeviceOrientation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0f8de60c-b34a-4300-973b-012719927a01"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""809f371f-c5e2-4e7a-83a1-d867598f40dd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""14a5d6e8-4aaf-4119-a9ef-34b8c2c548bf"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9144cbe6-05e1-4687-a6d7-24f99d23dd81"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2db08d65-c5fb-421b-983f-c71163608d67"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""58748904-2ea9-4a80-8579-b500e6a76df8"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8ba04515-75aa-45de-966d-393d9bbd1c14"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""712e721c-bdfb-4b23-a86c-a0d9fcfea921"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fcd248ae-a788-4676-a12e-f4d81205600b"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1f04d9bc-c50b-41a1-bfcc-afb75475ec20"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fb8277d4-c5cd-4663-9dc7-ee3f0b506d90"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Joystick"",
                    ""id"": ""e25d9774-381c-4a61-b47c-7b6b299ad9f9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3db53b26-6601-41be-9887-63ac74e79d19"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0cb3e13e-3d90-4178-8ae6-d9c5501d653f"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0392d399-f6dd-4c82-8062-c1e9c0d34835"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""942a66d9-d42f-43d6-8d70-ecb4ba5363bc"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""ff527021-f211-4c02-933e-5976594c46ed"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""563fbfdd-0f09-408d-aa75-8642c4f08ef0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""eb480147-c587-4a33-85ed-eb0ab9942c43"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2bf42165-60bc-42ca-8072-8c13ab40239b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""85d264ad-e0a0-4565-b7ff-1a37edde51ac"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""74214943-c580-44e4-98eb-ad7eebe17902"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cea9b045-a000-445b-95b8-0c171af70a3b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8607c725-d935-4808-84b1-8354e29bab63"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4cda81dc-9edd-4e03-9d7c-a71a14345d0b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9e92bb26-7e3b-4ec4-b06b-3c8f8e498ddc"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82627dcc-3b13-4ba9-841d-e4b746d6553e"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c52c8e0b-8179-41d3-b8a1-d149033bbe86"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1394cbc-336e-44ce-9ea8-6007ed6193f7"",
                    ""path"": ""<Pen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5693e57a-238a-46ed-b5ae-e64e6e574302"",
                    ""path"": ""<Touchscreen>/touch*/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4faf7dc9-b979-4210-aa8c-e808e1ef89f5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d66d5ba-88d7-48e6-b1cd-198bbfef7ace"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47c2a644-3ebc-4dae-a106-589b7ca75b59"",
                    ""path"": ""<Touchscreen>/touch*/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb9e6b34-44bf-4381-ac63-5aa15d19f677"",
                    ""path"": ""<XRController>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38c99815-14ea-4617-8627-164d27641299"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24066f69-da47-44f3-a07e-0015fb02eb2e"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c191405-5738-4d4b-a523-c6a301dbf754"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7236c0d9-6ca3-47cf-a6ee-a97f5b59ea77"",
                    ""path"": ""<XRController>/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDevicePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23e01e3a-f935-4948-8d8b-9bcac77714fb"",
                    ""path"": ""<XRController>/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDeviceOrientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player1"",
            ""id"": ""8c26bb07-b083-4ca6-b691-8b053f85f67f"",
            ""actions"": [
                {
                    ""name"": ""oSharp2"",
                    ""type"": ""Button"",
                    ""id"": ""e7567eab-25f2-43de-be2d-7e5225d6b105"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""dSharp2"",
                    ""type"": ""Button"",
                    ""id"": ""07873eb3-1319-482c-b093-01df22421251"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""oFlat2"",
                    ""type"": ""Button"",
                    ""id"": ""3fb330f3-2fc9-45f1-bba5-bec964ea88e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""dFlat2"",
                    ""type"": ""Button"",
                    ""id"": ""c10b3a0b-9cba-4d5f-8789-fc0dacd9ac3c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""oSharp1dFlat1"",
                    ""type"": ""Button"",
                    ""id"": ""270cb5d0-87a2-4ef4-9826-df2b244f3b4c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""oSharp1dSharp1"",
                    ""type"": ""Button"",
                    ""id"": ""6f7d4dbc-94a3-46e0-8d3a-59274d012964"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""oFlat1dSharp1"",
                    ""type"": ""Button"",
                    ""id"": ""e5dc7832-df3c-4992-8af2-e1a4996b3f32"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""oFlat1dFlat1"",
                    ""type"": ""Button"",
                    ""id"": ""637f37f1-860e-4930-8412-5fc4f6c51564"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""716880eb-2e26-4a20-aa7e-2ff235fec501"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""oSharp2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""adf39d9d-4a6d-45e8-acf4-b28542ac9f78"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""dSharp2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ff7c489-410a-40ce-a387-92e1fa59758e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""oFlat2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28f1aea0-09d9-4172-9056-203b79bfee69"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""dFlat2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ca696b6-da03-4bb6-a7ac-acf2abd47886"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""oSharp1dFlat1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""799df912-0a3a-4ae7-be4e-d0993aea610b"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""oFlat1dSharp1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81832552-e0fc-4531-b1ef-f966399c3434"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""oSharp1dSharp1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""465d1e96-a50a-4d1c-bc8f-2a55e7c3b780"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""oFlat1dFlat1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player2"",
            ""id"": ""9ae72605-4d6b-4061-952e-15fcb729b81c"",
            ""actions"": [
                {
                    ""name"": ""oSharp2"",
                    ""type"": ""Button"",
                    ""id"": ""6a0d10c1-17f6-4108-88d6-1b5e9d53275e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""dSharp2"",
                    ""type"": ""Button"",
                    ""id"": ""8fdbf30c-06fe-48c7-9d5d-558ac010d1b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""oFlat2"",
                    ""type"": ""Button"",
                    ""id"": ""c85d5fb7-3c27-4873-b508-fa5267ec97b6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""dFlat2"",
                    ""type"": ""Button"",
                    ""id"": ""cbb6806a-295e-44a4-922c-5f9b3ffef7cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""oSharp1dFlat1"",
                    ""type"": ""Button"",
                    ""id"": ""5d166259-c6c1-41d9-9acf-aae3f2884bc2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""oSharp1dSharp1"",
                    ""type"": ""Button"",
                    ""id"": ""44f473f1-4916-4f26-8fab-f4bdaefbc108"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""oFlat1dSharp1"",
                    ""type"": ""Button"",
                    ""id"": ""c5aa824e-99ba-4f26-81f2-eb1ac2dd6b2b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""oFlat1dFlat1"",
                    ""type"": ""Button"",
                    ""id"": ""dd0293db-7127-4aa9-9c49-821fb8ce9fef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""be7812b6-f050-44f2-b8e0-7978e439d66b"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""oSharp2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4717fab2-c6ee-4d05-ba59-ed2a97ec4f56"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""dSharp2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10d2356c-dc49-4f76-928b-787bda23fe21"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""oFlat2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7aa3a98d-0824-49c1-8370-1ea8065eebe6"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""dFlat2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1349344e-91f1-4e26-b30a-8361e93c9a66"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""oSharp1dFlat1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d4f83e0-9810-4e0d-bda6-8a8e7d89ebdb"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""oFlat1dSharp1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""44853a31-f750-4db5-abd3-0db8da7d7fb6"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""oSharp1dSharp1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ffcfddef-302c-412e-838d-42118d34d958"",
                    ""path"": ""<Keyboard>/semicolon"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""oFlat1dFlat1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_Fire = m_Player.FindAction("Fire", throwIfNotFound: true);
        m_Player_Note = m_Player.FindAction("Note", throwIfNotFound: true);
        m_Player_PrintLog = m_Player.FindAction("PrintLog", throwIfNotFound: true);
        m_Player_WipeLog = m_Player.FindAction("WipeLog", throwIfNotFound: true);
        m_Player_TestAction = m_Player.FindAction("TestAction", throwIfNotFound: true);
        m_Player_GoFlat = m_Player.FindAction("GoFlat", throwIfNotFound: true);
        m_Player_GoSharp = m_Player.FindAction("GoSharp", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Navigate = m_UI.FindAction("Navigate", throwIfNotFound: true);
        m_UI_Submit = m_UI.FindAction("Submit", throwIfNotFound: true);
        m_UI_Cancel = m_UI.FindAction("Cancel", throwIfNotFound: true);
        m_UI_Point = m_UI.FindAction("Point", throwIfNotFound: true);
        m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
        m_UI_ScrollWheel = m_UI.FindAction("ScrollWheel", throwIfNotFound: true);
        m_UI_MiddleClick = m_UI.FindAction("MiddleClick", throwIfNotFound: true);
        m_UI_RightClick = m_UI.FindAction("RightClick", throwIfNotFound: true);
        m_UI_TrackedDevicePosition = m_UI.FindAction("TrackedDevicePosition", throwIfNotFound: true);
        m_UI_TrackedDeviceOrientation = m_UI.FindAction("TrackedDeviceOrientation", throwIfNotFound: true);
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_oSharp2 = m_Player1.FindAction("oSharp2", throwIfNotFound: true);
        m_Player1_dSharp2 = m_Player1.FindAction("dSharp2", throwIfNotFound: true);
        m_Player1_oFlat2 = m_Player1.FindAction("oFlat2", throwIfNotFound: true);
        m_Player1_dFlat2 = m_Player1.FindAction("dFlat2", throwIfNotFound: true);
        m_Player1_oSharp1dFlat1 = m_Player1.FindAction("oSharp1dFlat1", throwIfNotFound: true);
        m_Player1_oSharp1dSharp1 = m_Player1.FindAction("oSharp1dSharp1", throwIfNotFound: true);
        m_Player1_oFlat1dSharp1 = m_Player1.FindAction("oFlat1dSharp1", throwIfNotFound: true);
        m_Player1_oFlat1dFlat1 = m_Player1.FindAction("oFlat1dFlat1", throwIfNotFound: true);
        // Player2
        m_Player2 = asset.FindActionMap("Player2", throwIfNotFound: true);
        m_Player2_oSharp2 = m_Player2.FindAction("oSharp2", throwIfNotFound: true);
        m_Player2_dSharp2 = m_Player2.FindAction("dSharp2", throwIfNotFound: true);
        m_Player2_oFlat2 = m_Player2.FindAction("oFlat2", throwIfNotFound: true);
        m_Player2_dFlat2 = m_Player2.FindAction("dFlat2", throwIfNotFound: true);
        m_Player2_oSharp1dFlat1 = m_Player2.FindAction("oSharp1dFlat1", throwIfNotFound: true);
        m_Player2_oSharp1dSharp1 = m_Player2.FindAction("oSharp1dSharp1", throwIfNotFound: true);
        m_Player2_oFlat1dSharp1 = m_Player2.FindAction("oFlat1dSharp1", throwIfNotFound: true);
        m_Player2_oFlat1dFlat1 = m_Player2.FindAction("oFlat1dFlat1", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_Fire;
    private readonly InputAction m_Player_Note;
    private readonly InputAction m_Player_PrintLog;
    private readonly InputAction m_Player_WipeLog;
    private readonly InputAction m_Player_TestAction;
    private readonly InputAction m_Player_GoFlat;
    private readonly InputAction m_Player_GoSharp;
    public struct PlayerActions
    {
        private @GameplayActions m_Wrapper;
        public PlayerActions(@GameplayActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Fire => m_Wrapper.m_Player_Fire;
        public InputAction @Note => m_Wrapper.m_Player_Note;
        public InputAction @PrintLog => m_Wrapper.m_Player_PrintLog;
        public InputAction @WipeLog => m_Wrapper.m_Player_WipeLog;
        public InputAction @TestAction => m_Wrapper.m_Player_TestAction;
        public InputAction @GoFlat => m_Wrapper.m_Player_GoFlat;
        public InputAction @GoSharp => m_Wrapper.m_Player_GoSharp;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Fire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Note.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNote;
                @Note.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNote;
                @Note.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNote;
                @PrintLog.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPrintLog;
                @PrintLog.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPrintLog;
                @PrintLog.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPrintLog;
                @WipeLog.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWipeLog;
                @WipeLog.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWipeLog;
                @WipeLog.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWipeLog;
                @TestAction.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTestAction;
                @TestAction.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTestAction;
                @TestAction.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTestAction;
                @GoFlat.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGoFlat;
                @GoFlat.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGoFlat;
                @GoFlat.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGoFlat;
                @GoSharp.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGoSharp;
                @GoSharp.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGoSharp;
                @GoSharp.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGoSharp;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Note.started += instance.OnNote;
                @Note.performed += instance.OnNote;
                @Note.canceled += instance.OnNote;
                @PrintLog.started += instance.OnPrintLog;
                @PrintLog.performed += instance.OnPrintLog;
                @PrintLog.canceled += instance.OnPrintLog;
                @WipeLog.started += instance.OnWipeLog;
                @WipeLog.performed += instance.OnWipeLog;
                @WipeLog.canceled += instance.OnWipeLog;
                @TestAction.started += instance.OnTestAction;
                @TestAction.performed += instance.OnTestAction;
                @TestAction.canceled += instance.OnTestAction;
                @GoFlat.started += instance.OnGoFlat;
                @GoFlat.performed += instance.OnGoFlat;
                @GoFlat.canceled += instance.OnGoFlat;
                @GoSharp.started += instance.OnGoSharp;
                @GoSharp.performed += instance.OnGoSharp;
                @GoSharp.canceled += instance.OnGoSharp;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Navigate;
    private readonly InputAction m_UI_Submit;
    private readonly InputAction m_UI_Cancel;
    private readonly InputAction m_UI_Point;
    private readonly InputAction m_UI_Click;
    private readonly InputAction m_UI_ScrollWheel;
    private readonly InputAction m_UI_MiddleClick;
    private readonly InputAction m_UI_RightClick;
    private readonly InputAction m_UI_TrackedDevicePosition;
    private readonly InputAction m_UI_TrackedDeviceOrientation;
    public struct UIActions
    {
        private @GameplayActions m_Wrapper;
        public UIActions(@GameplayActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigate => m_Wrapper.m_UI_Navigate;
        public InputAction @Submit => m_Wrapper.m_UI_Submit;
        public InputAction @Cancel => m_Wrapper.m_UI_Cancel;
        public InputAction @Point => m_Wrapper.m_UI_Point;
        public InputAction @Click => m_Wrapper.m_UI_Click;
        public InputAction @ScrollWheel => m_Wrapper.m_UI_ScrollWheel;
        public InputAction @MiddleClick => m_Wrapper.m_UI_MiddleClick;
        public InputAction @RightClick => m_Wrapper.m_UI_RightClick;
        public InputAction @TrackedDevicePosition => m_Wrapper.m_UI_TrackedDevicePosition;
        public InputAction @TrackedDeviceOrientation => m_Wrapper.m_UI_TrackedDeviceOrientation;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Navigate.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Submit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Cancel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Point.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @ScrollWheel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @MiddleClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @RightClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @TrackedDevicePosition.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @ScrollWheel.started += instance.OnScrollWheel;
                @ScrollWheel.performed += instance.OnScrollWheel;
                @ScrollWheel.canceled += instance.OnScrollWheel;
                @MiddleClick.started += instance.OnMiddleClick;
                @MiddleClick.performed += instance.OnMiddleClick;
                @MiddleClick.canceled += instance.OnMiddleClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @TrackedDevicePosition.started += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled += instance.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled += instance.OnTrackedDeviceOrientation;
            }
        }
    }
    public UIActions @UI => new UIActions(this);

    // Player1
    private readonly InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_Player1_oSharp2;
    private readonly InputAction m_Player1_dSharp2;
    private readonly InputAction m_Player1_oFlat2;
    private readonly InputAction m_Player1_dFlat2;
    private readonly InputAction m_Player1_oSharp1dFlat1;
    private readonly InputAction m_Player1_oSharp1dSharp1;
    private readonly InputAction m_Player1_oFlat1dSharp1;
    private readonly InputAction m_Player1_oFlat1dFlat1;
    public struct Player1Actions
    {
        private @GameplayActions m_Wrapper;
        public Player1Actions(@GameplayActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @oSharp2 => m_Wrapper.m_Player1_oSharp2;
        public InputAction @dSharp2 => m_Wrapper.m_Player1_dSharp2;
        public InputAction @oFlat2 => m_Wrapper.m_Player1_oFlat2;
        public InputAction @dFlat2 => m_Wrapper.m_Player1_dFlat2;
        public InputAction @oSharp1dFlat1 => m_Wrapper.m_Player1_oSharp1dFlat1;
        public InputAction @oSharp1dSharp1 => m_Wrapper.m_Player1_oSharp1dSharp1;
        public InputAction @oFlat1dSharp1 => m_Wrapper.m_Player1_oFlat1dSharp1;
        public InputAction @oFlat1dFlat1 => m_Wrapper.m_Player1_oFlat1dFlat1;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                @oSharp2.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnOSharp2;
                @oSharp2.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnOSharp2;
                @oSharp2.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnOSharp2;
                @dSharp2.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDSharp2;
                @dSharp2.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDSharp2;
                @dSharp2.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDSharp2;
                @oFlat2.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnOFlat2;
                @oFlat2.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnOFlat2;
                @oFlat2.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnOFlat2;
                @dFlat2.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDFlat2;
                @dFlat2.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDFlat2;
                @dFlat2.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDFlat2;
                @oSharp1dFlat1.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnOSharp1dFlat1;
                @oSharp1dFlat1.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnOSharp1dFlat1;
                @oSharp1dFlat1.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnOSharp1dFlat1;
                @oSharp1dSharp1.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnOSharp1dSharp1;
                @oSharp1dSharp1.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnOSharp1dSharp1;
                @oSharp1dSharp1.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnOSharp1dSharp1;
                @oFlat1dSharp1.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnOFlat1dSharp1;
                @oFlat1dSharp1.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnOFlat1dSharp1;
                @oFlat1dSharp1.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnOFlat1dSharp1;
                @oFlat1dFlat1.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnOFlat1dFlat1;
                @oFlat1dFlat1.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnOFlat1dFlat1;
                @oFlat1dFlat1.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnOFlat1dFlat1;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @oSharp2.started += instance.OnOSharp2;
                @oSharp2.performed += instance.OnOSharp2;
                @oSharp2.canceled += instance.OnOSharp2;
                @dSharp2.started += instance.OnDSharp2;
                @dSharp2.performed += instance.OnDSharp2;
                @dSharp2.canceled += instance.OnDSharp2;
                @oFlat2.started += instance.OnOFlat2;
                @oFlat2.performed += instance.OnOFlat2;
                @oFlat2.canceled += instance.OnOFlat2;
                @dFlat2.started += instance.OnDFlat2;
                @dFlat2.performed += instance.OnDFlat2;
                @dFlat2.canceled += instance.OnDFlat2;
                @oSharp1dFlat1.started += instance.OnOSharp1dFlat1;
                @oSharp1dFlat1.performed += instance.OnOSharp1dFlat1;
                @oSharp1dFlat1.canceled += instance.OnOSharp1dFlat1;
                @oSharp1dSharp1.started += instance.OnOSharp1dSharp1;
                @oSharp1dSharp1.performed += instance.OnOSharp1dSharp1;
                @oSharp1dSharp1.canceled += instance.OnOSharp1dSharp1;
                @oFlat1dSharp1.started += instance.OnOFlat1dSharp1;
                @oFlat1dSharp1.performed += instance.OnOFlat1dSharp1;
                @oFlat1dSharp1.canceled += instance.OnOFlat1dSharp1;
                @oFlat1dFlat1.started += instance.OnOFlat1dFlat1;
                @oFlat1dFlat1.performed += instance.OnOFlat1dFlat1;
                @oFlat1dFlat1.canceled += instance.OnOFlat1dFlat1;
            }
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);

    // Player2
    private readonly InputActionMap m_Player2;
    private IPlayer2Actions m_Player2ActionsCallbackInterface;
    private readonly InputAction m_Player2_oSharp2;
    private readonly InputAction m_Player2_dSharp2;
    private readonly InputAction m_Player2_oFlat2;
    private readonly InputAction m_Player2_dFlat2;
    private readonly InputAction m_Player2_oSharp1dFlat1;
    private readonly InputAction m_Player2_oSharp1dSharp1;
    private readonly InputAction m_Player2_oFlat1dSharp1;
    private readonly InputAction m_Player2_oFlat1dFlat1;
    public struct Player2Actions
    {
        private @GameplayActions m_Wrapper;
        public Player2Actions(@GameplayActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @oSharp2 => m_Wrapper.m_Player2_oSharp2;
        public InputAction @dSharp2 => m_Wrapper.m_Player2_dSharp2;
        public InputAction @oFlat2 => m_Wrapper.m_Player2_oFlat2;
        public InputAction @dFlat2 => m_Wrapper.m_Player2_dFlat2;
        public InputAction @oSharp1dFlat1 => m_Wrapper.m_Player2_oSharp1dFlat1;
        public InputAction @oSharp1dSharp1 => m_Wrapper.m_Player2_oSharp1dSharp1;
        public InputAction @oFlat1dSharp1 => m_Wrapper.m_Player2_oFlat1dSharp1;
        public InputAction @oFlat1dFlat1 => m_Wrapper.m_Player2_oFlat1dFlat1;
        public InputActionMap Get() { return m_Wrapper.m_Player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2Actions instance)
        {
            if (m_Wrapper.m_Player2ActionsCallbackInterface != null)
            {
                @oSharp2.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnOSharp2;
                @oSharp2.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnOSharp2;
                @oSharp2.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnOSharp2;
                @dSharp2.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDSharp2;
                @dSharp2.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDSharp2;
                @dSharp2.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDSharp2;
                @oFlat2.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnOFlat2;
                @oFlat2.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnOFlat2;
                @oFlat2.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnOFlat2;
                @dFlat2.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDFlat2;
                @dFlat2.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDFlat2;
                @dFlat2.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDFlat2;
                @oSharp1dFlat1.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnOSharp1dFlat1;
                @oSharp1dFlat1.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnOSharp1dFlat1;
                @oSharp1dFlat1.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnOSharp1dFlat1;
                @oSharp1dSharp1.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnOSharp1dSharp1;
                @oSharp1dSharp1.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnOSharp1dSharp1;
                @oSharp1dSharp1.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnOSharp1dSharp1;
                @oFlat1dSharp1.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnOFlat1dSharp1;
                @oFlat1dSharp1.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnOFlat1dSharp1;
                @oFlat1dSharp1.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnOFlat1dSharp1;
                @oFlat1dFlat1.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnOFlat1dFlat1;
                @oFlat1dFlat1.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnOFlat1dFlat1;
                @oFlat1dFlat1.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnOFlat1dFlat1;
            }
            m_Wrapper.m_Player2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @oSharp2.started += instance.OnOSharp2;
                @oSharp2.performed += instance.OnOSharp2;
                @oSharp2.canceled += instance.OnOSharp2;
                @dSharp2.started += instance.OnDSharp2;
                @dSharp2.performed += instance.OnDSharp2;
                @dSharp2.canceled += instance.OnDSharp2;
                @oFlat2.started += instance.OnOFlat2;
                @oFlat2.performed += instance.OnOFlat2;
                @oFlat2.canceled += instance.OnOFlat2;
                @dFlat2.started += instance.OnDFlat2;
                @dFlat2.performed += instance.OnDFlat2;
                @dFlat2.canceled += instance.OnDFlat2;
                @oSharp1dFlat1.started += instance.OnOSharp1dFlat1;
                @oSharp1dFlat1.performed += instance.OnOSharp1dFlat1;
                @oSharp1dFlat1.canceled += instance.OnOSharp1dFlat1;
                @oSharp1dSharp1.started += instance.OnOSharp1dSharp1;
                @oSharp1dSharp1.performed += instance.OnOSharp1dSharp1;
                @oSharp1dSharp1.canceled += instance.OnOSharp1dSharp1;
                @oFlat1dSharp1.started += instance.OnOFlat1dSharp1;
                @oFlat1dSharp1.performed += instance.OnOFlat1dSharp1;
                @oFlat1dSharp1.canceled += instance.OnOFlat1dSharp1;
                @oFlat1dFlat1.started += instance.OnOFlat1dFlat1;
                @oFlat1dFlat1.performed += instance.OnOFlat1dFlat1;
                @oFlat1dFlat1.canceled += instance.OnOFlat1dFlat1;
            }
        }
    }
    public Player2Actions @Player2 => new Player2Actions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnNote(InputAction.CallbackContext context);
        void OnPrintLog(InputAction.CallbackContext context);
        void OnWipeLog(InputAction.CallbackContext context);
        void OnTestAction(InputAction.CallbackContext context);
        void OnGoFlat(InputAction.CallbackContext context);
        void OnGoSharp(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnScrollWheel(InputAction.CallbackContext context);
        void OnMiddleClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnTrackedDevicePosition(InputAction.CallbackContext context);
        void OnTrackedDeviceOrientation(InputAction.CallbackContext context);
    }
    public interface IPlayer1Actions
    {
        void OnOSharp2(InputAction.CallbackContext context);
        void OnDSharp2(InputAction.CallbackContext context);
        void OnOFlat2(InputAction.CallbackContext context);
        void OnDFlat2(InputAction.CallbackContext context);
        void OnOSharp1dFlat1(InputAction.CallbackContext context);
        void OnOSharp1dSharp1(InputAction.CallbackContext context);
        void OnOFlat1dSharp1(InputAction.CallbackContext context);
        void OnOFlat1dFlat1(InputAction.CallbackContext context);
    }
    public interface IPlayer2Actions
    {
        void OnOSharp2(InputAction.CallbackContext context);
        void OnDSharp2(InputAction.CallbackContext context);
        void OnOFlat2(InputAction.CallbackContext context);
        void OnDFlat2(InputAction.CallbackContext context);
        void OnOSharp1dFlat1(InputAction.CallbackContext context);
        void OnOSharp1dSharp1(InputAction.CallbackContext context);
        void OnOFlat1dSharp1(InputAction.CallbackContext context);
        void OnOFlat1dFlat1(InputAction.CallbackContext context);
    }
}
