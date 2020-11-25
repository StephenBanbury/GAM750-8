using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class ButtonController : MonoBehaviour
    {
        private int _sceneId;

        public void SceneSelect(int sceneId)
        {
            Debug.Log($"SceneId: {sceneId}");
            _sceneId = sceneId;
        }
        public void VideoSelect(int videoId)
        {
            Debug.Log($"VideoId: {videoId}");
        }
        public void StreamSelect(int streamId)
        {
            Debug.Log($"StreamId: {streamId}");
        }

        public void DisplaySelect(int displayId)
        {
            Debug.Log($"DisplayId: {displayId}");
        }

        public void FormationSelect(int formationId)
        {
            Debug.Log($"FormationId: {formationId}");
        }
    }
}