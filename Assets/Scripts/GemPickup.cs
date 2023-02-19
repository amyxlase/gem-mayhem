using UnityEngine;

public class GemPickup : MonoBehaviour
{

	private void OnControllerColliderHit(ControllerColliderHit hit)
	{
		if (IsGem(hit)) CollectGem(hit); 
	}

	// Check if the hit gameobject has the Gem component on it
	private bool IsGem(ControllerColliderHit hit) {
		return (hit.gameObject.GetComponent<Gem>() != null);
	}

	// Get the audio source component of the player & play ding!
	// Disable the gem game object
	// You can use print() to test this collision mechanism
	private void CollectGem(ControllerColliderHit hit) {

		GameObject gem = hit.gameObject;
		AudioSource source = gameObject.GetComponent<AudioSource>();
		source.Play();
		gem.SetActive(false);
		print("Collected gem!");
		
	}
}