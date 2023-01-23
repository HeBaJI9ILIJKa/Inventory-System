using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class UIQuickAccessMenuItem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Image _imageIcon;
    [SerializeField] private Text _textAmount;

    public IInventoryItem Item { get; private set; }

    private Coroutine _showTooltipWithDelay;
    private RectTransform _rectTransform;

    public int Amount => Item != null ? Item.State.amount : 0;

    private void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    public void Refresh()
    {
        if (Item == null)
            return;

        Item.State.amount = UpdateAmount();

        if (Amount == 0 && _textAmount.enabled)
        {
            _textAmount.enabled = false;
            _imageIcon.color = Color.gray;
        }
        if (Amount > 0 && !_textAmount.enabled)
        {
            _textAmount.enabled = true;
            _imageIcon.color = Color.white;
        }
    }

    public void SetNewItem(IInventoryItem item)
    {
        if (item == null)
            return;

        Item = item.Clone();
        _imageIcon.sprite = Item.ItemInfo.SpriteIcon;
        Refresh();
    }

    public int UpdateAmount()
    {
        var amount = PlayerInventory.Instance.inventory.GetItemAmountByTypeID(Item.TypeID);
        _textAmount.text = amount.ToString();
        return amount;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (Item == null)
            return;

        string header = Item.ItemInfo.Title;

        string content = Item.ItemInfo.Description + "\n";

        if (Item.ItemInfo.Price != 0)
            content += "Цена: " + Item.ItemInfo.Price.ToString() + "\n";

       _showTooltipWithDelay = StartCoroutine(ShowTooltipWithDelayRoutine(content, header));
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (_showTooltipWithDelay == null)
            return;

        StopCoroutine(_showTooltipWithDelay);
        TooltipSystem.Hide();
    }

    private IEnumerator ShowTooltipWithDelayRoutine(string content, string header)
    {
        yield return new WaitForSeconds(0.5f);
        Vector2 position = Camera.current.WorldToScreenPoint(_rectTransform.position);

        TooltipSystem.Show(position, content, header);
    }

}
