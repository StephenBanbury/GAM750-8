using System;
using Normal.Realtime;
using UnityEngine;

namespace Assets.Scripts
{
    public class FormationSelectSync : RealtimeComponent<FormationSelectSyncModel>
    {
        private int _formationId;

        private void Awake()
        {
            _formationId = 0;
        }

        protected override void OnRealtimeModelReplaced(FormationSelectSyncModel previousModel,
            FormationSelectSyncModel currentModel)
        {
            Debug.Log($"PreviousModel: {previousModel != null}");
            Debug.Log($"CurrentModel: {currentModel != null}");

            if (previousModel != null)
            {
                // Unregister from events
                previousModel.formationIdDidChange -= FormationIdDidChange;
            }

            if (currentModel != null)
            {
                // If this is a model that has no data set on it, populate it with the current value.
                if (currentModel.isFreshModel)
                    currentModel.formationId = _formationId;

                // Update the formationId to match the new model
                UpdateFormationId();

                // Register for events so we'll know if the value changes later
                currentModel.formationIdDidChange += FormationIdDidChange;
            }
        }

        private void FormationIdDidChange(FormationSelectSyncModel model, int value)
        {
            Debug.Log($"FormationIdDidChange {model.formationId}");
            UpdateFormationId();
        }

        private void UpdateFormationId()
        {
            Debug.Log($"UpdateFormationId {model.formationId}");

            _formationId = model.formationId;
        }

        public void SetId(int id)
        {
            Debug.Log($"Model is null: {model == null}");

            // Set the value on the model
            // This will fire the value changed event on the model, which will update the value for both the local player and all remote players
            model.formationId = id;
        }

    }
}