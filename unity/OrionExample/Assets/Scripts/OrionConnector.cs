using UnityEngine;
using System.Collections;
using LitJson;
using System.Collections.Generic;

public class OrionConnector : MonoBehaviour {
	public string url = "http://178.21.117.113:1026/v1/contextEntities/test_entity";

	IEnumerator Start() {

		//Creating headers
		Dictionary<string,string> headers = new Dictionary<string,string>();
		headers.Add("Accept", "application/json");
		headers.Add("Content-Type", "application/json");

		//Making an entity call
		WWW www = new WWW(url,null, headers);
		yield return www;

		//Putting the JSON data into an Entity class instance (see Entity.cs)
		Entity entity = JsonUtility.FromJson<Entity>(www.text);
		print (entity.contextElement.id);

		//Updating an Entity, you can use the same call to create an entity.
		entity.contextElement.attributes[0].value = "726";

		//Be sure to only sent back the contextElement, you don't need the rest.
		byte[] postData = System.Text.Encoding.UTF8.GetBytes(JsonUtility.ToJson(entity.contextElement));
		WWW w = new WWW(url, postData, headers);
		yield return w;
		if (!string.IsNullOrEmpty(w.error)) {
			print(w.error);
		}
		else {
			print(w.text);
		}

	}
	// Update is called once per frame
	void Update () {
	
	}
}

[System.Serializable]
public class TestJSON {
	public string key = "unknown";
}