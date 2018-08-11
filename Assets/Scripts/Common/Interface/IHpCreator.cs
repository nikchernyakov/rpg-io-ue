using UnityEngine;

public interface IHpCreator
{
	AbstractHpShower Create(AbstractHpShower hpShowerPrefab, Transform parentTransform, Liveble liveble);
}
