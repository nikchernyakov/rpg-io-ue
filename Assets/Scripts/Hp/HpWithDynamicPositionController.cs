using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpWithDynamicPositionController : AbstractHpShower
{
	private HpPositionController _hpPositionController;
	private IHpUpdater _hpUpdater;
	private Liveble _liveble;
	
	public override void Init(Liveble liveble)
	{
		_liveble = liveble;
		
		// Get components
		_hpUpdater = GetComponent<IHpUpdater>();
		_hpPositionController = GetComponent<HpPositionController>();
		
		// Init components
		_hpUpdater.InitHp(liveble.GetCurrentHp());
		_hpPositionController.Init(liveble.transform);
	}

	private void Update()
	{
		// Update components
		_hpUpdater.UpdateHp(_liveble.GetCurrentHp());
		_hpPositionController.UpdatePosition();
	}
}
