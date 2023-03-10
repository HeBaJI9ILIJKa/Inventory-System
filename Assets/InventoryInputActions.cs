//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/InventoryInputActions.inputactions
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

public partial class @InventoryInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InventoryInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InventoryInputActions"",
    ""maps"": [
        {
            ""name"": ""Inventory"",
            ""id"": ""edbd0933-33e2-4011-baa3-dfea1c953ad4"",
            ""actions"": [
                {
                    ""name"": ""Open/Close"",
                    ""type"": ""Button"",
                    ""id"": ""e399b6a9-cdda-49ae-83ad-c452f1cdf09a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""UseItemZ"",
                    ""type"": ""Button"",
                    ""id"": ""9ac833e3-cf82-4a6d-b11c-924ff202578e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""UseItemX"",
                    ""type"": ""Button"",
                    ""id"": ""a5366fb8-482b-4387-9bb0-15fa327ef39f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SaveInventory"",
                    ""type"": ""Button"",
                    ""id"": ""9a943a2a-0cbc-42ec-ae4b-81d351c76acc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LoadInventory"",
                    ""type"": ""Button"",
                    ""id"": ""148c51a4-78cb-4113-bb41-2fea02f05068"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""UseGun"",
                    ""type"": ""Button"",
                    ""id"": ""70e7ae69-7d83-4aa7-a2a1-00f4590df01b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""537b0df9-00bb-4214-aa47-83bfd6991b3a"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Open/Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52c28a89-d898-43a2-a9b0-46b874d4c7cb"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UseItemZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45ae50be-8be3-4405-9fcb-9220f759a176"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UseItemX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22caad6f-5013-4773-8b9a-e0128b6878d5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SaveInventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41823d1d-7d96-4f29-bf30-14824cc66fce"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LoadInventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""631a9e2d-ace8-46c9-ac9a-57a448d468f5"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UseGun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Inventory
        m_Inventory = asset.FindActionMap("Inventory", throwIfNotFound: true);
        m_Inventory_OpenClose = m_Inventory.FindAction("Open/Close", throwIfNotFound: true);
        m_Inventory_UseItemZ = m_Inventory.FindAction("UseItemZ", throwIfNotFound: true);
        m_Inventory_UseItemX = m_Inventory.FindAction("UseItemX", throwIfNotFound: true);
        m_Inventory_SaveInventory = m_Inventory.FindAction("SaveInventory", throwIfNotFound: true);
        m_Inventory_LoadInventory = m_Inventory.FindAction("LoadInventory", throwIfNotFound: true);
        m_Inventory_UseGun = m_Inventory.FindAction("UseGun", throwIfNotFound: true);
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

    // Inventory
    private readonly InputActionMap m_Inventory;
    private IInventoryActions m_InventoryActionsCallbackInterface;
    private readonly InputAction m_Inventory_OpenClose;
    private readonly InputAction m_Inventory_UseItemZ;
    private readonly InputAction m_Inventory_UseItemX;
    private readonly InputAction m_Inventory_SaveInventory;
    private readonly InputAction m_Inventory_LoadInventory;
    private readonly InputAction m_Inventory_UseGun;
    public struct InventoryActions
    {
        private @InventoryInputActions m_Wrapper;
        public InventoryActions(@InventoryInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @OpenClose => m_Wrapper.m_Inventory_OpenClose;
        public InputAction @UseItemZ => m_Wrapper.m_Inventory_UseItemZ;
        public InputAction @UseItemX => m_Wrapper.m_Inventory_UseItemX;
        public InputAction @SaveInventory => m_Wrapper.m_Inventory_SaveInventory;
        public InputAction @LoadInventory => m_Wrapper.m_Inventory_LoadInventory;
        public InputAction @UseGun => m_Wrapper.m_Inventory_UseGun;
        public InputActionMap Get() { return m_Wrapper.m_Inventory; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InventoryActions set) { return set.Get(); }
        public void SetCallbacks(IInventoryActions instance)
        {
            if (m_Wrapper.m_InventoryActionsCallbackInterface != null)
            {
                @OpenClose.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnOpenClose;
                @OpenClose.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnOpenClose;
                @OpenClose.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnOpenClose;
                @UseItemZ.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnUseItemZ;
                @UseItemZ.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnUseItemZ;
                @UseItemZ.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnUseItemZ;
                @UseItemX.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnUseItemX;
                @UseItemX.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnUseItemX;
                @UseItemX.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnUseItemX;
                @SaveInventory.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnSaveInventory;
                @SaveInventory.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnSaveInventory;
                @SaveInventory.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnSaveInventory;
                @LoadInventory.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnLoadInventory;
                @LoadInventory.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnLoadInventory;
                @LoadInventory.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnLoadInventory;
                @UseGun.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnUseGun;
                @UseGun.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnUseGun;
                @UseGun.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnUseGun;
            }
            m_Wrapper.m_InventoryActionsCallbackInterface = instance;
            if (instance != null)
            {
                @OpenClose.started += instance.OnOpenClose;
                @OpenClose.performed += instance.OnOpenClose;
                @OpenClose.canceled += instance.OnOpenClose;
                @UseItemZ.started += instance.OnUseItemZ;
                @UseItemZ.performed += instance.OnUseItemZ;
                @UseItemZ.canceled += instance.OnUseItemZ;
                @UseItemX.started += instance.OnUseItemX;
                @UseItemX.performed += instance.OnUseItemX;
                @UseItemX.canceled += instance.OnUseItemX;
                @SaveInventory.started += instance.OnSaveInventory;
                @SaveInventory.performed += instance.OnSaveInventory;
                @SaveInventory.canceled += instance.OnSaveInventory;
                @LoadInventory.started += instance.OnLoadInventory;
                @LoadInventory.performed += instance.OnLoadInventory;
                @LoadInventory.canceled += instance.OnLoadInventory;
                @UseGun.started += instance.OnUseGun;
                @UseGun.performed += instance.OnUseGun;
                @UseGun.canceled += instance.OnUseGun;
            }
        }
    }
    public InventoryActions @Inventory => new InventoryActions(this);
    public interface IInventoryActions
    {
        void OnOpenClose(InputAction.CallbackContext context);
        void OnUseItemZ(InputAction.CallbackContext context);
        void OnUseItemX(InputAction.CallbackContext context);
        void OnSaveInventory(InputAction.CallbackContext context);
        void OnLoadInventory(InputAction.CallbackContext context);
        void OnUseGun(InputAction.CallbackContext context);
    }
}
