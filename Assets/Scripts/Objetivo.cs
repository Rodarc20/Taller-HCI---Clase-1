using UnityEngine;

public class Objetivo : MonoBehaviour {
    /*public void OnCollisionEnter(Collision other){//para usar esto el objeto debe tener un collider y un rigidbody
        GameObject player = other.gameObject;
        if(player.layer == LayerMask.NameToLayer("Jugador")){
            print("jugador");
            MoveCube moveCube = player.GetComponent<MoveCube>();
            if(moveCube.pequeno){
                player.transform.localScale = new Vector3 (1f, 1f, 1f);
                player.transform.position = new Vector3 (player.transform.position.x, 0.5f, player.transform.position.z);
                moveCube.pequeno = false;
                Destroy(gameObject);
            }
        }
    }*/
}
//detecta los puntos de contacto, si se requiere precion