using UnityEngine;
using UnityEngine.EventSystems;

public class UIInventorySlot : MonoBehaviour, IDropHandler
{
    [SerializeField] private UIInventoryItem _uiInventoryItem; 

    public IInventorySlot slot { get; private set; }

    private UIInventory _uiInventory;
    public UIInventory UIInventory => _uiInventory;

    private void Awake()
    {
        _uiInventory = GetComponentInParent<UIInventory>();
    }

    public void SetSlot(IInventorySlot newSlot)
    {
        slot = newSlot;
    }

    public virtual void OnDrop(PointerEventData eventData)
    {
        var otherItemUI = eventData.pointerDrag.GetComponent<UIInventoryItem>();
        var otherSlotUI = otherItemUI.GetComponentInParent<UIInventorySlot>();
        var otherSlot = otherSlotUI.slot;
        var inventory = _uiInventory.inventory;

        IInventorySlot toSlot = slot;

        if ((otherItemUI.Item is IEquipment droppedItem) && droppedItem.State.isEquipped)
        {
            if(!slot.IsEmpty)
            {
                if ((slot.Item is IEquipment itemInSlot) && itemInSlot.EquipmentType == droppedItem.EquipmentType)
                {
                    itemInSlot.Equip();
                }
                else
                {
                    var emptySlot = UIInventory.inventory.FindEmptySlot();
                    toSlot = emptySlot;

                    if (emptySlot == null)
                        return;
                }
            }
            droppedItem.UnEquip();
        }

        inventory.TransitFromSlotToSlot(this, otherSlot, toSlot, otherSlotUI._uiInventory);

        Refresh();
        otherSlotUI.Refresh();
    }

    public void Refresh()
    {
        if (slot != null)
            _uiInventoryItem.Refresh(slot);
    }
}
