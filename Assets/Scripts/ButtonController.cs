using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class ButtonController : MonoBehaviour
    {
        private int _currentSceneId;

        public void SceneSelect(int id)
        {
            Debug.Log($"SceneId: {id}");
            _currentSceneId = id;
        }
        public void VideoSelect(int id)
        {
            Debug.Log($"VideoId: {id}");
        }
        public void StreamSelect(int id)
        {
            Debug.Log($"StreamId: {id}");
        }

        public void DisplaySelect(int id)
        {
            Debug.Log($"DisplayId: {id}");
        }

        public void FormationSelect(int id)
        {
            Debug.Log($"FormationId: {id}");

            var syncScript = gameObject.GetComponent<FormationSelectSync>();


            string scenePlusFormation = $"1{id}";
            int compoundId = int.Parse(scenePlusFormation);

            syncScript.SetId(compoundId);
        }
    }
}