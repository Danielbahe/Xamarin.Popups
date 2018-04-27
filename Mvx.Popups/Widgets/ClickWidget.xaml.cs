using System;
using System.Threading.Tasks;
using Xamarin.Popups.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Popups.Translations;

namespace Xamarin.Popups.Widgets
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ClickWidget : ContentView, IWidget<bool>
	{
	    public bool Answer { get; set; }
	    public bool Answered { get; set; }
        public ClickWidget (string message = null, string okText = null)
		{
			InitializeComponent ();

		    SetText(message, okText);
		}

	    private void SetText(string message, string okText)
	    {
	        if (message == null) message = PopupResources.SampleMessage;
	        if (okText == null) okText = PopupResources.Ok;
	        messageLabel.Text = message;
	        acceptButton.Text = okText;
        }

	    public async Task<bool> GetAnswer()
        {
            await Task.Run(() =>
            {
                while (!Answered)
                {

                }
            });
            return Answer;
        }

	    private void Button_OnClicked(object sender, EventArgs e)
	    {
	        Answer = true;
	        Answered = true;
	    }
	}
}