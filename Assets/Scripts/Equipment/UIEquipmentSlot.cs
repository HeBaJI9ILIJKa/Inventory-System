using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIEquipmentSlot : UIInventorySlot
{
    [SerializeField] private EquipmentType _expectedEquipmentType;

    public override void OnDrop(PointerEventData eventData)
    {
        var otherItemUI = eventData.pointerDrag.GetComponent<UIInventoryItem>();
        var otherSlotUI = otherItemUI.GetComponentInParent<UIInventorySlot>();

        bool sameInventory = otherSlotUI.UIInventory.inventory == UIInventory.inventory;

        IEquipment newItem = null;
        IEquipment oldItem = (IEquipment)slot?.Item;

        if (otherItemUI.Item is IEquipment item)
        {
            newItem = item; 
        }
        else
        {
            Debug.Log("Неверный тип предмета");
            return;
        }

        if (newItem.EquipmentType != _expectedEquipmentType)
        {
            Debug.Log("Неверный тип предмета");
            return;
        }

        
        var otherSlot = otherSlotUI.slot;
        var inventory = UIInventory.inventory;

        inventory.TransitFromSlotToSlot(this, otherSlot, slot, otherSlotUI.UIInventory);

        Refresh();
        otherSlotUI.Refresh();
        //otherSlotUI._uiInventory.inventory.SendInventoryStateChangedEvent(this);

        if (sameInventory)
            return;

        if(oldItem != null)
            oldItem.UnEquip();

        newItem.Equip();
    }
}
