using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class JoystickControl : MonoBehaviour
{
    private Transform fill;
    [SerializeField]
    private Camera UIcamera;
    private Vector3 startPos;//小圆点的初始位置
    private Rect rect;
    private float cache_r;
    public Vector3 dir;

    private void Awake()
    {
        fill = transform.Find("Fill");
    }
    private void Start()
    {
        AddTriggerListener(fill.gameObject, EventTriggerType.Drag, (o) => OnJoystickDragAction());
        AddTriggerListener(fill.gameObject, EventTriggerType.PointerUp, (o) => OnJoystickUpAction());

        startPos = fill.position;
        rect = GetComponent<RectTransform>().rect;

        Vector3 size = transform.TransformVector(rect.width, rect.height, 0);

        cache_r = size.x / 2;
    }
    private void OnJoystickDragAction()//拖动
    {
        Vector3 worldPos = UIcamera.ScreenToWorldPoint(Input.mousePosition);
        worldPos.z = fill.position.z;
        
        float distance = Vector3.Distance(startPos, worldPos);
        if (distance >= cache_r)
        {
            dir = (worldPos - startPos).normalized;
            worldPos = startPos + dir * cache_r;
        }
        fill.position = worldPos;
    }
    private void OnJoystickUpAction()//停止
    {
        fill.position = startPos;
    }
    private void AddTriggerListener(GameObject obj, EventTriggerType eventID, UnityAction<BaseEventData> action)
    {
        EventTrigger trigger;
        if (obj.GetComponent<EventTrigger>() != null)
        {
            trigger = obj.GetComponent<EventTrigger>();
        }
        else
        {
            trigger = obj.AddComponent<EventTrigger>();
        }

        if (trigger.triggers.Count == 0)
        {
            trigger.triggers = new List<EventTrigger.Entry>();
        }

        UnityAction<BaseEventData> callback = new UnityAction<BaseEventData>(action);
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = eventID;
        entry.callback.AddListener(callback);
        trigger.triggers.Add(entry);
    }
}
