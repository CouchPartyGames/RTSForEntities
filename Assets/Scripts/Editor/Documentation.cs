using UnityEditor;
using UnityEngine;

namespace Editor {
    public class Documentation : MonoBehaviour {
        [MenuItem("RTS Entities/Github", false, 51)]
        public static void Github() {
            Application.OpenURL("https://github.com/CouchPartyGames/RTSForEntities");
        }

        [MenuItem("RTS Entities/YouTube", false, 52)]
        public static void Youtube() {
            Application.OpenURL("https://www.youtube.com/@couchpartygames/playlists");
        }

        [MenuItem("RTS Entities/Documentation", false, 53)]
        public static void Docu() {
            Application.OpenURL("");
        }
    }
}