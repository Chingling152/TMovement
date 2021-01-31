using UnityEngine;
using UnityEngine.EventSystems;
using TheChest.Scripts.UI.Components;

namespace 
    TheChest.UI.Components.Slots
{
    /// <summary>
    /// Class to handle Click On Slot
    /// </summary>
    [RequireComponent(typeof(UISlot))]
    [DisallowMultipleComponent]
    public sealed class UISlotPointerHandler : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler , IPointerExitHandler
    {
        [SerializeField] UISlot uiSlot;
        [SerializeField] UITooltip tooltip;

        public void Start()
        {
            this.uiSlot = this.GetComponent<UISlot>();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (eventData.button == PointerEventData.InputButton.Left)
            {
                uiSlot.Select();
            }
            else if (eventData.button == PointerEventData.InputButton.Right)
            {

            }
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            this.tooltip = Instantiate(tooltip, this.transform.position * 0.1f,transform.rotation);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            Destroy(this.tooltip);
        }
    }
}
