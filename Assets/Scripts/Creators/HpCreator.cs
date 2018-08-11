using UnityEngine;
using UnityEngine.UI;

public class HpCreator : MonoBehaviour, IHpCreator
{
    
    public AbstractHpShower Create(AbstractHpShower hpShowerPrefab, Transform parentTransform, Liveble liveble)
    {
        var hpShowerInstance = Instantiate(hpShowerPrefab, parentTransform);
        //hpTextInstance.transform.parent = parentTransform.transform;
        hpShowerInstance.Init(liveble);
        return hpShowerInstance;
    }
}