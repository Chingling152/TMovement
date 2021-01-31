using TheChest.Items;
using UnityEngine;
using UnityEngine.UI;

namespace TheChest.Scripts.UI.Components
{
    public class UITooltip : MonoBehaviour
    {
        [SerializeField] Image itemIcon;

        [SerializeField] Text itemName;
        [SerializeField] Text itemDescription;

        public void ToggleShow(Item item)
        {
            this.itemIcon.sprite = item.Image;

            this.itemName.text = item.Name;
            this.itemDescription.text = item.Description;
        }
    }
}
