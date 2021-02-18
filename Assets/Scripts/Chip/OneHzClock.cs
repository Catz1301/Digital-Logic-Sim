using UnityEngine;

public class OneHzClock : BuiltinChip {

	protected override void Awake () {
		base.Awake ();
	}

	protected override void ProcessOutput () {
		int outputSignal = Mathf.round(Time.realtimeSinceStartup) % 2;
		outputPins[0].ReceiveSignal(outputSignal);
	}

}
