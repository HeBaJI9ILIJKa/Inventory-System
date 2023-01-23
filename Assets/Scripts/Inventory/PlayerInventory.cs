
using UnityEngine;

public class PlayerInventory : UIInventory
{
    private static PlayerInventory _instance;
    private GameData _gameData;

    public static PlayerInventory Instance => _instance;

    public UIInventory Equipment;

    public UIQuickAccessMenuSlot[] QuickAccessMenuSlots;

    protected override void Initialize()
    {
        base.Initialize();
        _instance = this;
    }

    public void SaveInventory(GameData gameData)
    {
        inventory.SaveData(gameData.PlayerInventoryData.PlayerInventory);
    }

    public void LoadInventory(GameData gameData)
    { 
        this.inventory.LoadData(gameData.PlayerInventoryData.PlayerInventory);
    }

    public void SaveEquipment(GameData gameData)
    {
        Equipment.inventory.SaveData(gameData.PlayerInventoryData.PlayerEquipment);
    }

    public void LoadEquipment(GameData gameData)
    {
        Equipment.inventory.LoadData(gameData.PlayerInventoryData.PlayerEquipment);
    }

    public void SaveQAM(GameData gameData)
    {
        for (int i = 0; i < QuickAccessMenuSlots.Length; i++)
        {
            gameData.PlayerInventoryData.QuickAccessMenuItems.Items[i] = QuickAccessMenuSlots[i].QuickAccessMenuItem.Item;
        }
    }

    public void LoadQAM(GameData gameData)
    {
        for (int i = 0; i < QuickAccessMenuSlots.Length; i++)
        {
            QuickAccessMenuSlots[i].QuickAccessMenuItem.SetNewItem(gameData.PlayerInventoryData.QuickAccessMenuItems.Items[i]);
        }
    }

    public void Save()
    {
        PlayerInventoryData playerInventoryData = new PlayerInventoryData(inventory.Capacity, Equipment.inventory.Capacity, QuickAccessMenuSlots.Length);

        _gameData = new GameData(playerInventoryData);

        SaveInventory(_gameData);
        SaveEquipment(_gameData);
        SaveQAM(_gameData);
       
        Storage storage = new Storage();
        storage.Save(_gameData);
    }

    public void Load()
    {
        Storage storage = new Storage();

        PlayerInventoryData playerInventoryData = new PlayerInventoryData(inventory.Capacity, Equipment.inventory.Capacity, QuickAccessMenuSlots.Length);

        _gameData = (GameData)storage.Load(new GameData(playerInventoryData));

        InventoryItemInfo[] infoObjects = Resources.LoadAll<InventoryItemInfo>("Info");

        SetItemsInfo(infoObjects, _gameData.PlayerInventoryData.PlayerInventory);
        SetItemsInfo(infoObjects, _gameData.PlayerInventoryData.PlayerEquipment);
        SetItemsInfo(infoObjects, _gameData.PlayerInventoryData.QuickAccessMenuItems);

        LoadInventory(_gameData);
        LoadEquipment(_gameData);
        LoadQAM(_gameData);
    }

    private void SetItemsInfo(InventoryItemInfo[] infoObjects, InventoryData data)
    {
        for (int i = 0; i < data.Items.Length; i++)
        {
            foreach (var info in infoObjects)
            {
                if (info.TypeId == data.Items[i]?.TypeID)
                {
                    data.Items[i].SetInfo(info);
                    break;
                }
            }
        }
    }
}
