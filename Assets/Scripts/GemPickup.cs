using UnityEngine;

public class GemPickup : MonoBehaviour
{

	private void OnControllerColliderHit(ControllerColliderHit hit)
	{
		if (IsGem(hit)) CollectGem(hit); 
	}

	private bool IsGem(ControllerColliderHit hit) {
		return (hit.gameObject.GetComponent<Gem>() != null);
	}

	// Play ding & disactivate gem
	private void CollectGem(ControllerColliderHit hit) {
		GameObject gem = hit.collider.gameObject;
		AudioSource source = gameObject.GetComponent<AudioSource>();
		source.Play();
		gem.SetActive(false);
		print("Collecting gem!");
	}
}