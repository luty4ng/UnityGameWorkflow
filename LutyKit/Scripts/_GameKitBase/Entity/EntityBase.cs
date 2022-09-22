using UnityEngine;
using GameKit;
using UnityGameKit.Runtime;

public abstract class EntityBase : EntityLogic
{
    public int Id
    {
        get
        {
            return Entity.Id;
        }
    }

    public Animation CachedAnimation
    {
        get;
        private set;
    }

    protected override void OnInit(object userData)
    {
        base.OnInit(userData);
        CachedAnimation = GetComponent<Animation>();
    }

    protected override void OnRecycle()
    {
        base.OnRecycle();
    }

    protected override void OnShow(object userData)
    {
        base.OnShow(userData);
    }

    protected override void OnHide(bool isShutdown, object userData)
    {
        base.OnHide(isShutdown, userData);
    }

    protected override void OnAttached(EntityLogic childEntity, Transform parentTransform, object userData)
    {
        base.OnAttached(childEntity, parentTransform, userData);
    }

    protected override void OnDetached(EntityLogic childEntity, object userData)
    {
        base.OnDetached(childEntity, userData);
    }

    protected override void OnAttachTo(EntityLogic parentEntity, Transform parentTransform, object userData)
    {
        base.OnAttachTo(parentEntity, parentTransform, userData);
    }

    protected override void OnDetachFrom(EntityLogic parentEntity, object userData)
    {
        base.OnDetachFrom(parentEntity, userData);
    }

    protected override void OnUpdate(float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(elapseSeconds, realElapseSeconds);
    }
}

