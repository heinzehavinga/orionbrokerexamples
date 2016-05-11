using UnityEngine;
using System.Collections;

[System.Serializable]
public class ContextElement {
	public EntityAttribute[] attributes;
	public string type;
	public string isPattern = "false";
	public string id;
}

[System.Serializable]
public class EntityAttribute {
	public string name;
	public string type;
	public string value;
}

[System.Serializable]
public class StatusCode {
	public string code;
	public string reasonPhrase;
}

[System.Serializable]
public class Entity {
	public ContextElement contextElement = new ContextElement();
	public StatusCode statusCode = new StatusCode();
}
