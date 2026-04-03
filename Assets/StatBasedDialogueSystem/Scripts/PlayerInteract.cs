using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public float interactRange = 3f; // Ne kadar uzaktan konuþabilir?

    void Update()
    {
        // E tuþuna basýldý mý?
        if (Input.GetKeyDown(KeyCode.E))
        {
            CheckForNPC();
        }
    }

    void CheckForNPC()
    {
        // Kameranýn (veya karakterin) tam karþýsýna görünmez çizgi (Ray) at
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        // Çizgi bir þeye çarptý mý?
        if (Physics.Raycast(ray, out hit, interactRange))
        {
            // Çarptýðý þeyde "NPCController" scripti var mý?
            NPCController npc = hit.collider.GetComponent<NPCController>();

            if (npc != null)
            {
                // Varsa etkileþimi baþlat
                npc.Interact();
            }
        }
    }

    // Editörde çizgiyi görmek için yardýmcý çizim (Gizmo)
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position, transform.forward * interactRange);
    }
}