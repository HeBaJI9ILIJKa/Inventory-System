using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class UIQuickAccessMenuSlot : MonoBehaviour, IDropHandler, IBindableSlot
{
    [SerializeField] private UIQuickAccessMenuItem _quickAccessMenuItem;

    public UIQuickAccessMenuItem QuickAccessMenuItem => _quickAccessMenuItem;

    private void Start()
    {
        PlayerInventory.Instance.inventory.OnInventoryStateChangedEvent += OnInventoryStateChanged;
    }

    public void OnDrop(PointerEventData eventData)
    {
        var otherItemUI = eventData.pointerDrag.GetComponent<UIInventoryItem>();

        if (otherItemUI.Item is IUsableItem item)
            _quickAccessMenuItem.SetNewItem(item);
        else
        {
            Debug.Log("Неверный тип предмета");
            return;
        }    
    }

    private void OnInventoryStateChanged(object sender)
    {
        _quickAccessMenuItem.Refresh();
    }

    public void OnBindingUse(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            if (_quickAccessMenuItem.Amount == 0 || _quickAccessMenuItem.Item == null)
                return;

            IUsableItem item = (IUsableItem) PlayerInventory.Instance.inventory.GetItemByTypeID(_quickAccessMenuItem.Item.TypeID);

            item.Use();
        }
    }
}
