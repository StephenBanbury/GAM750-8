using UnityEngine;
using UnityEngine.UI;
using System.Text;

namespace Assets.Scripts
{
	public class OSCController: MonoBehaviour
	{
		public OscOut oscOut;

		[SerializeField] private Text _remoteHeaderLabel;
        [SerializeField] private Text _oscAddressLabel;

        StringBuilder _sb;

        private const string videoSelectAddress = "/select/video";
        private const string streamSelectAddress = "/select/stream";
        private const string displaySelectAddress = "/select/display";
        private const string formationSelectAddress = "/select/formation";


		void Awake()
		{
			_sb = new StringBuilder();
		}


		void Start()
		{
			_sb.Clear();
			_sb.Append( "PORT: " ); _sb.Append( oscOut.port );
			_sb.Append( ", IP ADDRESS: " ); _sb.Append( oscOut.remoteIpAddress );

            _remoteHeaderLabel.text = _sb.ToString();
            _oscAddressLabel.text = "";
        }
		
		// The following methods are meant to be linked to Unity's runtime UI from the Unity Editor.

        public void VideoSelect(int videoId)
        {
			Debug.Log($"VideoId: {videoId}");
            _oscAddressLabel.text = $"{videoSelectAddress}/{videoId}";
            oscOut.Send(videoSelectAddress, videoId);
		}
        public void StreamSelect(int streamId)
        {
            Debug.Log($"StreamId: {streamId}");
            _oscAddressLabel.text = $"{streamSelectAddress}/{streamId}";
            oscOut.Send(streamSelectAddress, streamId);
        }

		public void DisplaySelect(int displayId)
        {
			Debug.Log($"DisplayId: {displayId}");
            _oscAddressLabel.text = $"{displaySelectAddress}/{displayId}";
            oscOut.Send(displaySelectAddress, displayId);
		}

        public void FormationSelect(int formationId)
        {
            Debug.Log($"FormationId: {formationId}");
            _oscAddressLabel.text = $"{formationSelectAddress}/{formationId}";
            oscOut.Send(formationSelectAddress, formationId);
        }

	}
}