using UnityEngine;
public class SomColeta : MonoBehaviour { 
  public AudioClip somColeta; 
  private void OnTriggerEnter(Collider other) { 
    if (other.CompareTag("Player")) { 
      AudioSource.PlayClipAtPoint( somColeta, transform.position ); 
    }
  } 
}
